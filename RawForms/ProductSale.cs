using Microsoft.Reporting.WinForms;
using RawForms.AppUtil;
using RawForms.Connection;
using RawForms.Dialog;
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
using static RawForms.Reports.CustomerBillForm;

namespace RawForms
{
    public partial class ProductSale : Form
    {
        public string _globalBillNo = "";
        CustomerBillData customerBillData = new CustomerBillData();
        CustomerInfoDetails customerInfoDetails = new CustomerInfoDetails();
        public ProductSale()
        {
            
            InitializeComponent();
            AutoCompleteText();
        }
        Dictionary<String, Int32> pidDictionary = new Dictionary<String, Int32>();
        

        public void AutoCompleteText()
        {
            txtProductName.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtProductName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            //Dictionary<String, Int32> pidDictionary = new Dictionary<String, Int32>();

            var database = new InventoryEntities();
            //var list = (from c in database.ProductVarients select c.VarientName).ToList();
            var list = (from c in database.ProductInfoes
                        join d in database.ProductCatagories on c.CatagoryID equals d.CatagoryID
                        join e in database.ProductTypes on c.TypeID equals e.TypeID
                        join f in database.ProductSubTypes on c.SubTypeID equals f.SubTypeID
                        join g in database.ProductVarients on c.VarientID equals g.VarientID
                        join h in database.ProductUnits on c.UnitID equals h.UnitID
                        join i in database.ProductPrices on c.ProductID equals i.ProductID
                        join j in database.ProductStocks on c.ProductID equals j.ProductID
                        select new
                        {
                            c.ProductID,
                            details = e.TypeName + " " + f.SubTypeName + " " + g.VarientName + "   MRP = " + i.MRP,

                        });

            //coll.AddRange(list.ToArray());
            foreach (var item in list)
            {
                pidDictionary.Add(item.details, item.ProductID);
                coll.Add(item.details.ToString());
            }

            txtProductName.AutoCompleteCustomSource = coll;

        }

        public void GetProductRecord(int productID)
        {
            bool recordresult = false;
            var database = new InventoryEntities();
            var recordlist = (from c in database.ProductInfoes
                              join d in database.ProductCatagories on c.CatagoryID equals d.CatagoryID
                              join e in database.ProductTypes on c.TypeID equals e.TypeID
                              join f in database.ProductSubTypes on c.SubTypeID equals f.SubTypeID
                              join g in database.ProductVarients on c.VarientID equals g.VarientID
                              join h in database.ProductUnits on c.UnitID equals h.UnitID
                              join i in database.ProductPrices on c.ProductID equals i.ProductID
                              join j in database.ProductStocks on c.ProductID equals j.ProductID
                              where c.ProductID == productID
                              select new
                              {
                                  c.ProductID,
                                  c.CatagoryID,
                                  c.TypeID,
                                  c.SubTypeID,
                                  c.VarientID,
                                  c.UnitID,
                                  c.Description,
                                  d.CatagoryName,
                                  e.TypeName,
                                  f.SubTypeName,
                                  g.VarientName,
                                  h.UnitName,
                                  i.PriceID,
                                  i.CostPrice,
                                  i.MRP,
                                  i.SalesPrice,
                                  j.Stock,
                                  j.StockID
                              });
            decimal _quantity = 0;
            if (txtQuantity.Text.Trim() == "")
            {
                _quantity = 0;
            }
            else
            {
                _quantity = Convert.ToDecimal(txtQuantity.Text.Trim());
            }

            foreach (var row in recordlist)
            {
                if (dataGridViewSale.RowCount > 0)
                {
                    //foreach(DataGridViewRow r in dataGridView1.Rows)
                    for (int i = 0; i < dataGridViewSale.RowCount; i++)
                    {
                        int prodID = Convert.ToInt32(dataGridViewSale.Rows[i].Cells[0].Value);
                        
                        if (prodID == row.ProductID)
                        {
                            decimal _salesP = (decimal)dataGridViewSale.Rows[i].Cells[16].Value;
                            recordresult = true;
                            dataGridViewSale.Rows[i].Cells[13].Value = txtQuantity.Text.Trim();
                            decimal total = _quantity * _salesP;
                            dataGridViewSale.Rows[i].Cells[17].Value = total;
                        }

                    }
                    if (recordresult == false)
                    {
                        decimal total = _quantity * (decimal)row.SalesPrice;
                        DataGridViewRow grow = new DataGridViewRow();
                        grow.CreateCells(dataGridViewSale);
                        grow.Cells[0].Value = row.ProductID;
                        grow.Cells[1].Value = row.CatagoryID;
                        grow.Cells[2].Value = row.TypeID;
                        grow.Cells[3].Value = row.SubTypeID;
                        grow.Cells[4].Value = row.VarientID;
                        grow.Cells[5].Value = row.UnitID;
                        grow.Cells[6].Value = row.PriceID;
                        grow.Cells[7].Value = row.StockID;
                        grow.Cells[8].Value = dataGridViewSale.RowCount; //Serial No is count of the exising row
                        grow.Cells[9].Value = row.TypeName;
                        grow.Cells[10].Value = row.SubTypeName;
                        grow.Cells[11].Value = row.VarientName;
                        grow.Cells[12].Value = row.Description;
                        grow.Cells[13].Value = txtQuantity.Text.Trim();
                        grow.Cells[14].Value = row.UnitName;
                        grow.Cells[15].Value = row.MRP;
                        grow.Cells[16].Value = row.SalesPrice;
                        grow.Cells[17].Value = total;
                        grow.Cells[18].Value = "Delete";
                        dataGridViewSale.Rows.Insert(dataGridViewSale.RowCount - 1, grow);
                        //dataGridView1.Rows.Add(grow);
                    }

                }
                else
                {
                    decimal total = _quantity * (decimal)row.SalesPrice;
                    DataGridViewRow grow = new DataGridViewRow();
                    grow.CreateCells(dataGridViewSale);
                    grow.Cells[0].Value = row.ProductID;
                    grow.Cells[1].Value = row.CatagoryID;
                    grow.Cells[2].Value = row.TypeID;
                    grow.Cells[3].Value = row.SubTypeID;
                    grow.Cells[4].Value = row.VarientID;
                    grow.Cells[5].Value = row.UnitID;
                    grow.Cells[6].Value = row.PriceID;
                    grow.Cells[7].Value = row.StockID;
                    grow.Cells[8].Value = dataGridViewSale.RowCount+1; //Serial No is count of the exising row
                    grow.Cells[9].Value = row.TypeName;
                    grow.Cells[10].Value = row.SubTypeName;
                    grow.Cells[11].Value = row.VarientName;
                    grow.Cells[12].Value = row.Description;
                    grow.Cells[13].Value = txtQuantity.Text.Trim();
                    grow.Cells[14].Value = row.UnitName;
                    grow.Cells[15].Value = row.MRP;
                    grow.Cells[16].Value = row.SalesPrice;
                    grow.Cells[17].Value = total;
                    grow.Cells[18].Value = "Delete";
                    //dataGridViewSale.Rows.Insert(dataGridViewSale.RowCount - 1, grow);
                    dataGridViewSale.Rows.Add(grow);
                    dataGridViewSale.AllowUserToAddRows = false;
                    dataGridViewSale.Rows.Add();
                                                           
                }
            }


            
        }

        public void GetProductByKey(int productID)
        {
            var database = new InventoryEntities();
            var list = (from c in database.ProductInfoes
                        join d in database.ProductCatagories on c.CatagoryID equals d.CatagoryID
                        join e in database.ProductTypes on c.TypeID equals e.TypeID
                        join f in database.ProductSubTypes on c.SubTypeID equals f.SubTypeID
                        join g in database.ProductVarients on c.VarientID equals g.VarientID
                        join h in database.ProductUnits on c.UnitID equals h.UnitID
                        join i in database.ProductPrices on c.ProductID equals i.ProductID
                        join j in database.ProductStocks on c.ProductID equals j.ProductID
                        where c.ProductID == productID
                        select new
                        {
                            c.ProductID,
                            details = e.TypeName + " " + f.SubTypeName + " " + g.VarientName + "   MRP = " + i.MRP,

                        }).FirstOrDefault();
            txtProductName.Text = list.details;
            if (dataGridViewSale.CurrentRow.Cells["Quantity"].Value == null)
            {
                txtQuantity.Text = "";
            }
            else
            {
                txtQuantity.Text = Convert.ToString(dataGridViewSale.CurrentRow.Cells["Quantity"].Value);

            }

        }

        public void SalesTotalCalculation()
        {
            if (dataGridViewSale.RowCount > 1)
            {
                decimal _salesgrandTotal = 0;
                int i;
                for (i = 0; i <= dataGridViewSale.RowCount - 2; i++)
                {

                    _salesgrandTotal += Convert.ToDecimal(dataGridViewSale.Rows[i].Cells[17].Value);

                }
                dataGridViewSale.Rows[i].Cells[17].Value = _salesgrandTotal.ToString();
                dataGridViewSale.Rows[i].Cells[16].Value = "Grand Total";
            }

        }

        public decimal GetCurrentStock(int productID)
        {
            decimal _currStock = 0;
            var database = new InventoryEntities();            
            var stocklist = (from c in database.ProductStocks
                        where c.ProductID == productID
                        select new
                        {
                            c.ProductID,
                            c.Stock,

                        }).FirstOrDefault();

            _currStock = Convert.ToDecimal(stocklist.Stock);
            return _currStock;
        }


        public void GridRowArrange()
        {
            for(int i =0; i < dataGridViewSale.RowCount-1; i++)
            { 
                //Arrange the serial Numbers of all rows
                dataGridViewSale.Rows[i].Cells[8].Value = i + 1;
            }
        }

        private void ProductSale_Load(object sender, EventArgs e)
        {
            dataGridViewSale.AutoGenerateColumns = false;
           ControlValidation.DisableGridSort(this.dataGridViewSale, DataGridViewColumnSortMode.NotSortable);
            
        }

        private void timerSales_Tick(object sender, EventArgs e)
        {
            lblDate.Text = System.DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(dataGridViewSale.RowCount>1)
            {
                if ((MessageBox.Show("Are you Sure to Clear All Row ???", "Clear All Data", MessageBoxButtons.YesNo) == DialogResult.Yes))
                {
                    dataGridViewSale.Rows.Clear();
                    dataGridViewSale.Refresh();
                }

            }
            else
            {
                MessageBox.Show("No Record(s) to Clear!!!");
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            
            try
            {
                int productID;
                if(Convert.ToDecimal(txtCurrentStock.Text.ToString())>= Convert.ToDecimal(txtQuantity.Text.ToString()))
                {
                    productID = pidDictionary[txtProductName.Text.Trim()];
                    GetProductRecord(productID);
                    SalesTotalCalculation();
                    txtProductName.Text = "";
                    txtQuantity.Text = "";
                    txtCurrentStock.Text = "";
                    txtProductName.Focus();
                }
                else
                {
                    MessageBox.Show("Not Enough Stock Plase Check");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridViewSale_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex != dataGridViewSale.RowCount - 1)
            {
                if (e.ColumnIndex == this.Delete.Index)
                {
                    if ((MessageBox.Show("Are you Sure to Delete Row ???", "Delete Row", MessageBoxButtons.YesNo) == DialogResult.Yes))
                    {
                        if(dataGridViewSale.RowCount==2)
                        {
                            dataGridViewSale.Rows.Remove(dataGridViewSale.Rows[0]);
                            dataGridViewSale.Rows.Remove(dataGridViewSale.Rows[0]);
                        }
                        else
                        {
                            dataGridViewSale.Rows.Remove(dataGridViewSale.Rows[e.RowIndex]);
                            GridRowArrange();
                        }
                        
                    }

                }
            }
        }

        private void dataGridViewSale_DoubleClick(object sender, EventArgs e)
        {
            try
            {

                if (dataGridViewSale.CurrentRow.Index != -1)
                {
                    int productID = Convert.ToInt32(dataGridViewSale.CurrentRow.Cells["ProductID"].Value);
                    GetProductByKey(productID);
                    txtCurrentStock.Text = GetCurrentStock(productID).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Record Found" + ex.ToString());
            }
        }

        private void dataGridViewSale_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            // Decimal Validation for the gridview cell Quantity
            bool result = false;
            for (int i = 0; i < dataGridViewSale.ColumnCount; i++)
            {
                //if (dataGridViewSale.Columns[i].HeaderText == "Quantity")
                if (dataGridViewSale.CurrentCell.ColumnIndex == 13 )
                {

                    result = true;
                    break;
                }
            }


            if (result)
            {
                DataGridViewTextBoxEditingControl tb = (DataGridViewTextBoxEditingControl)e.Control;
                tb.KeyPress += new KeyPressEventHandler(ControlValidation.IsPrice);

                e.Control.KeyPress += new KeyPressEventHandler(ControlValidation.IsPrice);
            }
        }

        private void dataGridViewSale_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewSale.RowCount > 0)
            {
                if (e.ColumnIndex == 13)//Column index 13 in no of Quantity & if this Changed
                {
                    //Total = Sales Price * Quantity
                    dataGridViewSale.CurrentRow.Cells[17].Value = Convert.ToDecimal(dataGridViewSale.CurrentRow.Cells[13].Value) * Convert.ToDecimal(dataGridViewSale.CurrentRow.Cells[16].Value);
                }
                // To Calculate Grand Total Value of sales Product
                SalesTotalCalculation();
            }
        }

        private void txtProductName_Leave(object sender, EventArgs e)
        {
            if(txtProductName.Text.Trim()!="")
            {
                int productID = pidDictionary[txtProductName.Text.Trim()];
                decimal _currStock = GetCurrentStock(productID);
                txtCurrentStock.Text = _currStock.ToString();
            }
            

            
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(dataGridViewSale.RowCount>1)
            {
                ProductTempSale();
                SendProductinfForBill();
            }
            else
            {
                MessageBox.Show("No Record(s) to Proceed Further!!!");
            }
            
            //var tb = new testRunner();
            //tb.ShowDialog(this);  
            
        }







        public void ProductTempSale()
        {
            _globalBillNo = GetBillNumber();
            for (int i = 0; i < dataGridViewSale.RowCount - 1; i++)
            {
                int _prodID = Convert.ToInt32(dataGridViewSale.Rows[i].Cells[0].Value);
                string _prodDescription = Convert.ToString(dataGridViewSale.Rows[i].Cells["Description"].Value);
                decimal _saleQty, _unitPrice, _totalPrice;
                var database = new InventoryEntities();
                var txnTypelist = (from c in database.TransactionTypes
                                   where c.TransactionTypeName == "Sell"
                                   select new
                                   {
                                       c.TransactionTypeID
                                   }).FirstOrDefault();
                int _txnType = txnTypelist.TransactionTypeID;
                _saleQty = Convert.ToDecimal(dataGridViewSale.Rows[i].Cells["Quantity"].Value);
                _unitPrice = Convert.ToDecimal(dataGridViewSale.Rows[i].Cells["SalesPrice"].Value);
                _totalPrice = _unitPrice * _saleQty;
                var tempBill = new TempBill();
                tempBill.BillNumber = _globalBillNo;
                tempBill.ProductID = _prodID;
                tempBill.ProductDesc = _prodDescription;
                tempBill.Quantity = _saleQty;
                tempBill.UnitPrice = _unitPrice;
                tempBill.TotalPrice = _totalPrice;
                database.TempBills.Add(tempBill);
                database.SaveChanges();
            }

        }

        public void SendProductinfForBill()
        {
            List<CustomerBillProduct> billProdList = new List<CustomerBillProduct>();
            billProdList.Clear();

            //CustomerBillForm cust = new CustomerBillForm();
            CustomerDetails custinfo = new CustomerDetails();

            for (int i = 0; i <= dataGridViewSale.RowCount - 2; i++) //count-2 because one header and one grand total at last row
            {

                var custBillProduct = new CustomerBillProduct
                {
                    Productdesc = Convert.ToString(dataGridViewSale.Rows[i].Cells["Description"].Value),
                    Productprice = Convert.ToDecimal(dataGridViewSale.Rows[i].Cells["SalesPrice"].Value),
                    Productunit = Convert.ToDecimal(dataGridViewSale.Rows[i].Cells["Quantity"].Value),
                    Totalprice = Convert.ToDecimal(dataGridViewSale.Rows[i].Cells["Total"].Value)
                };
                billProdList.Add(custBillProduct);

            }

            var customerBillData = new CustomerBillData();
            customerBillData.gstn = "GST043621987PS";
            customerBillData.billNo = _globalBillNo;
            customerBillData.billData = billProdList;
            custinfo.prodBillInfoPass(customerBillData, _globalBillNo);
            custinfo.ShowDialog(this);
            
        }


        public void ProductFinalSale(string localbillNo)
        {
            decimal _stock, _ob, _cb, _sellQty, _unitPrice, _totalPrice, _sumTotal = 0;
            int _prodID;
            int _stockID;

            var database = new InventoryEntities();
            var productIds = (from c in database.TempBills
                              join d in database.ProductStocks on c.ProductID equals d.ProductID
                              join e in database.StockChilds on d.StockID equals e.StockID
                              where c.BillNumber == localbillNo
                              select new
                              {
                                  c.ProductID,
                                  c.Quantity,
                                  c.UnitPrice,
                                  d.StockID

                              }); ;
            int _noofProd = productIds.Count();


            //for (int i = 0; i < _noofProd ; i++)
            foreach(var prodId in productIds.ToList())
            {
                 _prodID = Convert.ToInt32(prodId.ProductID.ToString());
                 _stockID = Convert.ToInt32(prodId.StockID.ToString());
                
                
                var list = (from c in database.ProductStocks
                            join d in database.StockChilds on c.StockID equals d.StockID
                            where c.ProductID == _prodID
                            select new
                            {
                                c.Stock,
                                d.OpeningBalance,
                                d.ClosingBalance,
                            }).FirstOrDefault();

                var txnTypelist = (from c in database.TransactionTypes
                                   where c.TransactionTypeName == "Sell"
                                   select new
                                   {
                                       c.TransactionTypeID
                                   }).FirstOrDefault();

                int _txnType = txnTypelist.TransactionTypeID;

                _stock = Convert.ToDecimal(list.Stock);
                _sellQty = Convert.ToDecimal(prodId.Quantity.ToString());
                _unitPrice = Convert.ToDecimal(prodId.UnitPrice.ToString());
                _totalPrice = _unitPrice * _sellQty;
                _sumTotal += _totalPrice;
                _ob = _stock;
                _cb = _stock - _sellQty;

                var txnDetail = new TransactionDetail();

                txnDetail.ProductID = _prodID;
                txnDetail.TranctionTypeID = _txnType;
                txnDetail.Quantity = _sellQty;
                txnDetail.UnitPrice = _unitPrice;
                txnDetail.TotalPrice = _totalPrice;
                txnDetail.OpeningBalance = _ob;
                txnDetail.ClosingBalance = _cb;
                txnDetail.UpdatedOn = System.DateTime.Now;
                txnDetail.BillNumber = localbillNo;

                database.TransactionDetails.Add(txnDetail);

                var stocklist = (from c in database.ProductStocks
                                 where c.StockID == _stockID
                                 select c).FirstOrDefault();

                stocklist.Stock = _cb;

                var stockchildlist = (from c in database.StockChilds
                                      where c.StockID == _stockID
                                      select c).FirstOrDefault();
                stockchildlist.OpeningBalance = _cb;
                stockchildlist.ClosingBalance = _cb;

                database.SaveChanges();

               
            }
            TempBillClear(localbillNo);
            CustomerEntry(localbillNo, _sumTotal, customerBillData, customerInfoDetails);

        }

        public string GetBillNumber()
        {
            StringBuilder sb = new StringBuilder();
            string billString = "SLS";
            DateTime todaysDate = DateTime.Now.Date;
            string day = DateTime.Now.ToString("dd");
            string month = DateTime.Now.ToString("MM");
            string year = DateTime.Now.ToString("yyyy");
            int latestBill = 0;
            var database = new InventoryEntities();
            var txnTypelist = (from c in database.TransactionTypes
                               where c.TransactionTypeName == "Sell"
                               select new
                               {
                                   c.TransactionTypeID
                               }).FirstOrDefault();
            int txnType = txnTypelist.TransactionTypeID;
            var billcount = (from c in database.TransactionDetails
                             where c.TranctionTypeID == txnType
                             select new
                             {
                                 c.BillNumber

                             }).Distinct() ;
            latestBill = billcount.Count() + 1;
            string strLatestBill = String.Format("{0:D6}", latestBill);
            sb.Append(billString);
            sb.Append(year);
            sb.Append(month);
            sb.Append(day);
            sb.Append(strLatestBill);
            billString = sb.ToString();

            return billString;
        }

        public void TempBillClear(string _billNo)
        {
            var database = new InventoryEntities();
            var tempProdRecords = (from c in database.TempBills
                                   where c.BillNumber == _billNo
                                   select c);
            database.TempBills.RemoveRange(tempProdRecords);
            database.SaveChanges();
            

        }
        public void CallBackFromReport(string billno, CustomerBillData cusBill, CustomerInfoDetails custInfo)
        {
            MessageBox.Show("Please enter First Name!" + billno);
            customerBillData = cusBill;
            customerInfoDetails = custInfo;
 
            ProductFinalSale(billno);
        }

        public void CustomerEntry(string billNo, decimal sumTotal, CustomerBillData cusBill, CustomerInfoDetails custInfo)
        {
            var database = new InventoryEntities();
            var billTypeIDList = (from c in database.BillTypes
                                  where c.BillTypeName == "Cash"
                                  select new
                                  {
                                      c.BillTypeID

                                  }).FirstOrDefault();

            var custInfoTable = new CustomerInfo();
            var billInfoTable = new BillInfo();
            custInfoTable.CustomerName = custInfo.custName;
            custInfoTable.CustomerAddress = custInfo.custAddress;
            custInfoTable.Mobile = custInfo.custMobile;
            custInfoTable.Email = custInfo.custEmail;
            database.CustomerInfoes.Add(custInfoTable);


            billInfoTable.BillNumber = billNo;
            billInfoTable.BillTypeID = billTypeIDList.BillTypeID;//Cash or Credit Bill
            billInfoTable.TotalAmount = sumTotal;
            billInfoTable.Discount = custInfo.custDiscount;
            billInfoTable.BillDate = DateTime.Now.Date;
            billInfoTable.UpdatedOn = DateTime.Now;
            billInfoTable.CustomerInfo = custInfoTable;
            //database.CustomerInfoes.Add(custInfoTable);
            database.BillInfoes.Add(billInfoTable);
            database.SaveChanges();

        }
    }
}
