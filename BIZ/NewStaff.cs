using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BIZ
{
    public class NewStaff
    {
        AddStaff addS = new AddStaff();
        public string Username { get; set; }

        public string Password { get; set; }

        public NewStaff(string user, string pass)
        {
            Username = user;
            Password = pass;
        }

        public void AddnewStaffToDB()
        {
            addS.AddStaffToDB(Username, Password);
        }

        public bool CheckUsername()
        {
            if (addS.CheckUser(Username))
                return true;
            else
                return false;
        }

        public bool CheckPassword()
        {
            if (addS.CheckPass(Password))
                return true;
            else
                return false;
        }


    }
}
