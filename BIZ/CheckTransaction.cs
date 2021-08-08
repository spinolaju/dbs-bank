using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BIZ
{
    public class CheckTransaction
    {
        
        public bool CheckAccType(string accType)
        {
            if (accType == "Current")
                return true;
           else
                return false;
        }
       
        public bool CheckOverDraft(decimal overdraftLim, decimal balance, decimal amount)
        {
            decimal limit = balance - amount;
            decimal overdraft = overdraftLim + limit;

            if (overdraft >= 0)
                return true;
            else
                return false;

        }

        public bool CheckInternalAccount(int sortcode)
        {
            if (sortcode == 101010)
                return true;
            else
                return false;
        }

    }
}
