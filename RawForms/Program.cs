using RawForms.Pages;
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
            // Application.Run(new Login());
            //Application.Run(new NewPassword());
            //Application.Run(new ProductEntry());
            //Application.Run(new StockEntry());
            //Application.Run(new ProductSale());
            Application.Run(new HomePage());
        }
    }
}
