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

namespace RawForms
{
    public partial class StockEntry : Form
    {
        public StockEntry()
        {
            InitializeComponent();
            AutoCompleteText();
        }

        Dictionary<String, Int32> pidDictionary = new Dictionary<String, Int32>();
        Bitmap bmp;

        public void BindUnits()
        {
            var database = new InventoryEntities();
            var units = (from c in database.ProductUnits select c).ToList();
            //units.Insert(0, new ProductUnit { UnitID = 0, UnitName = "--Select Units--" });
            cmbUnit.DisplayMember = "UnitName";
            cmbUnit.ValueMember = "UnitID";
            cmbUnit.DataSource = units;
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
            decimal _stock = 0;
            if (txtNewStock.Text.Trim() == "")
            {
                _stock = 0;
            }
            else
            {
                _stock = Convert.ToDecimal(txtNewStock.Text.Trim());
            }

            foreach (var row in recordlist)
            {
                if (dataGridView1.RowCount > 0)
                {
                    //foreach(DataGridViewRow r in dataGridView1.Rows)
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        int prodID = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                        
                        if (prodID == row.ProductID)
                        {
                            decimal _costP = (decimal)dataGridView1.Rows[i].Cells[16].Value;
                            recordresult = true;
                            dataGridView1.Rows[i].Cells[15].Value = txtNewStock.Text.Trim();
                            decimal total = _stock * _costP;
                            dataGridView1.Rows[i].Cells[19].Value = total;
                        }

                    }
                    if (recordresult == false)
                    {
                        decimal total = _stock * (decimal)row.CostPrice;
                        DataGridViewRow grow = new DataGridViewRow();
                        grow.CreateCells(dataGridView1);
                        grow.Cells[0].Value = row.ProductID;
                        grow.Cells[1].Value = row.CatagoryID;
                        grow.Cells[2].Value = row.TypeID;
                        grow.Cells[3].Value = row.SubTypeID;
                        grow.Cells[4].Value = row.VarientID;
                        grow.Cells[5].Value = row.UnitID;
                        grow.Cells[6].Value = row.UnitName;
                        grow.Cells[7].Value = row.PriceID;
                        grow.Cells[8].Value = row.StockID;
                        grow.Cells[9].Value = row.TypeName;
                        grow.Cells[10].Value = row.SubTypeName;
                        grow.Cells[11].Value = row.VarientName;
                        grow.Cells[12].Value = row.Description;
                        grow.Cells[13].Value = row.UnitID;
                        grow.Cells[14].Value = row.Stock;
                        grow.Cells[15].Value = txtNewStock.Text.Trim();
                        grow.Cells[16].Value = row.CostPrice;
                        grow.Cells[17].Value = row.MRP;
                        grow.Cells[18].Value = row.SalesPrice;
                        grow.Cells[19].Value = total;
                        grow.Cells[20].Value = "Delete";
                        dataGridView1.Rows.Insert(dataGridView1.RowCount - 1, grow);
                        //dataGridView1.Rows.Add(grow);
                    }

                }
                else
                {

                    decimal total = _stock * (decimal)row.CostPrice;
                    DataGridViewRow grow = new DataGridViewRow();
                    grow.CreateCells(dataGridView1);
                    grow.Cells[0].Value = row.ProductID;
                    grow.Cells[1].Value = row.CatagoryID;
                    grow.Cells[2].Value = row.TypeID;
                    grow.Cells[3].Value = row.SubTypeID;
                    grow.Cells[4].Value = row.VarientID;
                    grow.Cells[5].Value = row.UnitID;
                    grow.Cells[6].Value = row.UnitName;
                    grow.Cells[7].Value = row.PriceID;
                    grow.Cells[8].Value = row.StockID;
                    grow.Cells[9].Value = row.TypeName;
                    grow.Cells[10].Value = row.SubTypeName;
                    grow.Cells[11].Value = row.VarientName;
                    grow.Cells[12].Value = row.Description;
                    grow.Cells[13].Value = row.UnitID;
                    grow.Cells[14].Value = row.Stock;
                    grow.Cells[15].Value = txtNewStock.Text.Trim();
                    grow.Cells[16].Value = row.CostPrice;
                    grow.Cells[17].Value = row.MRP;
                    grow.Cells[18].Value = row.SalesPrice;
                    grow.Cells[19].Value = total;
                    grow.Cells[20].Value = "Delete";
                    dataGridView1.Rows.Add(grow);
                    dataGridView1.AllowUserToAddRows = false;
                    dataGridView1.Rows.Add();
                    
                }
            }


            //dataGridView1.DataSource = recordlist;
            //DataTable dt = new DataTable();
            //DataView dv = (DataView)dataGridView1.DataSource;
            //dt = dv.Table.DataSet.Tables[0];




            //dataGridView1.Rows.Add(recordlist);
            //dataGridView1.data
        }

        public void PopulateGrid()
        {
            var database = new InventoryEntities();
            var gridData = (from c in database.ProductInfoes
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
                            }).ToList();
            dataGridView1.DataSource = gridData;
            dataGridView1.AutoGenerateColumns = false;



        }

        public void GetProductKey(int productID)
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
            txtSearch.Text = list.details;
            if (dataGridView1.CurrentRow.Cells["NewStock"].Value == null)
            {
                txtNewStock.Text = "";
            }
            else
            {
                txtNewStock.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["NewStock"].Value);

            }

        }

        public void AutoCompleteText()
        {
            txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
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

            txtSearch.AutoCompleteCustomSource = coll;

        }

        public void StockUpdae()
        {
            for (int i = 0; i < dataGridView1.RowCount-1; i++)
            {
                int _prodID = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                int _stockID = Convert.ToInt32(dataGridView1.Rows[i].Cells["StockID"].Value);
                decimal _stock, _ob, _cb, _buyQty, _unitPrice, _totalPrice;
                var database = new InventoryEntities();
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
                                   where c.TransactionTypeName == "Buy"
                                   select new
                                   {
                                       c.TransactionTypeID
                                   }).FirstOrDefault();

                int _txnType = txnTypelist.TransactionTypeID;

                _stock = Convert.ToDecimal(list.Stock);
                _buyQty = Convert.ToDecimal(dataGridView1.Rows[i].Cells["NewStock"].Value);
                _unitPrice = Convert.ToDecimal(dataGridView1.Rows[i].Cells["CostPrice"].Value);
                _totalPrice = _unitPrice * _buyQty;

                _ob = _stock;
                _cb = _stock + _buyQty;

                var txnDetail = new TransactionDetail();

                txnDetail.ProductID = _prodID;
                txnDetail.TranctionTypeID = _txnType;
                txnDetail.Quantity = _buyQty;
                txnDetail.UnitPrice = _unitPrice;
                txnDetail.TotalPrice = _totalPrice;
                txnDetail.OpeningBalance = _ob;
                txnDetail.ClosingBalance = _cb;
                txnDetail.UpdatedOn = System.DateTime.Now;
                txnDetail.BillNumber = "XXXXX";

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

        }


        public void GrandTotalCalculation()
        {
            if(dataGridView1.RowCount>1)
            {
                decimal _grandTotal = 0;
                int i;
                for (i = 0; i <= dataGridView1.RowCount - 2; i++)
                {

                    _grandTotal += Convert.ToDecimal(dataGridView1.Rows[i].Cells[19].Value);

                }
                dataGridView1.Rows[i].Cells[19].Value = _grandTotal.ToString();
                dataGridView1.Rows[i].Cells[18].Value = "Grand Total";
            }
            
        }

        public void PrintPreview()
        {
            
            int height = dataGridView1.Height;
            dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
            bmp = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(bmp,new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            dataGridView1.Height = height;
            printPreviewDialogStockEntry.ShowDialog();
        }



        private void StockEntry_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            BindUnits();
            ControlValidation.DisableGridSort(this.dataGridView1, DataGridViewColumnSortMode.NotSortable);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                int productID;
                productID = pidDictionary[txtSearch.Text.Trim()];
                GetProductRecord(productID);
                txtSearch.Text = "";
                txtNewStock.Text = "";
                txtSearch.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }



        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {

                if (dataGridView1.CurrentRow.Index != -1)
                {
                    int productID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ProductID"].Value);
                    GetProductKey(productID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Record Found" + ex.ToString());
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex != dataGridView1.RowCount-1)
            {
                if (e.ColumnIndex == this.Delete.Index)
                {
                    if ((MessageBox.Show("Are you Sure to Delete Row ???", "Delete Row", MessageBoxButtons.YesNo) == DialogResult.Yes))
                    {
                        dataGridView1.Rows.Remove(dataGridView1.Rows[e.RowIndex]);
                    }

                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /* if (e.RowIndex >= 0)
             {
                 if (e.ColumnIndex == this.Delete.Index)
                 {
                     dataGridView1.Rows.Remove(dataGridView1.Rows[e.RowIndex]);

                 }
             }*/
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            if ((MessageBox.Show("Are you Sure to Clear All Row ???", "Clear All Data", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StockUpdae();
            //dataGridView1.Dispose();
            dataGridView1.Rows.Clear();
            //PrintPreview();
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

            // Decimal Validation for the gridview cell newstock costPrice MRP and Sales Price
            bool result = false;
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                //if (dataGridView1.Columns[i].Name == "NewStock" || dataGridView1.Columns[i].Name == "CostPrice" || dataGridView1.Columns[i].Name == "MRP" || dataGridView1.Columns[i].Name == " SalesPrice")
                if (dataGridView1.CurrentCell.ColumnIndex == 15 || dataGridView1.CurrentCell.ColumnIndex == 16 || dataGridView1.CurrentCell.ColumnIndex == 17 || dataGridView1.CurrentCell.ColumnIndex == 18)
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

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                if (e.ColumnIndex == 15 || e.ColumnIndex == 16)
                {
                    dataGridView1.CurrentRow.Cells[19].Value = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[15].Value) * Convert.ToDecimal(dataGridView1.CurrentRow.Cells[16].Value);
                }
                GrandTotalCalculation();
            }

        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            GrandTotalCalculation();
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            GrandTotalCalculation();
        }

        private void printDocumentStockEntry_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp,0,0);
        }
    }
}
