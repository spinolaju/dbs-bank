using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace BIZ
{
    public class FormValidator
    {

        public void ValidatingInt(ErrorProvider ep, TextBox txtNum, CancelEventArgs e)
        {
            bool cancel = false;
            bool isNumber = int.TryParse(txtNum.Text, out _);
            if (isNumber == false || string.IsNullOrEmpty(txtNum.Text))
            {
                ep.SetError(txtNum, "It should be a number");
                cancel = true;
            }
            e.Cancel = cancel;
        }
        public void ValidatingDecimal(ErrorProvider ep, TextBox txtDecimal, CancelEventArgs e)
        {
            bool cancel = false;
            bool isNumber = decimal.TryParse(txtDecimal.Text, out _);
            if (isNumber == false || string.IsNullOrEmpty(txtDecimal.Text))
            {
                ep.SetError(txtDecimal, "It should be a number");
                cancel = true;
            }
            e.Cancel = cancel;
        }

        public void ValidatingFields(ErrorProvider ep, TextBox txtBox, CancelEventArgs e)
        {
            bool cancel = false;
            if (String.IsNullOrEmpty(txtBox.Text) || String.IsNullOrWhiteSpace(txtBox.Text))
            {
                ep.SetError(txtBox, $"It must not be blank");
                cancel = true;
            }
            e.Cancel = cancel;
        }

        public void ValidantingEmail(ErrorProvider ep, TextBox txtEmail, CancelEventArgs e)
        {
            Regex reg = new Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            bool cancel = false;
            if (!reg.IsMatch(txtEmail.Text) || String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrWhiteSpace(txtEmail.Text))
            {
                
                ep.SetError(txtEmail, "Invalid Email Format! It should be user@domain");
                cancel = true;
            }
            e.Cancel = cancel;
        }


    }

}
