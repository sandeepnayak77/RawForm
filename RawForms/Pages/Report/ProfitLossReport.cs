using RawForms.AppUtil;
using RawForms.Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RawForms.Pages.Report
{
    public partial class ProfitLossReport : Form
    {
        public ProfitLossReport()
        {
            InitializeComponent();
        }
        private void ProfitLossReport_Load(object sender, EventArgs e)
        {
            //this.FormBorderStyle = FormBorderStyle.None;
            dataGridViewProfitLoss.AutoGenerateColumns = false;
            ControlValidation.DisableGridSort(this.dataGridViewProfitLoss, DataGridViewColumnSortMode.NotSortable);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridViewProfitLoss.Rows.Clear();
            CalculatePL_BindGrid();
        }
        public void CalculatePL_BindGrid()
        {
            DateTime startDate = dateTimePickerStart.Value, endDate = dateTimePickerEnd.Value;
            decimal old_buy_qty = 0, old_buy_price = 0, old_sold_qty = 0, new_buy_qty = 0, new_buy_price = 0,
                new_sell_qty = 0, new_sell_price = 0, new_stock = 0, old_stock = 0, old_cp = 0, new_cp = 0, final_cp = 0,
                final_sp = 0, profit_loss_per_pc = 0, total_profit_loss = 0, sum_profit_loss = 0, final_profit_loss = 0, sum_discount = 0,
                sum_sell_price = 0, net_cash = 0, sum_new_total_buy = 0;
            string product_description = "";


            var database = new InventoryEntities();
            Font boldfont = new Font("Verdana", 8.25F, FontStyle.Bold);

            var distinctProductID = (from c in database.TransactionDetails
                                     join d in database.BillInfoes on c.BillNumber equals d.BillNumber
                                     where d.BillDate >= startDate && d.BillDate <= endDate
                                     select new
                                     {
                                         c.ProductID
                                     }).Distinct();


            var txn_sell_BillID = (from c in database.TransactionDetails
                                   join d in database.TransactionTypes on c.TranctionTypeID equals d.TransactionTypeID
                                   where d.TransactionTypeName == "Sell"
                                   select new
                                   {

                                       c.BillNumber

                                   }).Distinct();
            var discount = (from c in database.BillInfoes
                            join d in txn_sell_BillID on c.BillNumber equals d.BillNumber
                            where c.BillDate >= startDate && c.BillDate <= endDate
                            group c by 1 into m
                            select new
                            {
                                sumDiscount = m.Sum(x => x.Discount)
                            }).SingleOrDefault();



            if (discount != null)
            {
                sum_discount = Convert.ToDecimal(discount.sumDiscount);
            }
            else
            {
                sum_discount = 0;
            }

            foreach (var i in distinctProductID)
            {
                var prod_Desc = (from c in database.ProductInfoes
                                 where c.ProductID == i.ProductID
                                 select new
                                 {
                                     c.Description

                                 }).SingleOrDefault();

                if (product_description != null)
                {
                    product_description = prod_Desc.Description;
                }

                var oldProdCP = (from c in database.TransactionDetails
                                 join d in database.BillInfoes on c.BillNumber equals d.BillNumber
                                 join f in database.TransactionTypes on c.TranctionTypeID equals f.TransactionTypeID
                                 where d.BillDate < startDate
                                 where c.ProductID == i.ProductID
                                 where f.TransactionTypeName == "Buy"
                                 group c by 1 into m
                                 select new
                                 {
                                     totalbuyQty = m.Sum(x => x.Quantity),
                                     totalBuyValue = m.Sum(x => x.TotalPrice)
                                 }).SingleOrDefault();

                var oldProdSold = (from c in database.TransactionDetails
                                   join d in database.BillInfoes on c.BillNumber equals d.BillNumber
                                   join f in database.TransactionTypes on c.TranctionTypeID equals f.TransactionTypeID
                                   where d.BillDate < startDate
                                   where c.ProductID == i.ProductID
                                   where f.TransactionTypeName == "Sell"
                                   group c by 1 into m
                                   select new
                                   {
                                       totalsaleQty = m.Sum(x => x.Quantity),
                                       totalSaleValue = m.Sum(x => x.TotalPrice)
                                   }).SingleOrDefault();


                var newProdCP = (from c in database.TransactionDetails
                                 join d in database.BillInfoes on c.BillNumber equals d.BillNumber
                                 join f in database.TransactionTypes on c.TranctionTypeID equals f.TransactionTypeID
                                 where d.BillDate >= startDate && d.BillDate <= endDate
                                 where c.ProductID == i.ProductID
                                 where f.TransactionTypeName == "Buy"
                                 group c by 1 into m
                                 select new
                                 {
                                     newTotalbuyQty = m.Sum(x => x.Quantity),
                                     newTotalBuyValue = m.Sum(x => x.TotalPrice)
                                 }).SingleOrDefault();

                var newProdSold = (from c in database.TransactionDetails
                                   join d in database.BillInfoes on c.BillNumber equals d.BillNumber
                                   join f in database.TransactionTypes on c.TranctionTypeID equals f.TransactionTypeID
                                   where d.BillDate >= startDate && d.BillDate <= endDate
                                   where c.ProductID == i.ProductID
                                   where f.TransactionTypeName == "Sell"
                                   group c by 1 into m
                                   select new
                                   {
                                       newTotalsaleQty = m.Sum(x => x.Quantity),
                                       newTotalSaleValue = m.Sum(x => x.TotalPrice)
                                   }).SingleOrDefault();
                if (oldProdCP != null)
                {
                    old_buy_qty = Convert.ToDecimal(oldProdCP.totalbuyQty);
                    old_buy_price = Convert.ToDecimal(oldProdCP.totalBuyValue);
                }
                else
                {
                    old_buy_qty = 0;
                    old_buy_price = 0;
                }

                if (oldProdSold != null)
                {
                    old_sold_qty = Convert.ToDecimal(oldProdSold.totalsaleQty);
                }
                else
                {
                    old_sold_qty = 0;
                }
                if (newProdCP != null)
                {
                    new_buy_qty = Convert.ToDecimal(newProdCP.newTotalbuyQty);
                    new_buy_price = Convert.ToDecimal(newProdCP.newTotalBuyValue);
                }
                else
                {
                    new_buy_qty = 0;
                    new_buy_price = 0;
                }
                if (newProdSold != null)
                {
                    new_sell_qty = Convert.ToDecimal(newProdSold.newTotalsaleQty);
                    new_sell_price = Convert.ToDecimal(newProdSold.newTotalSaleValue);
                }
                else
                {
                    new_sell_qty = 0;
                    new_sell_price = 0;
                }

                new_stock = new_buy_qty;
                old_stock = old_buy_qty - old_sold_qty;
                if (old_buy_qty != 0)
                {
                    old_cp = old_buy_price / old_buy_qty;
                }
                else
                {
                    old_cp = 0;
                }
                if (new_buy_qty != 0)
                {
                    new_cp = new_buy_price / new_buy_qty;
                }
                else
                {
                    new_cp = 0;
                }
                if ((old_stock + new_stock) != 0)
                {
                    final_cp = ((old_cp * old_stock) + new_buy_price) / (old_stock + new_stock);
                }
                else
                {
                    final_cp = 0;
                }
                if (new_sell_qty != 0)
                {
                    final_sp = new_sell_price / new_sell_qty;
                }
                else
                {
                    final_sp = 0;
                }


                profit_loss_per_pc = final_sp - final_cp;

                total_profit_loss = profit_loss_per_pc * new_sell_qty;

                sum_profit_loss += total_profit_loss;
                sum_sell_price += new_sell_price;
                sum_new_total_buy += new_buy_price;

                //Insert Records into GridView
                DataGridViewRow grow = new DataGridViewRow();
                grow.CreateCells(dataGridViewProfitLoss);
                grow.Cells[0].Value = dataGridViewProfitLoss.RowCount + 1;
                grow.Cells[1].Value = i.ProductID;
                grow.Cells[1].Style.ForeColor = Color.Blue;
                grow.Cells[1].ToolTipText = GetToolTipText(i.ProductID);
                
                grow.Cells[2].Value = product_description;
                grow.Cells[3].Value = old_stock;
                grow.Cells[4].Value = old_cp;
                grow.Cells[5].Value = new_stock;
                grow.Cells[6].Value = new_cp;
                grow.Cells[7].Value = final_cp;


                grow.Cells[8].Value = new_sell_qty;
                grow.Cells[9].Value = final_sp;
                grow.Cells[10].Value = profit_loss_per_pc;
                grow.Cells[11].Value = total_profit_loss;


                dataGridViewProfitLoss.Rows.Add(grow);
                dataGridViewProfitLoss.AllowUserToAddRows = false;





            }

            final_profit_loss = sum_profit_loss - sum_discount;

            net_cash = sum_sell_price - (sum_discount + sum_new_total_buy);

            DataGridViewRow grow1 = new DataGridViewRow();
            grow1.CreateCells(dataGridViewProfitLoss);
            grow1.Cells[10].Value = "Profit";
            grow1.Cells[11].Value = sum_profit_loss;
            dataGridViewProfitLoss.Rows.Add(grow1);

            DataGridViewRow grow2 = new DataGridViewRow();
            grow2.CreateCells(dataGridViewProfitLoss);
            grow2.Cells[4].Value = "New Stock Bought";
            grow2.Cells[5].Value = sum_new_total_buy;
            grow2.Cells[7].Value = "Total Sell Amt";
            grow2.Cells[8].Value = sum_sell_price;
            grow2.Cells[10].Value = "Total Discounts";
            grow2.Cells[11].Value = sum_discount;
            dataGridViewProfitLoss.Rows.Add(grow2);

            DataGridViewRow grow3 = new DataGridViewRow();
            grow3.CreateCells(dataGridViewProfitLoss);
            grow3.Cells[7].Value = "Net Cash";
            grow3.Cells[8].Value = net_cash;
            if(net_cash<0)
            {
                grow3.Cells[8].Style.Font = boldfont;
                grow3.Cells[8].Style.ForeColor = Color.Red;
            }
            else
            {

                grow3.Cells[8].Style.Font = boldfont;
                grow3.Cells[8].Style.ForeColor = Color.Green;
            }
            grow3.Cells[10].Value = "Net Profit";
            grow3.Cells[11].Value = final_profit_loss;
            if(final_profit_loss<0)
            {
                grow3.Cells[11].Style.Font = boldfont;
                grow3.Cells[11].Style.ForeColor = Color.Red;
            }
            else
            {
                grow3.Cells[11].Style.Font = boldfont;
                grow3.Cells[11].Style.ForeColor = Color.Green;
            }

            dataGridViewProfitLoss.Rows.Add(grow3);


            dataGridViewProfitLoss.AllowUserToAddRows = false;


            //MessageBox.Show("Total Profit" + sum_profit_loss.ToString() + "Total Discount" + sum_discount.ToString() + " Final Profit" + final_profit_loss.ToString());

        }


        public string GetToolTipText(int productID)
        {
            string toolTipText = "";
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
                            details = g.VarientName+" "+e.TypeName + " " + f.SubTypeName + " " + "   MRP = " + i.MRP,

                        }).FirstOrDefault();

            if(list!=null)
            {
                toolTipText = list.details;
            }
            else
            {
                toolTipText = "Product Info Not Available";
            }



            return toolTipText;
        }

    }
}
   