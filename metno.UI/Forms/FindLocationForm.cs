using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace metno.UI
{
    public partial class FindLocationForm : Form
    {
        const string KEY = "";

        public double Latitude { get; private set; }
        public double Longitude { get; private set; }
        public string Address { get; private set; }

        public FindLocationForm()
        {
            InitializeComponent();
            CloseButton.Enabled = false;
        }

        private async Task<GoogleGeocodingDataTypes.RootObject> SearchGoogleGeo(string input)
        {
            var result = await Downloader.Download($"https://maps.googleapis.com/maps/api/geocode/json?address={input}&key={KEY}");

            if (result.Length > 0)
            {
                return (GoogleGeocodingDataTypes.RootObject)Parser.Parse(result, ParseType.Json, typeof(GoogleGeocodingDataTypes.RootObject));
            }
            return null;
        }

        private async void SearchButton_ClickAsync(object sender, EventArgs e)
        {
            SetupListView();
            Cursor = Cursors.WaitCursor;
            var ost = await SearchGoogleGeo(SearchTextBox.Text);
            Cursor = Cursors.Default;
            foreach (var item in ost.Results)
            {
                var lvi = new ListViewItem
                {
                    Text = item.Formatted_address,
                    Tag = item
                };
                
                var latItem = new ListViewItem.ListViewSubItem
                {
                    Text = item.Geometry.Location.Lat.ToString()
                };

                var lonItem = new ListViewItem.ListViewSubItem
                {
                    Text = item.Geometry.Location.Lng.ToString()
                };

                lvi.SubItems.Add(latItem);
                lvi.SubItems.Add(lonItem);

                ResultListView.Items.Add(lvi);
            }
            ResultListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            ResultListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void SetupListView()
        {
            ResultListView.Clear();
            _ = new ListView.ColumnHeaderCollection(ResultListView)
            {                
                "Adresse",
                "Latitude",
                "Longitude"
            };

            ResultListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            ResultListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void SearchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == '\r')
            {
                e.Handled = true;
                SearchButton_ClickAsync(this, EventArgs.Empty);
            }
        }

        private void ResultListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ResultListView.SelectedItems != null)
            {
                var selectedItem = (GoogleGeocodingDataTypes.Result)ResultListView.SelectedItems[0].Tag;
                Latitude = selectedItem.Geometry.Location.Lat;
                Longitude = selectedItem.Geometry.Location.Lng;
                Address = selectedItem.Formatted_address;
                CloseButton.Enabled = true;
            }
            else
            {
                CloseButton.Enabled = false;
            }            
        }
    }
}