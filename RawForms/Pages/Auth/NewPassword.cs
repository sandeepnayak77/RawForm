using RawForms.AppUtil;
using RawForms.Connection;
using RawForms.Entities;
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
        public string userName { get; set; }
        public int userID { get; set; }
        public NewPassword()
        {
            InitializeComponent();
        }

        private void NewPassword_Load(object sender, EventArgs e)
        {
            this.ActiveControl = btnUpdate;
            txtUsername.Text = userName;
            lblError.Text = "";
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Trim()== "NewPassword")
            {
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.Text = "";
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Trim() == "" || ControlValidation.IsReserveWord(txtPassword.Text.Trim().ToLower()))
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
            if (txtConfirmPassword.Text.Trim() == "" || ControlValidation.IsReserveWord(txtConfirmPassword.Text.Trim().ToLower()))
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

                var result = new Results();
                result = UpdatePassword();
                if(result.Result)
                {
                    MessageBox.Show("Password Reset Successfully!!!!");
                    Login loginform = new Login();
                    loginform.Show();
                    this.Hide();
                }
                else
                {
                    lblError.Text = result.Message;
                }
                


                
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
            txtPassword.UseSystemPasswordChar = true;
        }

        private Results UpdatePassword()
        {
            var result = new Results();
            try
            {
                var database = new InventoryEntities();
               
               var record = (from c in database.UserAuths where c.UserId == userID select c).FirstOrDefault();
                if (record != null)
                {
                    record.Password = txtPassword.Text.Trim();
                    database.SaveChanges();

                }
                else
                {
                    result.Message = "User not exists";
                    result.Result = false;
                    return result;
                }

                result.Result = true;
                return result;
            }
            catch (Exception ex)
            {
                result.Result = false;
                return result;
            }


        }

    }
}

