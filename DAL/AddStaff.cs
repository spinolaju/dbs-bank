using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AddStaff : DAO
    {

        public void AddStaffToDB(string user, string pass)
        {
            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspAddStaff";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@username", user);
            cmd.Parameters.AddWithValue("@password", pass);
            cmd.ExecuteNonQuery();
            CloseCon();
        }

        public bool CheckUser(string username)
        {
            SqlCommand cmd = OpenCon().CreateCommand();
            int rowcount = 1;
            cmd.CommandText = "uspCheckUsername";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@username", username);

            rowcount = (int)cmd.ExecuteScalar();
            CloseCon();
            return (rowcount == 0);
        }

        public bool CheckPass(string password)
        {
            SqlCommand cmd = OpenCon().CreateCommand();
            int rowcount = 1;
            cmd.CommandText = "uspCheckPass";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@password", password);

            rowcount = (int)cmd.ExecuteScalar();
            CloseCon();
            return (rowcount == 0);
        }


    }
}
