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
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            txtAnswer1.Hide();
            txtAnswer2.Hide();
            lblError.Text = "";
            this.ActiveControl = btnReset;
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
                txtUsername.Text = "";
            lblError.Text = "";
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
                var result = GetQues();
               if(result.Result)
                {
                    //MessageBox.Show("Success!!!");
                    txtAnswer1.Show();
                    txtAnswer2.Show();
                    txtAnswer1.Enabled = true;
                    txtAnswer2.Enabled = true;
                }
               else
                {
                    lblError.Text = result.Message;
                    txtAnswer1.Hide();
                    txtAnswer2.Hide();
                }
               
                


            }
                
        }



        private void txtAnswar1_Click(object sender, EventArgs e)
        {
            if (txtAnswer1.Text == "Answer")
                txtAnswer1.Text = "";
        }

        private void txtAnswar1_Leave(object sender, EventArgs e)
        {
            if (txtAnswer1.Text == "")
                txtAnswer1.Text = "Answer";
        }



        private void txtAnswar2_Click(object sender, EventArgs e)
        {
            if (txtAnswer2.Text == "Answer")
                txtAnswer2.Text = "";
        }

        private void txtAnswar2_Leave(object sender, EventArgs e)
        {
            if (txtAnswer2.Text == "")
                txtAnswer2.Text = "Answer";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            if (ControlValidation.Isblank(txtUsername.Text.Trim()) == true || ControlValidation.IsReserveWord(txtUsername.Text.Trim().ToLower()))
            {
                lblError.Text = "Please enter Username !";
                txtUsername.Text = "";
                txtUsername.Focus();

            }
            else if (ControlValidation.Isblank(txtAnswer1.Text.Trim()) == true || ControlValidation.IsReserveWord(txtAnswer1.Text.Trim().ToLower()))
            {
                lblError.Text = "Enter Answar for Question1 !";
                txtAnswer1.Text = "";
                txtAnswer1.Focus();
            }
            else if (ControlValidation.Isblank(txtAnswer2.Text.Trim()) == true || ControlValidation.IsReserveWord(txtAnswer2.Text.Trim().ToLower()))
            {
                lblError.Text = "Enter Answar for Question2 !";
                txtAnswer2.Text = "";
                txtAnswer2.Focus();
            }

            else 
            {
                var result = CheckAnswer();
                if(result.Result)
                {
                    if ((MessageBox.Show("Are you Sure to Reset the Password ???", "Password Reset", MessageBoxButtons.YesNo) == DialogResult.Yes))
                    {
                        NewPassword newpasswordform = new NewPassword();
                        newpasswordform.userName = txtUsername.Text.Trim();
                        newpasswordform.userID = Convert.ToInt32(txthiddenUserID.Text.Trim());
                        newpasswordform.Show();
                        this.Hide();
                    }
                    else
                    {
                        ForgotPassword forgotPasswordform = new ForgotPassword();
                        forgotPasswordform.Show();
                    }
                }
                else
                {
                    lblError.Text = result.Message;
                }
                
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

        private Results GetQues()
        {
            var result = new Results();
            try
            {
                var database = new InventoryEntities();
                var userMaster = new UserMaster();
                var userAuth = new UserAuth();
                var record = (from c in database.UserAuths where c.UserName == txtUsername.Text.Trim() select c).FirstOrDefault();
                if(record != null)
                {
                    txthiddenUserID.Text = record.UserId.ToString();
                    var quesID1 = record.FirstQuestionID;
                    var quesID2 = record.SecondQuestionID;
                    var answer1 = record.FirstQuestionAnswer;
                    var answer2 = record.SecondQuestionAnswer;
                    var ques1 = (from c in database.SecurityQuestions where c.QuestionID == quesID1 select c).FirstOrDefault();
                    var ques2 = (from c in database.SecurityQuestions where c.QuestionID == quesID2 select c).FirstOrDefault();
                    lblQuestion1.Text = ques1.Question.ToString();
                    lblQuestion2.Text = ques2.Question.ToString();
                    result.Result = true;
                    return result;
                }
                else
                {
                    result.Message = "Please enter a valid User Name";
                    result.Result = false;
                    return result;
                }

                
            }
            catch(Exception ex)
            {
                result.Result = false;
                return result;
            }
        }
        private  Results CheckAnswer()
        {
            var result = new Results();
            try
            {
                var database = new InventoryEntities();
               
                var userAuth = new UserAuth();
                var record = (from c in database.UserAuths where c.UserName == txtUsername.Text.Trim() select c).FirstOrDefault();
                if (record != null)
                {
                    
                    var answer1 = record.FirstQuestionAnswer;
                    var answer2 = record.SecondQuestionAnswer;
                    if(answer1==txtAnswer1.Text.Trim()&& answer2 == txtAnswer2.Text.Trim())
                    {
                        result.Result = true;
                        result.Message = "";
                    }
                    else if(answer1 != txtAnswer1.Text.Trim()&& answer2 != txtAnswer2.Text.Trim())
                    {
                        result.Result = false;
                        result.Message = "Please enter correct Answar for both questions.";
                        
                    }
                    else if (answer1 != txtAnswer1.Text.Trim())
                    {
                        result.Result = false;
                        result.Message = "Please enter correct Answar for first question.";
                    }
                    else
                    {
                        result.Result = false;
                        result.Message = "Please enter correct Answar for Second question.";

                    }
                }
                
                else
                {
                    result.Message = "No Records Please contact Administrator.";
                    result.Result = false;
                    return result;
                }

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
