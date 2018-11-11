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
    public partial class ProductSale : Form
    {
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
            if ((MessageBox.Show("Are you Sure to Clear All Row ???", "Clear All Data", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                dataGridViewSale.Rows.Clear();
                dataGridViewSale.Refresh();
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
                productID = pidDictionary[txtProductName.Text.Trim()];
                GetProductRecord(productID);
                SalesTotalCalculation();
                txtProductName.Text = "";
                txtQuantity.Text = "";
                txtCurrentStock.Text = "";
                txtProductName.Focus();
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
                        dataGridViewSale.Rows.Remove(dataGridViewSale.Rows[e.RowIndex]);
                        GridRowArrange();
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
                if (e.ColumnIndex == 13)//if Quantity Changed
                {
                    //Total = Sales Price * Quantity
                    dataGridViewSale.CurrentRow.Cells[17].Value = Convert.ToDecimal(dataGridViewSale.CurrentRow.Cells[13].Value) * Convert.ToDecimal(dataGridViewSale.CurrentRow.Cells[16].Value);
                }
                SalesTotalCalculation();
            }
        }

        private void txtProductName_Leave(object sender, EventArgs e)
        {
            int productID = pidDictionary[txtProductName.Text.Trim()];

            decimal _currStock = GetCurrentStock(productID);
            txtCurrentStock.Text = _currStock.ToString();
        }
    }
}
