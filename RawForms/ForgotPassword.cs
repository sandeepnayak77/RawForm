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
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            txtAnswar1.Hide();
            txtAnswar2.Hide();
            lblError.Text = "";
            this.ActiveControl = btnReset;
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
                txtUsername.Text = "";
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
            }
            else
            {
                //call the DB to get Ques and enabled the Answar Button if valid username enabled below button
                txtAnswar1.Show();
                txtAnswar2.Show();
                txtAnswar1.Enabled = true;
                txtAnswar2.Enabled = true;


            }
                
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

        private void btnReset_Click(object sender, EventArgs e)
        {

            if (ControlValidation.Isblank(txtUsername.Text.Trim()) == true || ControlValidation.IsReserveWord(txtUsername.Text.Trim().ToLower()))
            {
                lblError.Text = "Please enter Username !";
                txtUsername.Text = "";
                txtUsername.Focus();

            }
            else if (ControlValidation.Isblank(txtAnswar1.Text.Trim()) == true || ControlValidation.IsReserveWord(txtAnswar1.Text.Trim().ToLower()))
            {
                lblError.Text = "Enter Answar for Question1 !";
                txtAnswar1.Text = "";
                txtAnswar1.Focus();
            }
            else if (ControlValidation.Isblank(txtAnswar2.Text.Trim()) == true ||  ControlValidation.IsReserveWord(txtAnswar2.Text.Trim().ToLower()))
            {
                lblError.Text = "Enter Answar for Question2 !";
                txtAnswar2.Text = "";
                txtAnswar2.Focus();
            }

            else if (MessageBox.Show("Are you Sure to Reset the Password ???", "Password Reset", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                NewPassword newpasswordform = new NewPassword();
                newpasswordform.Show();
                this.Hide();

            }
            else
            {
                ForgotPassword forgotPasswordform = new ForgotPassword();
                forgotPasswordform.Show();
            }
               
        }

        private void ForgotPassword_Click(object sender, EventArgs e)
        {
            btnReset.Focus();
            //this.Focus();
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtAnswar1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        private void txtAnswar2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }
    }
}
