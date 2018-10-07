using RawForms.Connection;
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
    public partial class ProductEntry : Form
    {
        public ProductEntry()
        {
            InitializeComponent();
        }
        public void BindCatagories()
        {
            var database = new InventoryEntities();
            var catagories = (from c in database.ProductCatagories select c).ToList();
            catagories.Insert(0, new ProductCatagory { CatagoryID = 0, CatagoryName = "--Select Catagory--" });
            cmbCatagory.DisplayMember = "CatagoryName";
            cmbCatagory.ValueMember = "CatagoryID";
            cmbCatagory.DataSource = catagories;
        }

        private void ProductEntry_Load(object sender, EventArgs e)
        {
            BindCatagories();
        }
    }
}
