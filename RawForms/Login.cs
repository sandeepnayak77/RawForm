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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        

        private void txtUsername_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text=="Username")
                    txtUsername.Text = "";
            
            
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.Text = "";
            }
                
            
        }

    
      

     

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
                txtUsername.Text = "Username";
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Text = "Password";
            }
                
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblPasswordError.Text = "";
            lblUsernameError.Text = "";
            this.ActiveControl = btnLogin;
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
            if (ControlValidation.Isblank(txtUsername.Text.Trim()) == true || txtUsername.Text.Trim()=="Username")
            {
                lblUsernameError.Text = "Please enter Username";
                
            }
            else if(ControlValidation.Isblank(txtPassword.Text.Trim()) == true || txtPassword.Text.Trim() == "Password")
            {
                lblUsernameError.Text = "";
                lblPasswordError.Text = "Pleasse enter Password";
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
    }
}
