using RawForms.AppUtil;
using RawForms.Entities;
using RawForms.Reports;
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
    public partial class CustomerDetails : Form
    {
        CustomerBillData custBillInfoData = new CustomerBillData();
        ProductSale productSale = new ProductSale();
        string _billnumber = "";
        int sellerEntry = 0; // 0 - customer entry, 1 - sellser entry
        public CustomerDetails()
        {
            InitializeComponent();
        }
        public CustomerDetails(ProductSale prodSale)
        {
            productSale = prodSale;
            sellerEntry = 0;
            InitializeComponent();
        }

        public CustomerDetails(int i, string billno, decimal sumTotal, StockEntry stockentry)
        {
            _glStockEntry = stockentry;
            sellerEntry = i;
            _billnumber = billno;
            InitializeComponent();
        }
        StockEntry _glStockEntry = new StockEntry();
        private void CustomerDetails_Load(object sender, EventArgs e)
        {
            lblError.Text = "";
            lblError.ForeColor = Color.Red;
            lblBillNoView.Text = _billnumber;
            dateTimeBillDate.Format = DateTimePickerFormat.Custom;
            dateTimeBillDate.CustomFormat = "dd-MM-yyyy";
            if(sellerEntry==1)
            {
                lblCustomerName.Text = "Seller Name";
            }
        }

        private void lblLoginMessage_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text.Trim() == "" || ControlValidation.IsReserveWord(txtCustomerName.Text.Trim().ToLower()))
            {
                lblError.Text = "Please Enter Customer Name";
                lblError.ForeColor = Color.Red;
            }
            else
            {
                var custDetails = new CustomerInfoDetails();
                if(txtAddress.Text=="" || ControlValidation.IsReserveWord(txtAddress.Text.Trim().ToLower()))
                {
                    custDetails.custAddress = "XXXX";
                }
                else
                {
                    custDetails.custAddress = txtAddress.Text;
                }
                custDetails.custName = txtCustomerName.Text;
                custDetails.custMobile = "9999999999";
                custDetails.custEmail = "abc@gmail.com";
                custDetails.billDate = dateTimeBillDate.Value.Date;
                custDetails.custDiscount = 0;
                this.Hide();
                if (sellerEntry==1)
                {
                    this.Hide();
                    var stockEntry = new StockEntry();
                    stockEntry.CalllbackFromCustDetails(_glStockEntry, custDetails, _billnumber);
                    this.Close();
                }
                else
                {
                    CustomerBillForm cust = new CustomerBillForm(productSale);
                    cust.showBill(custBillInfoData, custDetails);
                    cust.ShowDialog(this);
                    this.Close();
                }
                
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        public void prodBillInfoPass(CustomerBillData custBillData, string billno)
        {
            
            custBillInfoData = custBillData;
            _billnumber = billno;

        }

     
    }
}
