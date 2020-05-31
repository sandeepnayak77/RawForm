using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using RawForms.AppUtil;
using RawForms.Pages.Report;

namespace RawForms
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            Rectangle screen = Screen.PrimaryScreen.WorkingArea;
            int w = Width >= screen.Width ? screen.Width : (screen.Width + Width) / 2;
            int h = Height >= screen.Height ? screen.Height : (screen.Height + Height) / 2;
            this.Location = new Point((screen.Width - w) / 2, (screen.Height - h) / 2);
            this.Size = new Size(w, h);
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
         var v= AppTheme.SetAppTheme();
            this.panelVerticalMenu.BackColor = System.Drawing.Color.FromArgb(v[0], v[1], v[2]);
            this.ResizeRedraw = true;
            lblTitleBar.Text = "";
            
        }
        //functions for Moving the windows screen

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd,int wmsg, int wparm, int lparam);


        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (panelVerticalMenu.Width == 250)
            {
                for(int i=250; i>=50; i--)
                    panelVerticalMenu.Width = i;
                
            }
            else
                for (int i = 50; i <= 250; i++)
                    panelVerticalMenu.Width = i;
            
            
            

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Login.ClearLoginCache();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if(this.WindowState==FormWindowState.Maximized)
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

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void lblTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void LoadFormInPanel(object formsender)
        {
            if (this.panelContainer.Controls.Count > 0)
            {
                for(int i = 0; i < this.panelContainer.Controls.Count; i++)
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

        private void btnInventoryMenu_Click(object sender, EventArgs e)
        {
            var v = AppTheme.SetAppTheme();
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(v[0], v[1], v[2]);
            lblTitleBar.Text = "Inventory";
            LoadFormInPanel(new Inventory());
        }

        private void btnProductEntry_Click(object sender, EventArgs e)
        {
            var v = AppTheme.SetAppTheme();
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(v[0], v[1], v[2]);
            lblTitleBar.Text = "Product Entry";
            LoadFormInPanel(new ProductEntry());
            //var login = new Login();

            //login.ShowDialog(this);
        }

        private void btnStockEntry_Click(object sender, EventArgs e)
        {
            var v = AppTheme.SetAppTheme();
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(v[0], v[1], v[2]);
            lblTitleBar.Text = "Stock Entry";
            LoadFormInPanel(new StockEntry());
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            var v = AppTheme.SetAppTheme();
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(v[0], v[1], v[2]);
            lblTitleBar.Text = "Sales";
            LoadFormInPanel(new ProductSale());
        }

        private void Dashboard_Shown(object sender, EventArgs e)
        {
            Login.ValidateLogin(this);
        }

        private void btnBillReports_Click(object sender, EventArgs e)
        {
            var v = AppTheme.SetAppTheme();
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(v[0], v[1], v[2]);
            lblTitleBar.Text = "Bill Reports";
            LoadFormInPanel(new BillHistoryReport());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var v = AppTheme.SetAppTheme();
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(v[0], v[1], v[2]);
            lblTitleBar.Text = "Profit Loss Statement";
            LoadFormInPanel(new ProfitLossReport());
        }
    }
    
}
