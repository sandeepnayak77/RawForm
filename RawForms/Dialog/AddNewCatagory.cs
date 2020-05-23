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

namespace RawForms
{
    public partial class AddNewCatagory : Form
    {
        public AddNewCatagory()
        {
            InitializeComponent();
        }

        private Results AddCatagory()
        {
            var result = new Results();
            try
            {
                var database = new InventoryEntities();
                var count = (from c in database.ProductCatagories where c.CatagoryName == txtCatagory.Text.Trim() select c).FirstOrDefault();
                if (count == null)
                {
                    var catagory = new ProductCatagory();
                    catagory.CatagoryName = txtCatagory.Text.Trim();
                    result.Result = true;
                    database.ProductCatagories.Add(catagory);

                    database.SaveChanges();
                    result.Message = " New Catagory Successfully Added !!! ";
                }
                else
                {
                    result.Result = false;
                    result.Message = "Catagory Already Exist";
                }
                return result;
            }
            catch(Exception ex)
            {
                result.Result = false;
                result.Message = "Unknown Error";
                return result;
            }
            


        }

        private void AddNewCatagory_Load(object sender, EventArgs e)
        {
            lblError.Text = "";
            lblError.ForeColor = Color.Red;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtCatagory.Text.Trim()=="" || ControlValidation.IsReserveWord(txtCatagory.Text.Trim().ToLower()) )
            {
                lblError.Text = "Please Enter a valid Catagory...";
                lblError.ForeColor = Color.Red;
            }
            else
            {
                var result = AddCatagory();
                if (result.Result == true)
                {
                    ProductEntry prodEntry = (ProductEntry) Owner.ActiveControl;
                    prodEntry.BindCatagories();

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
