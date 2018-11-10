using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RawForms
{
    public partial class ProductSale : Form
    {
        public ProductSale()
        {
            InitializeComponent();
        }

        private void timerSales_Tick(object sender, EventArgs e)
        {
            lblDate.Text= System.DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt");
        }
    }
}
