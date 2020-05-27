using Microsoft.Reporting.WinForms;
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

namespace RawForms.Reports
{
    public partial class CustomerBillForm : Form
    {
        ReportDataSource rs = new ReportDataSource();
        CustomerBillData customerBillData = new CustomerBillData();
        CustomerInfoDetails customerInfoDetails = new CustomerInfoDetails();
        ReportParameterCollection rp = new ReportParameterCollection();
        ProductSale productSale = new ProductSale();
        string _billNo = string.Empty;
        int _printType = 0; //0 - Sales Bill ; 1 - Only Printing of existing bill
        
        public CustomerBillForm()
        {
            InitializeComponent();
        }
        public CustomerBillForm(int printonly)
        {
            _printType = printonly;
            InitializeComponent();
        }
        public CustomerBillForm(ProductSale prodSale)
        {
            productSale = prodSale;
            InitializeComponent();
        }

        private void CustomerBillForm_Load(object sender, EventArgs e)
        {
            /*CustomerBillForm cust = new CustomerBillForm();
            cust.reportViewerCustBill.LocalReport.DataSources.Clear();
            cust.reportViewerCustBill.LocalReport.DataSources.Add(rs);*/
            // this.reportViewerCustBill.LocalReport.ReportPath = "CustomerBill.rdlc";
            this.reportViewerCustBill.RefreshReport();
          //  this.reportViewerCustBill.LocalReport.ReportPath = "~/Reports/CustomerBill.rdlc";
        }

        private void reportViewerCustBill_Load(object sender, EventArgs e)
        {
            //ReportDataSource rs = new ReportDataSource();
            //
            //Disable all other feature for print only Bill as text print button will print the bill only
            if(_printType == 1)
            {
                btnSave.Text = "Print";
                btnExit.Text = "Close";
                btnEdit.Hide();
            }

        }


        public void showBill(CustomerBillData cusBill, CustomerInfoDetails custInfo)
        {
            customerBillData = cusBill;
            customerInfoDetails = custInfo;
            rs.Name = "DataSetCustBillProd";
            rs.Value = cusBill.billData;
            _billNo = cusBill.billNo;

            this.reportViewerCustBill.LocalReport.DataSources.Clear();
            this.reportViewerCustBill.LocalReport.DataSources.Add(rs);
            this.reportViewerCustBill.LocalReport.ReportEmbeddedResource = "RawForms.Reports.CustomerBill.rdlc";            
            
            rp.Add(new ReportParameter("gstNumber", cusBill.gstn));
            rp.Add(new ReportParameter("custName", custInfo.custName));
            rp.Add(new ReportParameter("custAddress", custInfo.custAddress));
            rp.Add(new ReportParameter("billDate", custInfo.billDate.ToString("dd-MM-yyyy")));
            rp.Add(new ReportParameter("billNumber", cusBill.billNo));
            rp.Add(new ReportParameter("shopName", cusBill.shopName));
            rp.Add(new ReportParameter("shopAddress", cusBill.shopAddress));
            this.reportViewerCustBill.LocalReport.SetParameters(rp);
            this.reportViewerCustBill.RefreshReport();
        }
     

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(btnSave.Text=="Save")
            {
                if ((MessageBox.Show("Are you Sure to Proceed ???", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes))
                {
                    btnSave.Text = "Print";
                    btnExit.Text = "Close";
                    btnEdit.Hide();
                    var ps = new ProductSale();
                    ps.CallBackFromReport(_billNo, customerBillData, customerInfoDetails, productSale);
                }
            }
            else
            {
                if (btnSave.Text == "Print")
                {
                    this.reportViewerCustBill.PrintDialog();
                }
            }
                
            
            
            //this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(btnExit.Text=="Exit")
            {
                var ps = new ProductSale();
                ps.CallBackFromReportExit(_billNo, productSale);
                this.Close();
            }
            else
            {
                if (btnExit.Text == "Close")
                {
                    if ((MessageBox.Show("Do you Want to Close ???", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes))
                        this.Close();
                }
            }
                
            
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
                var ps = new ProductSale();
                ps.CallBackFromReportEdit(_billNo, productSale);
                this.Close();
          
        }
    }
}
