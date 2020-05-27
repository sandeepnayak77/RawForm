using Microsoft.ReportingServices.RdlExpressions.ExpressionHostObjectModel;
using RawForms.AppUtil;
using RawForms.Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            panel2.Hide();
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
        }

      
    }
}
