using Microsoft.ReportingServices.RdlExpressions.ExpressionHostObjectModel;
using RawForms.AppUtil;
using RawForms.Connection;
using RawForms.Entities;
using RawForms.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RawForms.Pages.Report
{
    public partial class BillHistoryReport : Form
    {
        public BillHistoryReport()
        {
            InitializeComponent();
        }
        InventoryEntities database = new InventoryEntities();
        private void BillHistoryReport_Load(object sender, EventArgs e)
        {
            dataGridViewBillHistory.AutoGenerateColumns = false;
            ControlValidation.DisableGridSort(this.dataGridViewBillHistory, DataGridViewColumnSortMode.NotSortable);
            
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridViewBillHistory.Rows.Clear();
            var txnTypeList = (from c in database.TransactionDetails
                               join d in database.TransactionTypes on c.TranctionTypeID equals d.TransactionTypeID
                               select new
                               {
                                   c.BillNumber,
                                   c.TranctionTypeID,
                                   d.TransactionTypeName
                               }).Distinct(); 
            var billRecordList = (from c in database.BillInfoes
                                  join d in database.BillTypes on c.BillTypeID equals d.BillTypeID
                                  join f in database.CustomerInfoes on c.CustomerID equals f.CustomerID
                                  join g in txnTypeList on c.BillNumber equals g.BillNumber
                                  where c.BillDate >= dateTimePickerStart.Value && c.BillDate <= dateTimePickerEnd.Value
                                  select new
                                  {
                                      c.BillID,
                                      c.BillNumber,
                                      c.BillDate,
                                      c.BillType,
                                      c.BillTypeID,
                                      c.CustomerID,
                                      c.Discount,
                                      c.TotalAmount,
                                      d.BillTypeName,
                                      f.CustomerName,
                                      f.Mobile,
                                      f.CustomerAddress,
                                      g.TranctionTypeID,
                                      g.TransactionTypeName


                                  });
            foreach( var row in billRecordList)
            {
                DateTime? dt;
                dt = row.BillDate;
                string date="XX-XX-XXXX";
                if (dt!=null)
                {
                    date = ((DateTime)dt).ToString("dd/MM/yyyy");
                }
                
                DataGridViewRow grow = new DataGridViewRow();
                grow.CreateCells(dataGridViewBillHistory);
                grow.Cells[0].Value = row.BillID;
                grow.Cells[1].Value = row.BillTypeID;
                grow.Cells[2].Value = row.CustomerID;
                grow.Cells[3].Value = row.TranctionTypeID;
                grow.Cells[4].Value = dataGridViewBillHistory.RowCount + 1;
                grow.Cells[5].Value = row.TransactionTypeName;
                grow.Cells[6].Value = row.BillTypeName;
                grow.Cells[7].Value = row.BillNumber;
                grow.Cells[7].Style.ForeColor = Color.Blue;
                
                grow.Cells[8].Value = row.CustomerName;
                grow.Cells[9].Value = row.Mobile;
                grow.Cells[10].Value = row.CustomerAddress;
                grow.Cells[11].Value = date;
                grow.Cells[12].Value = row.TotalAmount;
                grow.Cells[13].Value = row.Discount;
                grow.Cells[14].Value = "NA"; // paid value will implement with credit bill
                grow.Cells[15].Value = "NA"; //balance value will implement in credit bill
                dataGridViewBillHistory.Rows.Add(grow);
                dataGridViewBillHistory.AllowUserToAddRows = false;
                
                //dataGridViewBillHistory.ScrollBars = ScrollBars.Both;
                //dataGridViewBillHistory.Rows.Add();

            }
            dataGridViewBillHistory.Rows.Add();
        }

        private void dataGridViewBillHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string lclBillNo = "";
            if (e.RowIndex >= 0 && e.RowIndex != dataGridViewBillHistory.RowCount - 1)
            {
                if (e.ColumnIndex == this.BillNumber.Index)
                {
                    
                        lclBillNo = Convert.ToString(dataGridViewBillHistory.Rows[e.RowIndex].Cells["BillNumber"].Value);
                        ReportBuilder(lclBillNo);

                    
                }
            }
                
        }

        public void ReportBuilder(string lclbillNo)
        {
            
            List<CustomerBillProduct> billProdList = new List<CustomerBillProduct>();
            billProdList.Clear();
            var billedItems = (from c in database.TransactionDetails
                               join d in database.ProductInfoes on c.ProductID equals d.ProductID
                               where c.BillNumber == lclbillNo
                               select new
                               {
                                   c.Quantity,
                                   c.UnitPrice,
                                   c.TotalPrice,
                                   d.Description
                               });

            var billingInfo = (from c in database.BillInfoes
                               join d in database.CustomerInfoes on c.CustomerID equals d.CustomerID
                               where c.BillNumber == lclbillNo
                               select new
                               {
                                   c.BillDate,
                                   c.Discount,
                                   c.TotalAmount,
                                   d.CustomerName,
                                   d.CustomerAddress,
                                   d.Mobile,
                                   d.Email,

                               }).FirstOrDefault();

            var shopInfo = (from c in database.ShopInfoes
                            select c).FirstOrDefault();

            string shopAddress = shopInfo.ShopAddress + " " + shopInfo.City + " " + shopInfo.Dist + " " + shopInfo.State + " " + shopInfo.ZIP + " Tel :" + shopInfo.PhoneNo;

            foreach(var row in billedItems)
            {
                var custBillProduct = new CustomerBillProduct
                {
                    Productdesc = Convert.ToString(row.Description),
                    Productprice = Convert.ToDecimal(row.UnitPrice),
                    Productunit = Convert.ToDecimal(row.Quantity),
                    Totalprice = Convert.ToDecimal(row.TotalPrice),
                };
                billProdList.Add(custBillProduct);

            }
            var customerBillData = new CustomerBillData();
            customerBillData.gstn = shopInfo.Gstn;
            customerBillData.shopName = shopInfo.ShopName;
            customerBillData.shopAddress = shopAddress;
            customerBillData.billNo = lclbillNo;
            customerBillData.billData = billProdList;

            
            var custDetails = new CustomerInfoDetails();
            custDetails.custAddress = billingInfo.CustomerAddress;
            custDetails.custName = billingInfo.CustomerName;
            custDetails.custMobile = billingInfo.Mobile;
            custDetails.custEmail = billingInfo.Email;
            custDetails.billDate = (DateTime)billingInfo.BillDate;
            custDetails.custDiscount = Convert.ToDecimal(billingInfo.Discount);
            int printonlyBill = 1;
            var printBill = new CustomerBillForm(printonlyBill);
            printBill.showBill(customerBillData, custDetails);
            printBill.ShowDialog(this);
        }

        private void dataGridViewBillHistory_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void dataGridViewBillHistory_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewBillHistory_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if(e.ColumnIndex>=0)
                {
                    if (dataGridViewBillHistory.Columns[e.ColumnIndex] == dataGridViewBillHistory.Columns["BillNumber"])
                    {
                        dataGridViewBillHistory.Cursor = Cursors.Hand;
                    }
                    else
                    {
                        dataGridViewBillHistory.Cursor = Cursors.Default;
                    }

                }


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridViewBillHistory_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewBillHistory.Cursor = Cursors.Default;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
