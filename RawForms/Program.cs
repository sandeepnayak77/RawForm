using RawForms.Pages;
using RawForms.Pages.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RawForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Login());
            //Application.Run(new Dashboard()); // production release1
            Application.Run(new HomePage()); //production release1 2
            //Application.Run(new ProductEntry());
            //Application.Run(new StockEntry());
            //Application.Run(new ProductSale());
            //Application.Run(new BillHistoryReport());
            //Application.Run(new ProfitLossReport());
        }
    }
}
