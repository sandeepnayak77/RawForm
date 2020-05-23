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
    public partial class AddNewUnit : Form
    {
        public AddNewUnit()
        {
            InitializeComponent();
        }
        private Results AddUnit()
        {
            var result = new Results();
            try
            {
                var database = new InventoryEntities();
                var count = (from c in database.ProductUnits where c.UnitName == txtUnit.Text.Trim() select c).FirstOrDefault();
                if (count == null)
                {
                    var unit = new ProductUnit();
                    unit.UnitName = txtUnit.Text.Trim();
                    result.Result = true;
                    database.ProductUnits.Add(unit);

                    database.SaveChanges();
                    result.Message = " New Unit Successfully Added !!! ";
                }
                else
                {
                    result.Result = false;
                    result.Message = "Unit Already Exist";
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

        private void AddNewUnit_Load(object sender, EventArgs e)
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
            if (txtUnit.Text.Trim() == "" || ControlValidation.IsReserveWord(txtUnit.Text.Trim().ToLower()))
            {
                lblError.Text = "Please Enter a valid Unit...";
                lblError.ForeColor = Color.Red;
            }
            else
            {
                var result = AddUnit();
                if (result.Result == true)
                {
                    ProductEntry prodEntry = (ProductEntry)Owner.ActiveControl;
                    prodEntry.BindUnits();

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
