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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void Signup_Load(object sender, EventArgs e)
        {
            cmbQues1.Items.Add("     --Select--");
            cmbQues1.Items.Add("What is your village name ?");
            cmbQues1.Items.Add("What is your father's name ?");
            cmbQues1.SelectedIndex = 0;
            cmbQues2.Items.Add("     --Select--");
            cmbQues2.Items.Add("What is your village name ?");
            cmbQues2.Items.Add("What is your father's name ?");
            cmbQues2.SelectedIndex = 0;
            this.ActiveControl = btnSignUp;
            lblError.Text = "";
        }


        private void txtUsername_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
                txtUsername.Text = "";
        }
        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
                txtUsername.Text = "Username";
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
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
                txtPassword.Text = "Password";
            }
        }

        private void txtConfirmPassword_Click(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text == "ConfirmPassword")
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
                txtConfirmPassword.Text = "ConfirmPassword";
            }
        }

        private void txtMobileNo_Click(object sender, EventArgs e)
        {
            if (txtMobileNo.Text == "MobileNo")
                txtMobileNo.Text = "";
        }

        private void txtMobileNo_Leave(object sender, EventArgs e)
        {
            if (txtMobileNo.Text == "")
                txtMobileNo.Text = "MobileNo";
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "E-mail")
                txtEmail.Text = "";
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
                txtEmail.Text = "E-mail";
        }

        private void cmbQues1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbQues1.SelectedIndex > 0)
            {
                txtAnswar1.Show();
                txtAnswar1.Enabled = true;
            }

            else
            {
                txtAnswar1.Hide();
                txtAnswar1.Enabled = false;
            }


            //MessageBox.Show(cmbQues1.SelectedIndex.ToString());
        }

        private void txtAnswar1_Click(object sender, EventArgs e)
        {
            if (txtAnswar1.Text == "Answar")
                txtAnswar1.Text = "";
        }

        private void txtAnswar1_Leave(object sender, EventArgs e)
        {
            if (txtAnswar1.Text == "")
                txtAnswar1.Text = "Answar";
        }

        private void cmbQues2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbQues2.SelectedIndex > 0)
            {
                txtAnswar2.Show();
                txtAnswar2.Enabled = true;
            }

            else
            {
                txtAnswar2.Hide();
                txtAnswar2.Enabled = false;
            }
        }

        private void txtAnswar2_Click(object sender, EventArgs e)
        {
            if (txtAnswar2.Text == "Answar")
                txtAnswar2.Text = "";
        }

        private void txtAnswar2_Leave(object sender, EventArgs e)
        {
            if (txtAnswar2.Text == "")
                txtAnswar2.Text = "Answar";
        }


        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (ControlValidation.Isblank(txtUsername.Text.Trim()) == true || txtUsername.Text.Trim() == "Username")
            {
                lblError.Text = "Please enter Username !";

            }
            else if (ControlValidation.Isblank(txtPassword.Text.Trim()) == true || txtPassword.Text.Trim() == "Password")
            {

                lblError.Text = "Pleasse enter Password !";
            }
            else if (txtPassword.Text.Trim() != txtConfirmPassword.Text.Trim())
            {
                lblError.Text = "Password Mismatch !";
            }
            else if (ControlValidation.Isblank(txtMobileNo.Text.Trim()) == true || txtMobileNo.Text.Trim() == "MobileNo" || ControlValidation.IsValidMobileNo(txtMobileNo.Text.Trim()) == false)
            {
                lblError.Text = "Enter valid Mobile Number !";
            }
            else if (ControlValidation.Isblank(txtEmail.Text.Trim()) == true || txtEmail.Text.Trim() == "E-mail" || ControlValidation.IsValidEmail(txtEmail.Text.Trim()) == false)
            {
                lblError.Text = "Enter a valid email id !";
            }
            else if (cmbQues1.SelectedIndex == 0)
            {
                lblError.Text = "Select Security Question 1 !";
            }
            else if (ControlValidation.Isblank(txtAnswar1.Text.Trim()) == true || txtAnswar1.Text.Trim() == "Answar")
            {
                lblError.Text = "Enter Answar for Question1 !";
            }
            else if (cmbQues2.SelectedIndex == 0)
            {
                lblError.Text = "Select Security Question 2 !";
            }
            else if (ControlValidation.Isblank(txtAnswar2.Text.Trim()) == true || txtAnswar2.Text.Trim() == "Answar")
            {
                lblError.Text = "Enter Answar for Question2 !";
            }
            else
            {
                lblError.Text = "";
                Login loginform = new Login();
                loginform.Show();
                this.Hide();
            }


        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < (char)Keys.NumPad0 || e.KeyChar > (char)Keys.NumPad9) && (e.KeyChar < (char)Keys.A || e.KeyChar > (char)Keys.Z))
            {
                e.Handled = true;
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

        private void txtMobileNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }
    }
}