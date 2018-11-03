﻿using RawForms.AppUtil;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        

        private void txtUsername_Click(object sender, EventArgs e)
        {

            if (txtUsername.Text.Trim() == "Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }


        }

        private void txtPassword_Click(object sender, EventArgs e)
        {

            if (txtPassword.Text.Trim() == "Password")
            {
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                //txtPassword.PasswordChar = '*';
            }
    
        }






        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "")
            {
                txtUsername.Text = "Username";
                txtUsername.ForeColor = Color.DarkGray;
            }
                

        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Trim()== "")
            {
                
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.DarkGray;
                txtPassword.UseSystemPasswordChar = false;
            }
            btnLogin.Focus();   
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblPasswordError.Text = "";
            lblUsernameError.Text = "";
            //this.Focus();
            this.ActiveControl = lblLoginMessage;
        }

        

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup signupform = new Signup();
            signupform.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword forgotPasswordform = new ForgotPassword();
            forgotPasswordform.Show();
            this.Hide();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ControlValidation.Isblank(txtUsername.Text.Trim()) == true || ControlValidation.IsReserveWord(txtUsername.Text.Trim().ToLower()))
            {
                lblPasswordError.Text = "";
                lblUsernameError.Text = "Please enter a valid Username";
                txtUsername.Text = "";
                txtUsername.Focus();
            }
            else if(ControlValidation.Isblank(txtPassword.Text.Trim()) == true || ControlValidation.IsReserveWord(txtPassword.Text.Trim().ToLower()))
            {
                lblUsernameError.Text = "";
                lblPasswordError.Text = "Pleasse enter a valid Password";
                txtPassword.Text = "";
                txtPassword.Focus();
            }
            else
            {
                lblUsernameError.Text = "";
                lblPasswordError.Text = "";
                //After Password Validation Successful
                Dashboard dashboardfrm = new Dashboard();
                dashboardfrm.Show();
                this.Hide();
            }
                
            
                

            
        }
       

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        private void panelPassword_Enter(object sender, EventArgs e)
        {
            //txtPassword.UseSystemPasswordChar = true;
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            txtUsername_Click(sender, e);
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword_Click(sender, e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
