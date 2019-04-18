using System;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace metno.UI
{
    public partial class DataForm : Form
    {
        public DataForm()
        {
            InitializeComponent();            
        }

        private void SetupNowcastsControls()
        {
            nowcastListView.Clear();
            _ = new ListView.ColumnHeaderCollection(nowcastListView)
            {
                "Nedbør",
                "Tidspunkt fra",
                "Tidspunkt til"
            };
            nowcastListView.FullRowSelect = true;
            nowcastListView.MultiSelect = false;
        }

        private void SetupMetAlertsControls()
        {
            metalertsListView.Clear();
            _ = new ListView.ColumnHeaderCollection(metalertsListView)
            {
                "Tittel"
            };
            metalertsListView.FullRowSelect = true;
            metalertsListView.MultiSelect = false;
        }

        private void FetchDataButton_Click(object sender, EventArgs e)
        {
            if (mainTabControl.SelectedTab == tabPage1)
            {

                // Nedbørsdata - forecast for the next two hours.
                var frm = new FindLocationForm();
                frm.ShowDialog();
                PopulateNowcastListAsync(frm.Latitude.ToString(CultureInfo.InvariantCulture), frm.Longitude.ToString(CultureInfo.InvariantCulture), frm.Address);
                frm.Dispose();
            }

            if (mainTabControl.SelectedTab == tabPage2)
            {
                // Metalerts - Farevarsler fra Meterologisk Institutt.
                PopulateMetAlertsAsync();
            }
        }

        private async void PopulateMetAlertsAsync()
        {
            Cursor = Cursors.WaitCursor;
            SetupMetAlertsControls();
            
            var result = await Downloader.Download("https://api.met.no/weatherapi/metalerts/1.1?show=all");
            if (result.Length > 0)
            {
                var ma = (MetAlertsDataTypes.Rss)Parser.Parse(result, ParseType.Xml, typeof(MetAlertsDataTypes.Rss));
                foreach (var item in ma.Channel.Item)
                { 
                    var lvi = new ListViewItem
                    {
                        Text = item.Title,
                        Tag = item
                    };
                    metalertsListView.Items.Add(lvi);
                }
                metalertsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                metalertsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            Cursor = Cursors.Default;
        }

        private async void PopulateNowcastListAsync(string lat, string lon, string address)
        {
            Cursor = Cursors.WaitCursor;
            SetupNowcastsControls();
            
            var result = await Downloader.Download($"https://api.met.no/weatherapi/nowcast/0.9/?lat={lat}&lon={lon}");
            if (result.Length > 0) // We have received a non-empty result
            {
                var wd = (NowcastDataTypes.Weatherdata)Parser.Parse(result, ParseType.Xml, typeof(NowcastDataTypes.Weatherdata));
                foreach (var item in wd.Product.Time)
                {
                    var lvi = new ListViewItem
                    {
                        Text = $"{item.Location.Precipitation.Value} {item.Location.Precipitation.Unit}",
                        Tag = item
                    };

                    var fromItem = new ListViewItem.ListViewSubItem
                    {
                        Text = Convert.ToDateTime(item.From).ToString()
                    };
                    lvi.SubItems.Add(fromItem);

                    var toTime = new ListViewItem.ListViewSubItem
                    {
                        Text = Convert.ToDateTime(item.To).ToString()
                    };
                    lvi.SubItems.Add(toTime);

                    nowcastListView.Items.Add(lvi);                    

                }
                nowcastListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                nowcastListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                CreatedTextBox.Text = Convert.ToDateTime(wd.Created).ToString();
                LocationTextBox.Text = $"Lat: {wd.Product.Time[0].Location.Latitude}, Lon: {wd.Product.Time[0].Location.Longitude}";
                LocationAddressLabel.Text = address;
            }
            Cursor = Cursors.Default;
        }

        private void MetalertsListView_DoubleClick(object sender, EventArgs e)
        {
            if (metalertsListView.SelectedItems != null) 
            {
                var frm = new MetAlertForm(metalertsListView.SelectedItems[0]);
                frm.ShowDialog();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Parser.StripHtml("<html><head></head><body>Test</body></html>"));
        }
    }
}