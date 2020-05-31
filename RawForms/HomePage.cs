using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RawForms.Pages
{
    public partial class HomePage : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparm, int lparam);

        public HomePage()
        {
            InitializeComponent();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnMax_Click_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click_2(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void home_Click(object sender, EventArgs e)
        {
            markPanelToVisible("Home");
        }

        private void prod_Click(object sender, EventArgs e)
        {
            markPanelToVisible("Prod");
            lblTitleBar.Text = "Product Entry";
            LoadFormInPanel(new ProductEntry());
        }

        private void stock_Click(object sender, EventArgs e)
        {
            markPanelToVisible("Stock");
            lblTitleBar.Text = "Stock Entry";
            LoadFormInPanel(new StockEntry());
        }

        private void sales_Click(object sender, EventArgs e)
        {
            markPanelToVisible("Sales");
        }
        private void markPanelToVisible(string panelName)
        {
            pnlHome.Visible = panelName == "Home" ? true : false ;
            pnlProduct.Visible = panelName == "Prod" ? true : false;
            pnlStock.Visible = panelName == "Stock" ? true : false;
            pnlSales.Visible = panelName == "Sales" ? true : false;
        }

        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (panelVerticalMenu.Width == 150 || panelVerticalMenu.Width == 133)
            {
                for (int i = 150; i >= 50; i--)
                    panelVerticalMenu.Width = i;

            }
            else if (panelVerticalMenu.Width == 50)
            {
                for (int i = 50; i <= 150; i++)
                    panelVerticalMenu.Width = i;
            }
        }

        private void d(object sender, EventArgs e)
        {

        }

        private void logOut_Click(object sender, EventArgs e)
        {
            messageBoxDialogue.show("my message", false);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelVerticalMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void HomePage_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }



        private void LoadFormInPanel(object formsender)
        {
            if (this.panelContainer.Controls.Count > 0)
            {
                for (int i = 0; i < this.panelContainer.Controls.Count; i++)
                    this.panelContainer.Controls.RemoveAt(i);


            }
            Form formObj = formsender as Form;
            formObj.TopLevel = false;
            formObj.Dock = DockStyle.Fill;
            this.panelContainer.Controls.Add(formObj);
            this.panelContainer.Tag = formObj;
            //formObj.StartPosition = FormStartPosition.CenterParent;
            //formObj.Location = new Point( (panelContainer.Width-formObj.Width) / 2 , (panelContainer.Height - formObj.Height) / 2);
            formObj.Show();


        }













    }
    
}
