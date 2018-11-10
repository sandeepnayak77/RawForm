using RawForms.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RawForms.AppUtil
{
   public static class ControlValidation
    {
       
        static Regex alphanumeric = new Regex("^[a-zA-Z0-9]*$");
        static Regex email = new Regex(@"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,6}$", RegexOptions.IgnoreCase);
        static Regex mobileno = new Regex(@"^\d{10}$");
        //static Regex price = new Regex(@"^[+-]?[0-9]*(\.[0-9]*)?([Ee][+-]?[0-9]*)?$");
        

        public static bool Isblank(string inputString)
        {
            bool result = false;
            if (inputString == string.Empty || inputString =="")
                result = true;

            return result;
        }

        public static bool IsValidEmail(String inputEmail)
        {
            
            return email.IsMatch(inputEmail);
        }

        public static bool IsValidMobileNo(string inputMobileNo)
        {
            return mobileno.IsMatch(inputMobileNo);
        }

        public static bool IsReserveWord(string inputstring)
        {
            bool result = false;
            List<string> reservewords = new List<string>();
            reservewords.Add("username");
            reservewords.Add("password");
            reservewords.Add("confirmpassword");
            reservewords.Add("newpassword");
            reservewords.Add("confirmnewpassword");
            reservewords.Add("answer");
            reservewords.Add("mobileno");
            reservewords.Add("firstname");
            reservewords.Add("lastname");
            reservewords.Add("middlename");

            if (reservewords.Contains(inputstring))
            {
                result = true;
            }

            return result;
        }

        public static Money IsValidPrice(string inputstring)
        {
            //return price.IsMatch(inputstring);
            var result = new Money();
            double dummy=0.00;
            bool isValid = double.TryParse(inputstring, System.Globalization.NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"), out dummy);
            result.Result = isValid;
            result.Price = dummy;
            return result;
        }

        public static void IsPrice(object sender, KeyPressEventArgs e)
        {
            string senderText = (sender as TextBox).Text;
            string senderName = (sender as TextBox).Name;
            string[] splitByDecimal = senderText.Split('.');
            int cursorPosition = (sender as TextBox).SelectionStart;

            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }


            if (e.KeyChar == '.'
                && senderText.IndexOf('.') > -1)
            {
                e.Handled = true;
            }


            if (!char.IsControl(e.KeyChar)
                && senderText.IndexOf('.') < cursorPosition
                && splitByDecimal.Length > 1
                && splitByDecimal[1].Length == 2)
            {
                e.Handled = true;
            }
        }

        public static void DisableGridSort(DataGridView dgv, DataGridViewColumnSortMode sortMode)
        {
            foreach (DataGridViewColumn col in dgv.Columns)
                col.SortMode = sortMode;
        }

    }
}
