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
    public partial class NewPassword : Form
    {
        public NewPassword()
        {
            InitializeComponent();
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "NewPassword")
            {
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.Text = "";
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Text = "NewPassword";
            }
        }

        private void txtConfirmPassword_Click(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text == "ConfirmNewPassword")
            {
                txtConfirmPassword.UseSystemPasswordChar = true;
                txtConfirmPassword.Text = "";
            }
        }

        private void txtConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text == "")
            {
                txtConfirmPassword.UseSystemPasswordChar = false;
                txtConfirmPassword.Text = "ConfirmNewPassword";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Password Reset Successfully!!!!");
            Login loginform = new Login();
            loginform.Show();
            this.Hide();
               
        }

        private void NewPassword_Load(object sender, EventArgs e)
        {
            this.ActiveControl = btnUpdate;
        }
    }
}
