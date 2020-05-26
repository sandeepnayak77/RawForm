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
    public partial class UserRegistration : Form
    {
        public UserRegistration()
        {
            InitializeComponent();
        }

        private void Signup_Load(object sender, EventArgs e)
        {
            //cmbQues1.Items.Add("     --Select--");
            //cmbQues1.Items.Add("What is your village name ?");
            //cmbQues1.Items.Add("What is your father's name ?");
            //cmbQues1.SelectedIndex = 0;
            //cmbQues2.Items.Add("     --Select--");
            //cmbQues2.Items.Add("What is your village name ?");
            //cmbQues2.Items.Add("What is your father's name ?");
            //cmbQues2.SelectedIndex = 0;
            
            this.ActiveControl = btnSignUp;
            lblError.Text = "";
            BindQuestionToDropDown();
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
        private void txtFirstName_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "FirstName")
                txtFirstName.Text = "";
        }

        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "")
                txtFirstName.Text = "FirstName";
        }

        private void txtLastName_Click(object sender, EventArgs e)
        {
            if (txtLastName.Text == "LastName")
                txtLastName.Text = "";
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            if (txtLastName.Text == "")
                txtLastName.Text = "LastName";
        }

        private void txtMiddleName_Click(object sender, EventArgs e)
        {
            if (txtMiddleName.Text == "MiddleName")
                txtMiddleName.Text = "";
        }

        private void txtMiddleName_Leave(object sender, EventArgs e)
        {
            if (txtMiddleName.Text == "")
                txtMiddleName.Text = "MiddleName";
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
                txtAnswer1.Show();
                txtAnswer1.Enabled = true;
                //MessageBox.Show(Convert.ToInt32(cmbQues1.SelectedValue).ToString());
            }

            else
            {
                txtAnswer1.Hide();
                txtAnswer1.Enabled = false;

            }


            //MessageBox.Show(cmbQues1.SelectedIndex.ToString());
        }

        private void txtAnswar1_Click(object sender, EventArgs e)
        {
            if (txtAnswer1.Text == "Answer")
            {
                txtAnswer1.Text = "";
                
            }
                
        }

        private void txtAnswar1_Leave(object sender, EventArgs e)
        {
            if (txtAnswer1.Text == "")
            {
                txtAnswer1.Text = "Answer";
                
            }
                
        }

        private void cmbQues2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbQues2.SelectedIndex > 0)
            {
                txtAnswer2.Show();
                txtAnswer2.Enabled = true;
                //MessageBox.Show(Convert.ToInt32(cmbQues2.SelectedValue).ToString());

            }

            else
            {
                txtAnswer2.Hide();
                txtAnswer2.Enabled = false;
            }
        }

        private void txtAnswar2_Click(object sender, EventArgs e)
        {
            if (txtAnswer2.Text == "Answer")
            {
                txtAnswer2.Text = "";
                
            }
                
        }

        private void txtAnswar2_Leave(object sender, EventArgs e)
        {
            if (txtAnswer2.Text == "")
            {
                txtAnswer2.Text = "Answer";
                
            }
                
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (((e.KeyChar < (char)Keys.NumPad0) || (e.KeyChar > (char)Keys.NumPad9) ) && ((e.KeyChar < (char)Keys.A )|| (e.KeyChar > (char)Keys.Z)))
            if (!(char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
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
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
            //e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        private void txtAnswar1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);

        }

        private void txtAnswar2_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = (e.KeyChar == (char)Keys.Space);

        }

        private void panelPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void panelConfirmPassword_Enter(object sender, EventArgs e)
        {
            txtConfirmPassword.UseSystemPasswordChar = true;
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtMiddleName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }


        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (ControlValidation.Isblank(txtUsername.Text.Trim()) == true || ControlValidation.IsReserveWord(txtUsername.Text.Trim().ToLower()))
            {
                lblError.Text = "Please enter Username !";
                txtUsername.Text="";
                txtUsername.Focus();

            }
            else if (ControlValidation.Isblank(txtPassword.Text.Trim()) == true || ControlValidation.IsReserveWord(txtPassword.Text.Trim().ToLower()))
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
                txtConfirmPassword.Text = "ConfirmPassword";

            }
            else if (ControlValidation.Isblank(txtFirstName.Text.Trim()) == true || ControlValidation.IsReserveWord(txtFirstName.Text.Trim().ToLower()))
            {
                lblError.Text = "Enter First Name !";
                txtFirstName.Text = "";
                txtFirstName.Focus();
            }
            else if (ControlValidation.Isblank(txtLastName.Text.Trim()) == true || ControlValidation.IsReserveWord(txtLastName.Text.Trim().ToLower()))
            {
                lblError.Text = "Enter Last Name !";
                txtLastName.Text = "";
                txtLastName.Focus();
            }
            else if (radioMale.Checked==false && radioFemale.Checked==false)
            {
                lblError.Text = "Select Gender !";
                
                
            }
            else if (ControlValidation.Isblank(txtMobileNo.Text.Trim()) == true || txtMobileNo.Text.Trim() == "MobileNo" || ControlValidation.IsValidMobileNo(txtMobileNo.Text.Trim()) == false)
            {
                lblError.Text = "Enter valid Mobile Number !";
                txtMobileNo.Text = "";
                txtMobileNo.Focus();
            }
            else if (ControlValidation.Isblank(txtEmail.Text.Trim()) == true || txtEmail.Text.Trim() == "E-mail" || ControlValidation.IsValidEmail(txtEmail.Text.Trim()) == false)
            {
                lblError.Text = "Enter a valid email id !";
                txtEmail.Text = "";
                txtEmail.Focus();
            }
            else if (cmbQues1.SelectedIndex == 0)
            {
                lblError.Text = "Select Security Question 1 !";
            }
            else if (ControlValidation.Isblank(txtAnswer1.Text.Trim()) == true || ControlValidation.IsReserveWord(txtAnswer1.Text.Trim().ToLower()))
            {
                lblError.Text = "Enter Answer for Question1 !";
                txtAnswer1.Text = "";
                txtAnswer1.Focus();
            }
            else if (cmbQues2.SelectedIndex == 0)
            {
                lblError.Text = "Select Security Question 2 !";
            }
            else if (ControlValidation.Isblank(txtAnswer2.Text.Trim()) == true || ControlValidation.IsReserveWord(txtAnswer2.Text.Trim().ToLower()))
            {
                lblError.Text = "Enter Answer for Question2 !";
                txtAnswer2.Text = "";
                txtAnswer2.Focus();
            }
            else
            {
                InventoryEntities database = new InventoryEntities();
                if(ControlValidation.IsReserveWord(txtMiddleName.Text.Trim()))
                {
                    txtMiddleName.Text = "";
                }
                var result = Register();
                if(result.Result==true)
                {
                    lblError.Text = "";
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
        private Results Register()
        {
            var result = new Results();
            try
            {
                var database = new InventoryEntities();
                var userMaster = new UserMaster();
                var userAuth = new UserAuth();
                var count = (from c in database.UserAuths where c.UserName == txtUsername.Text.Trim() select c).Count();
                if(count==0)
                {
                    //userMaster.CompanyName = "FFU";

                    userMaster.FirstName = txtFirstName.Text.Trim();
                    userMaster.MiddleName = txtMiddleName.Text.Trim();
                    userMaster.LastName = txtLastName.Text.Trim();
                    if (radioMale.Checked)
                        userMaster.Gender = radioMale.Text.Trim();
                    else if (radioFemale.Checked)
                        userMaster.Gender = radioFemale.Text.Trim();
                    else
                        userMaster.Gender = "";
                                    
                    userMaster.PhoneNumber = txtMobileNo.Text.Trim();
                    userMaster.EmailId = txtEmail.Text.Trim();
                    //userMaster.ZIP="FFU";
                    //userMaster.Street = "FFU";
                    //userMaster.Village = "FFU";
                    //userMaster.Village = "FFU";
                    //userMaster.District = 1;
                    //userMaster.State = 1;
                    userMaster.CreatedBy = 1;
                    userMaster.CreatedOn = System.DateTime.Now;
                    userMaster.DeletedFlag = false;





                    userAuth.UserName = txtUsername.Text.Trim();
                    userAuth.Password = txtPassword.Text.Trim();
                    userAuth.FirstQuestionID = Convert.ToInt32(cmbQues1.SelectedValue);
                    userAuth.FirstQuestionAnswer = txtAnswer1.Text.Trim();
                    userAuth.SecondQuestionID = Convert.ToInt32(cmbQues2.SelectedValue);
                    userAuth.SecondQuestionAnswer = txtAnswer2.Text.Trim();
                    userAuth.IsActive = true;
                    userAuth.CreatedBy = 1;
                    userAuth.CreatedOn = System.DateTime.Now;

                    database.UserMasters.Add(userMaster);
                    database.UserAuths.Add(userAuth);
                    database.SaveChanges();
                    
                }
                else
                {
                    result.Message = "User Already exists";
                    result.Result = false;
                    return result;
                }

                result.Result = true;
                return result;
            }
            catch(Exception ex)
            {
                result.Result = false;
                return result;
            }


        }

        private void BindQuestionToDropDown()
        {
            //InitializeComponent();
            var database = new InventoryEntities();
            var count = (from c in database.SecurityQuestions select c).Count();
            var queslist1 = (from c in database.SecurityQuestions where c.QuestionID <= (count/2) select c).ToList();
            var queslist2 = (from c in database.SecurityQuestions where c.QuestionID > (count / 2) select c).ToList();


            queslist1.Insert(0, new SecurityQuestion { QuestionID = 0, Question = "--Select--" });
            
            cmbQues1.ValueMember = "QuestionID";
            cmbQues1.DisplayMember = "Question";
            cmbQues1.DataSource = queslist1;


            queslist2.Insert(0, new SecurityQuestion { QuestionID = 0, Question = "--Select--" });
            
            cmbQues2.ValueMember = "QuestionID";
            cmbQues2.DisplayMember = "Question";
            cmbQues2.DataSource = queslist2;







        }



    }
}