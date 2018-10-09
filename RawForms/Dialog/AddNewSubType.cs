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
    public partial class AddNewSubType : Form
    {
        public AddNewSubType()
        {
            InitializeComponent();
        }
        public int TypeID { get; set; }
        public Results AddNewType()
        {
            var result = new Results();
            try
            {
                var database = new InventoryEntities();
                var count = (from c in database.ProductSubTypes where c.SubTypeName == txtSubType.Text.Trim() select c).FirstOrDefault();
                if (count == null)
                {
                    var productSubType = new ProductSubType();
                    productSubType.SubTypeName = txtSubType.Text.Trim();
                    productSubType.TypeID = TypeID;
                    database.ProductSubTypes.Add(productSubType);
                    database.SaveChanges();
                    result.Message = " New Item Sub-Type Successfully Added !!! ";
                    result.Result = true;
                }
                else
                {
                    result.Result = false;
                    result.Message = "Item Sub-Type Already Exist";
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






        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtSubType.Text.Trim() == "" || ControlValidation.IsReserveWord(txtSubType.Text.Trim().ToLower()))
            {
                lblError.Text = "Please Enter a valid Item Sub-Type...";
                lblError.ForeColor = Color.Red;
            }
            else
            {
                var result = AddNewType();
                if (result.Result == true)
                {
                    ProductEntry prodEntry = (ProductEntry)Owner;
                    prodEntry.BindProductSubType();
                    txtSubType.Text = "";
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

        private void AddNewSubType_Load(object sender, EventArgs e)
        {
            lblError.Text = "";
        }
    }
}
