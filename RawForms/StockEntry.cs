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

            foreach (var row in recordlist)
            {
                if(dataGridView1.RowCount >0 )
                {
                    //foreach(DataGridViewRow r in dataGridView1.Rows)
                    for(int i =0; i < dataGridView1.RowCount; i++)
                    {
                        int prodID = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                        if(prodID==row.ProductID)
                        {
                            recordresult = true;
                            dataGridView1.Rows[i].Cells[15].Value = txtNewStock.Text.Trim();
                        }

                    }
                    if(recordresult==false)
                    {
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
                        grow.Cells[19].Value = "Delete";
                        dataGridView1.Rows.Add(grow);
                    }
                    
                }
                else
                {
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
                    grow.Cells[19].Value = "Delete";
                    dataGridView1.Rows.Add(grow);
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
                        where c.ProductID==productID
                        select new
                        {
                            c.ProductID,
                            details = g.VarientName + " " + f.SubTypeName + " " + e.TypeName + "   MRP = " + i.MRP,

                        }).FirstOrDefault();
            txtSearch.Text = list.details;
            if(dataGridView1.CurrentRow.Cells["NewStock"].Value == null)
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
                            details = g.VarientName+ " "+ f.SubTypeName+ " " + e.TypeName + "   MRP = "+ i.MRP,
                            
                        });

            //coll.AddRange(list.ToArray());
            foreach (var item in list)
            {
                pidDictionary.Add(item.details, item.ProductID);
                coll.Add(item.details.ToString());
            }
            
            txtSearch.AutoCompleteCustomSource = coll;
            
        }

        private void StockEntry_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            BindUnits();
            
            //PopulateGrid();
            /* for (int i = 0; i < dataGridView1.RowCount; i++)
             {
                 try
                 {
                     int str1 = Convert.ToInt32((dataGridView1.Rows[i].Cells["UnitID"]).Value);
                     int j = 5;


                     (dataGridView1.Rows[i].Cells["cmbUnit"] as DataGridViewComboBoxCell).Value=str1;
                     //(dataGridView1.Rows[i].Cells[6] as DataGridViewComboBoxCell).Value = "real";
                     // dgShuffle.Rows[i].Cells[6].Value = "real";
                 }
                 catch(Exception ex)
                 {

                 }


             }*/

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
            }
            catch(Exception ex)
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
            catch(Exception ex)
            {
                MessageBox.Show("No Record Found"+ex.ToString());
            }
            
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == this.Delete.Index)
                {
                    dataGridView1.Rows.Remove(dataGridView1.Rows[e.RowIndex]);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == this.Delete.Index)
                {
                    dataGridView1.Rows.Remove(dataGridView1.Rows[e.RowIndex]);
                }
            }
        }
    }
}
