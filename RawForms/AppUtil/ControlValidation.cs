using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RawForms.AppUtil
{
   public static class ControlValidation
    {
       
        static Regex alphanumeric = new Regex("^[a-zA-Z0-9]*$");
        static Regex email = new Regex(@"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,6}$", RegexOptions.IgnoreCase);
        static Regex mobileno = new Regex(@"^\d{10}$");

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

    }
}
