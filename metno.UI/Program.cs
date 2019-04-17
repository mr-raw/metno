using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace metno.UI
{
    class Program
    {
        static int Main()
        {            
            var form = new DataForm();
            form.ShowDialog();
            return 0;
        }
    }
}