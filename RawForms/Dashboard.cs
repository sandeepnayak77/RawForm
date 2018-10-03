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

namespace RawForms
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
         var v= AppTheme.SetAppTheme();
            this.panelVerticalMenu.BackColor = System.Drawing.Color.FromArgb(v[0], v[1], v[2]);
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

        private void LoadFormInPanel(object formsender)
        {
            if (this.panelContainer.Controls.Count > 0)
            {
                this.panelContainer.Controls.RemoveAt(0);
            }
            Form formObj = formsender as Form;
            formObj.TopLevel = false;
            formObj.Dock = DockStyle.Fill;
            this.panelContainer.Controls.Add(formObj);
            this.panelContainer.Tag = formObj;
            formObj.Show();


        }

        private void btnInventoryMenu_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new Inventory());
        }

        
    }
}
