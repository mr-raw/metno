using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace metno.UI
{
    public partial class MetAlertForm : Form
    {
        private readonly Alert _decodedAlert;

        public MetAlertForm(ListViewItem item)
        {            
            var i = (MetAlertsDataTypes.Item)item.Tag;
            _decodedAlert = new Alert(i);
            InitializeComponent();
            SetupComponents();
        }

        private void SetupComponents()
        {
            DescriptionTextBox.Text = _decodedAlert.Description;
            FromDateTextBox.Text = _decodedAlert.From.ToString();
            ToDateTextBox.Text = _decodedAlert.To.ToString();
            CategoryTextBox.Text = _decodedAlert.AlertType;
            AreaTextBox.Text = _decodedAlert.Area;
            BackColor = _decodedAlert.Level;
        }
    }
}