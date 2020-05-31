using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RawForms.Pages
{
   public static class messageBoxDialogue
    {
      public static void show(string message, bool? isConfirm)
        {
            var msgBox = new messageBoxAlert();
            msgBox.StartPosition = FormStartPosition.CenterScreen;
            msgBox.showDialogue(message, isConfirm);
        }
    }
}
