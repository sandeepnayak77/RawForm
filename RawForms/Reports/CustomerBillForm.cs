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
        
        public CustomerBillForm()
        {
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

        }


        public void showBill(CustomerBillData cusBill)
        {
            
            rs.Name = "DataSetCustBillProd";
            rs.Value = cusBill.billData;
            this.reportViewerCustBill.LocalReport.DataSources.Clear();
            this.reportViewerCustBill.LocalReport.DataSources.Add(rs);
            this.reportViewerCustBill.LocalReport.ReportEmbeddedResource = "RawForms.Reports.CustomerBill.rdlc";
            
            ReportParameterCollection rp = new ReportParameterCollection();
            rp.Add(new ReportParameter("gstNumber", cusBill.gstn));
            this.reportViewerCustBill.LocalReport.SetParameters(rp);




            this.reportViewerCustBill.RefreshReport();






        }
     

        private void btnSave_Click(object sender, EventArgs e)
        {
            var ps = new ProductSale();
            ps.CallBackFromReport(1);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
