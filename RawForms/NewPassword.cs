using RawForms.AppUtil;
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

        private void NewPassword_Load(object sender, EventArgs e)
        {
            this.ActiveControl = btnUpdate;
            lblError.Text = "";
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.ToLower() == "newpassword" || txtPassword.Text.ToLower() == "password" || txtPassword.Text.ToLower() == "confirmpassword " || txtPassword.Text.ToLower() == "confirmnewpassword")
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
            if (txtConfirmPassword.Text.ToLower() == "confirmnewpassword")
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
            if (ControlValidation.Isblank(txtPassword.Text.Trim()) == true || ControlValidation.IsReserveWord(txtPassword.Text.Trim().ToLower()))
            {

                lblError.Text = "Pleasse enter Password !";
                txtPassword.Text = "";
                txtPassword.Focus();
            }
            else if (txtPassword.Text.Trim() != txtConfirmPassword.Text.Trim())
            {
                lblError.Text = "Password Mismatch !";
                txtPassword.Text = "";
                txtPassword.Focus();
                txtConfirmPassword.Text = "ConfirmNewPassword";
            }
            else
            {
                MessageBox.Show("Password Reset Successfully!!!!");
                Login loginform = new Login();
                loginform.Show();
                this.Hide();
            }
            
               
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        private void txtConfirmPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        private void panelConfirmNewPassword_Enter(object sender, EventArgs e)
        {
            txtConfirmPassword.UseSystemPasswordChar = true;
        }

        private void panelnewPassword_Enter(object sender, EventArgs e)
        {
            txtConfirmPassword.UseSystemPasswordChar = true;
        }
    }
}
