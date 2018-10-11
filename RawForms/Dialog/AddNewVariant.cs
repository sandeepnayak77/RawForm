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
    public partial class AddNewVariant : Form
    {
        public AddNewVariant()
        {
            InitializeComponent();
        }

        public int SubTypeID { get; set; }
        public Results AddNewVariety()
        {
            var result = new Results();
            try
            {
                var database = new InventoryEntities();
                var count = (from c in database.ProductVarients where c.VarientName == txtVariety.Text.Trim() select c).FirstOrDefault();
                if (count == null)
                {
                    var productVariants = new ProductVarient();
                    productVariants.VarientName = txtVariety.Text.Trim();
                    productVariants.SubTypeID = SubTypeID;
                    database.ProductVarients.Add(productVariants);
                    database.SaveChanges();
                    result.Message = " New product Variety Successfully Added !!! ";
                    result.Result = true;
                }
                else
                {
                    result.Result = false;
                    result.Message = "Variety Already Exist";
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






        private void AddNewVariant_Load(object sender, EventArgs e)
        {
            lblError.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtVariety.Text.Trim() == "" || ControlValidation.IsReserveWord(txtVariety.Text.Trim().ToLower()))
            {
                lblError.Text = "Please Enter a valid Variety...";
                lblError.ForeColor = Color.Red;
            }
            else
            {
                var result = AddNewVariety();
                if (result.Result == true)
                {
                    ProductEntry prodEntry = (ProductEntry)Owner;
                    prodEntry.BindProductVariety();
                    txtVariety.Text = "";
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
    }
}
