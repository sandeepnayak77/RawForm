using RawForms.AppUtil;
using RawForms.Connection;
using RawForms.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RawForms.Dialog
{
    public partial class AddNewProductType : Form
    {
        public AddNewProductType()
        {
            InitializeComponent();
        }
        public int CatagoryID { get; set; }
        public Results AddNewType()
        {
            var result = new Results();
            try
            {
                var database = new InventoryEntities();
                var count = (from c in database.ProductTypes where c.TypeName == txtProductType.Text.Trim() select c).FirstOrDefault();
                if (count == null)
                {
                    var productType = new ProductType();
                    productType.TypeName = txtProductType.Text.Trim();
                    productType.CatagoryID = CatagoryID;
                    database.ProductTypes.Add(productType);
                    database.SaveChanges();
                    result.Message = " New Item Type Successfully Added !!! ";
                    result.Result = true;
                }
                else
                {
                    result.Result = false;
                    result.Message = "Item Type Already Exist";
                }
                return result;
            }
            catch (Exception ex)
            {
                result.Result = false;
                result.Message = "Unknown Error";
                return result;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtProductType.Text.Trim() == "" || ControlValidation.IsReserveWord(txtProductType.Text.Trim().ToLower()))
            {
                lblError.Text = "Please Enter a valid Item Type...";
                lblError.ForeColor = Color.Red;
            }
            else
            {
                var result = AddNewType();
                if (result.Result == true)
                {
                    ProductEntry prodEntry = (ProductEntry)Owner;
                    prodEntry.BindProductType();
                    txtProductType.Text = "";
                    lblError.Text = result.Message;
                    lblError.ForeColor = Color.Green;
                }
                else
                {
                    lblError.Text = result.Message;
                    lblError.ForeColor = Color.Red;
                }
            }
        }

        private void AddNewProductType_Load(object sender, EventArgs e)
        {
            lblError.Text = "";
            lblError.ForeColor = Color.Red;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

