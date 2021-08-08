using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBSBank
{
    public class UserCManager
    {

        public static  Control CurrentUC;
        public void DisplayControl(Control uc, Panel pnl)
        {
            pnl.Controls.Clear();
            uc.BringToFront();
            pnl.Controls.Add(uc);
        }
    }
}
