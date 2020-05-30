using RawForms.AppUtil;
using RawForms.Connection;
using RawForms.Dialog;
using RawForms.Entities;
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
        
        public Results AddPoductInfo(double cp, double mrp, double sp)
        {
            
            var result = new Results();
            
            int catID = Convert.ToInt32(cmbCatagory.SelectedValue);
            int typeID = Convert.ToInt32(cmbProductType.SelectedValue);
            int subTypeID = Convert.ToInt32(cmbSubType.SelectedValue);
            int varientID = Convert.ToInt32(cmbVariety.SelectedValue);
            int unitId = Convert.ToInt32(cmbUnit.SelectedValue);
            string desc = txtDescription.Text.Trim();
            decimal dec_cp = Convert.ToDecimal(cp);
            decimal dec_mrp = Convert.ToDecimal(mrp);
            decimal dec_sp = Convert.ToDecimal(sp);


            string prodCode = "FFU";
            
            try
            {
                var database = new InventoryEntities();
                var count = (from c in database.ProductInfoes
                             where c.CatagoryID ==catID && c.TypeID==typeID && c.SubTypeID==subTypeID && c.VarientID==varientID
                             select c).FirstOrDefault();
                if (count == null)
                {
                    var productInfo = new ProductInfo();
                    var prodPrice = new ProductPrice();
                    var productStock = new ProductStock();
                    var stockChild = new StockChild();

                    productInfo.CatagoryID = catID;
                    productInfo.TypeID = typeID;
                    productInfo.SubTypeID = subTypeID;
                    productInfo.VarientID = varientID;
                    productInfo.UnitID = unitId;
                    productInfo.Description = desc;
                    productInfo.ProductCode = prodCode;

                    prodPrice.CostPrice = dec_cp;
                    prodPrice.MRP = dec_mrp;
                    prodPrice.SalesPrice = dec_sp;
                    prodPrice.ProductID = productInfo.ProductID;

                    productStock.ProductID = productInfo.ProductID;
                    productStock.Stock = 0;

                    stockChild.StockID = productStock.StockID;
                    stockChild.OpeningBalance = productStock.Stock;
                    stockChild.ClosingBalance = productStock.Stock;
                    stockChild.LastUpdated = System.DateTime.Now;
                    
                    database.ProductInfoes.Add(productInfo);
                    database.ProductPrices.Add(prodPrice);
                    database.ProductStocks.Add(productStock);
                    database.StockChilds.Add(stockChild);

                    database.SaveChanges();
                    result.Result = true;
                    result.Message = " Record Successfully Added !!! ";
                    ClearControls();
                }
                else
                {
                    result.Result = false;
                    result.Message = "Product Already Exist";
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

        private void ClearControls()
        {
            txtDescription.Text = "";
            txtCostPrice.Text = "";
            txtMRP.Text = "";
            txtSalesPrice.Text = "";
            cmbUnit.SelectedIndex = 0;
            lblError.Text = "";

        }

        private void GetProductInfo()
        {
            int catID = Convert.ToInt32(cmbCatagory.SelectedValue);
            int typeID = Convert.ToInt32(cmbProductType.SelectedValue);
            int subTypeID = Convert.ToInt32(cmbSubType.SelectedValue);
            int varientID = Convert.ToInt32(cmbVariety.SelectedValue);
            try
            {
                var database = new InventoryEntities();
                var count = (from c in database.ProductInfoes
                             where c.CatagoryID == catID && c.TypeID == typeID && c.SubTypeID == subTypeID && c.VarientID == varientID
                             select c).FirstOrDefault();
                if (count != null)
                {
                    var pricedetail = (from c in database.ProductPrices
                                       where c.ProductID == count.ProductID
                                       select c).FirstOrDefault();
                    txtDescription.Text = count.Description;
                    txtCostPrice.Text = pricedetail.CostPrice.ToString();
                    txtMRP.Text = pricedetail.MRP.ToString();
                    txtSalesPrice.Text = pricedetail.SalesPrice.ToString();
                    cmbUnit.SelectedValue = count.UnitID;

                }
                else
                {
                    ClearControls();
                }
            }
            catch (Exception ex)
            {

            }

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
                btnTypeAdd.Enabled = true;
                btnTypeAdd.Visible = true;
                lblError.Text = "";
            }
            else
            {
                cmbProductType.Text = "";
                cmbProductType.Enabled = false;
                btnTypeAdd.Enabled = false;
                btnTypeAdd.Visible = false;
                cmbSubType.Text = "";
                cmbSubType.Enabled = false;
                btnSubTypeAdd.Enabled = false;
                btnSubTypeAdd.Visible = false;
                cmbVariety.Text = "";
                cmbVariety.Enabled = false;
                btnVariety.Enabled = false;
                btnVariety.Visible = false;

            }
            
        }
        private void cmbProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProductType.SelectedIndex > 0)
            {
                cmbSubType.Enabled = true;
                BindProductSubType();
                btnSubTypeAdd.Enabled = true;
                btnSubTypeAdd.Visible = true;
                lblError.Text = "";
            }
            else
            {
                cmbSubType.Text = "";
                cmbSubType.Enabled = false;
                btnSubTypeAdd.Enabled = false;
                btnSubTypeAdd.Visible = false;
                cmbVariety.Text = "";
                cmbVariety.Enabled = false;
                btnVariety.Enabled = false;
                btnVariety.Visible = false;

            }

        }
        private void cmbSubType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSubType.SelectedIndex > 0)
            {
                cmbVariety.Enabled = true;
                btnVariety.Enabled = true;
                btnVariety.Visible = true;
                BindProductVariety();
                lblError.Text = "";
            }
            else
            {
                cmbVariety.Text = "";
                cmbVariety.Enabled = false;
                btnVariety.Enabled = false;
                btnVariety.Visible = false;

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            Money moneyCostP,moneyMRP,moneySalesP = new Money();
            double costPrice, MRP, salesPrice;

            moneyCostP = ControlValidation.IsValidPrice(txtCostPrice.Text.Trim());
            moneyMRP = ControlValidation.IsValidPrice(txtMRP.Text.Trim());
            moneySalesP = ControlValidation.IsValidPrice(txtSalesPrice.Text.Trim());
            costPrice = moneyCostP.Price;
            MRP = moneyMRP.Price;
            salesPrice = moneySalesP.Price;
            if(cmbCatagory.SelectedIndex <=0 )
            {
                lblError.Text = "Please select valid catagory";
                lblError.ForeColor = Color.Red;
                cmbCatagory.Focus();
            }
            else if(cmbProductType.SelectedIndex <=0)
            {
                lblError.Text = "Please select valid Item Type";
                lblError.ForeColor = Color.Red;
                cmbProductType.Focus();
            }
            else if(cmbSubType.SelectedIndex <= 0)
            {
                lblError.Text = "Please select valid Item sub-Type";
                lblError.ForeColor = Color.Red;
                cmbSubType.Focus();
            }
            else if(cmbVariety.SelectedIndex<=0)
            {
                lblError.Text = "Please select valid Item Variety";
                lblError.ForeColor = Color.Red;
                cmbVariety.Focus();
            }
            else if (cmbUnit.SelectedIndex<=0)
            {
                lblError.Text = "Please select valid Item Unit";
                lblError.ForeColor = Color.Red;
                cmbUnit.Focus();
            }
            else if(!moneyCostP.Result)
            {
                lblError.Text = "Please Enter valid Dealer Price";
                lblError.ForeColor = Color.Red;
                txtCostPrice.Focus();
            }
            else if(!moneyMRP.Result)
            {
                lblError.Text = "Please Enter valid MRP";
                lblError.ForeColor = Color.Red;
                txtMRP.Focus();
            }
            else if(!moneySalesP.Result)
            {
                lblError.Text = "Please Enter valid Sales Price";
                lblError.ForeColor = Color.Red;
                txtSalesPrice.Focus();
            }
            else
            {
                //MessageBox.Show("Validation Done"+moneySalesP.Price.ToString());
                var result = AddPoductInfo(costPrice, MRP, salesPrice);
                if(result.Result)
                {
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            if(cmbVariety.SelectedIndex >= 0)
            {
                ClearControls();
                cmbVariety.SelectedIndex = 0;
                
            }
            
        }


        

        

        private void cmbVariety_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetProductInfo();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
