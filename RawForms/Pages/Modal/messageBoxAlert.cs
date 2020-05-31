using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RawForms.Pages
{
    public partial class messageBoxAlert : Form
    {
        public messageBoxAlert()
        {
            
            InitializeComponent();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public void showDialogue(string msg, bool? isConfirm)
        {
            lblMessage.Text = msg;
            if (!(bool)isConfirm)
            {
                ok.Left = (footerPanel.Width - ok.Width) / 2;
                ok.Top = (footerPanel.Height - ok.Height) / 2;
            }
            cancel.Visible = (bool)isConfirm;
            this.ShowDialog();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
