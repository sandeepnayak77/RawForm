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
    public partial class ProfitLossReport : Form
    {
        public ProfitLossReport()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePickerStart.Value, endDate = dateTimePickerEnd.Value;
            decimal old_buy_qty = 0, old_buy_price = 0, old_sold_qty = 0, new_buy_qty = 0, new_buy_price = 0,
                new_sell_qty = 0, new_sell_price = 0, new_stock = 0, old_stock = 0, old_cp = 0, new_cp = 0, final_cp = 0,
                final_sp = 0, profit_loss_per_pc = 0, total_profit_loss = 0, sum_profit_loss = 0, final_profit_loss = 0;


             var database = new InventoryEntities();
            var distinctProductID = (from c in database.TransactionDetails
                                     join d in database.BillInfoes on c.BillNumber equals d.BillNumber
                                     where d.BillDate >= startDate && d.BillDate <= endDate
                                     select new
                                     {
                                         c.ProductID
                                     }).Distinct();

            foreach(var i in distinctProductID)
            {
                var oldProdCP = (from c in database.TransactionDetails
                                 join d in database.BillInfoes on c.BillNumber equals d.BillNumber
                                 join f in database.TransactionTypes on c.TranctionTypeID equals f.TransactionTypeID
                                 where d.BillDate < startDate
                                 where c.ProductID == i.ProductID
                                 where f.TransactionTypeName == "Buy"
                                 group c by 1 into m
                                 select new
                                 {
                                     totalbuyQty =m.Sum(x=> x.Quantity),
                                     totalBuyValue=m.Sum(x=>x.TotalPrice)
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
                if(oldProdCP != null)
                {
                    old_buy_qty = Convert.ToDecimal(oldProdCP.totalbuyQty);
                    old_buy_price = Convert.ToDecimal(oldProdCP.totalBuyValue);
                }

                if(oldProdSold != null)
                {
                    old_sold_qty = Convert.ToDecimal(oldProdSold.totalsaleQty);
                }
                if(newProdCP != null)
                {
                    new_buy_qty = Convert.ToDecimal(newProdCP.newTotalbuyQty);
                    new_buy_price = Convert.ToDecimal(newProdCP.newTotalBuyValue);
                }
                if(newProdSold!=null)
                {
                    new_sell_qty = Convert.ToDecimal(newProdSold.newTotalsaleQty);
                    new_sell_price = Convert.ToDecimal(newProdSold.newTotalSaleValue);
                }
                
                new_stock = new_buy_qty;
                old_stock = old_buy_qty - old_sold_qty;
                if(old_buy_qty != 0)
                {
                    old_cp = old_buy_price / old_buy_qty;
                }
                else
                {
                    old_cp = 0;
                }
                if(new_buy_qty != 0)
                {
                    new_cp = new_buy_price / new_buy_qty;
                }
                else
                {
                    new_cp = 0;
                }
                if((old_stock + new_stock) != 0)
                {
                    final_cp = ((old_cp * old_stock) + new_buy_price) / (old_stock + new_stock);
                }
                else
                {
                    final_cp = 0;
                }
                if(new_sell_qty != 0)
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


                
            }
            MessageBox.Show(sum_profit_loss.ToString());
        }
    }
}
