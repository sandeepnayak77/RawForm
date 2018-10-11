using RawForms.AppUtil;
using RawForms.Connection;
using RawForms.Dialog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        public void BindUnits()
        {
            var database = new InventoryEntities();
            var units = (from c in database.ProductUnits select c).ToList();
            units.Insert(0, new ProductUnit { UnitID = 0, UnitName = "--Select Units--" });
            cmbUnit.DisplayMember = "UnitName";
            cmbUnit.ValueMember = "UnitID";
            cmbUnit.DataSource = units;
        }
        public void BindProductType()
        {
            var database = new InventoryEntities();
            var catagory = Convert.ToInt32(cmbCatagory.SelectedValue);
            var types = (from c in database.ProductTypes where c.CatagoryID==catagory select c).ToList();
            types.Insert(0, new ProductType { TypeID = 0, TypeName = "Select Type of Product" });
            cmbProductType.DisplayMember = "TypeName";
            cmbProductType.ValueMember = "TypeID";
            cmbProductType.DataSource = types;
        }

        public void BindProductSubType()
        {
            var database = new InventoryEntities();
            var typeID = Convert.ToInt32(cmbProductType.SelectedValue);
            var subtypes = (from c in database.ProductSubTypes where c.TypeID == typeID select c).ToList();
            subtypes.Insert(0, new ProductSubType { SubTypeID = 0, SubTypeName = "--Select Sub-Type --" });
            cmbSubType.DisplayMember = "SubTypeName";
            cmbSubType.ValueMember = "SubTypeID";
            cmbSubType.DataSource = subtypes;
        }

        public void BindProductVariety()
        {
            var database = new InventoryEntities();
            var subTypeID = Convert.ToInt32(cmbSubType.SelectedValue);
            var varients = (from c in database.ProductVarients where c.SubTypeID == subTypeID select c).ToList();
            varients.Insert(0, new ProductVarient { VarientID = 0, VarientName = "--Select Sub-Type --" });
            cmbVariety.DisplayMember = "VarientName";
            cmbVariety.ValueMember = "VarientID";
            cmbVariety.DataSource = varients;
        }



        private void ProductEntry_Load(object sender, EventArgs e)
        {
            lblError.Text = "";
            BindCatagories();
            BindUnits();
        }

        private void btnCatagory_Click(object sender, EventArgs e)
        {
            var addNewCat = new AddNewCatagory();
            addNewCat.ShowDialog(this);
        }

        private void btnUnit_Click(object sender, EventArgs e)
        {
            var newUnit = new AddNewUnit();
            newUnit.ShowDialog(this);
        }

        

        private void cmbCatagory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbCatagory.SelectedIndex>0)
            {
                cmbProductType.Enabled = true;
                BindProductType();
                lblError.Text = "";
            }
            else
            {
                cmbProductType.Text = "";
                cmbProductType.Enabled = false;
                cmbSubType.Text = "";
                cmbSubType.Enabled = false;

            }
            
        }
        private void cmbProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProductType.SelectedIndex > 0)
            {
                cmbSubType.Enabled = true;
                BindProductSubType();
                lblError.Text = "";
            }
            else
            {
                cmbSubType.Text = "";
                cmbSubType.Enabled = false;

            }

        }

        private void btnTypeAdd_Click(object sender, EventArgs e)
        {
            if (cmbCatagory.SelectedIndex > 0)
            {
                var newType = new AddNewProductType();
                newType.CatagoryID = Convert.ToInt32(cmbCatagory.SelectedValue);
                newType.ShowDialog(this);
                lblError.Text = "";
            }
            else
            {
                lblError.Text = "Select Catagory First";
                lblError.ForeColor = Color.Red;
            }
            
        }

        private void btnSubTypeAdd_Click(object sender, EventArgs e)
        {
            if (cmbProductType.SelectedIndex > 0 && cmbCatagory.SelectedIndex > 0)
            {
                var newSubType = new AddNewSubType();
                newSubType.TypeID = Convert.ToInt32(cmbProductType.SelectedValue);
                newSubType.ShowDialog(this);
                lblError.Text = "";
            }
            else
            {
                lblError.Text = "Select Type First";
                lblError.ForeColor = Color.Red;
            }
        }

        private void cmbSubType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSubType.SelectedIndex > 0)
            {
                cmbVariety.Enabled = true;
                BindProductVariety();
                lblError.Text = "";
            }
            else
            {
                cmbVariety.Text = "";
                cmbVariety.Enabled = false;

            }
        }

        private void btnVariety_Click(object sender, EventArgs e)
        {
            if (cmbSubType.SelectedIndex > 0 && cmbProductType.SelectedIndex > 0 && cmbCatagory.SelectedIndex > 0)
            {
                var newVarient = new AddNewVariant();
                newVarient.SubTypeID = Convert.ToInt32(cmbSubType.SelectedValue);
                newVarient.ShowDialog(this);
                lblError.Text = "";
            }
            else
            {
                lblError.Text = "Select Sub-Type First";
                lblError.ForeColor = Color.Red;
            }
        }

        private void txtCostPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            ControlValidation.IsPrice(sender, e);
        }

        private void txtMRP_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlValidation.IsPrice(sender, e);
        }

        private void txtSalesPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlValidation.IsPrice(sender, e);
        }
    }
}
