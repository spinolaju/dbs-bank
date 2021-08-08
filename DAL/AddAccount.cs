using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class AddAccount : DAO
    {
        
        public void AddStuToDB(decimal bal, string firstName, string surname, string email, string phone, string addr1, string addr2, string city, string county, string accType, decimal overdraftLim, int sortCode)
        {
            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspAddAcc";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@fn", firstName);
            cmd.Parameters.AddWithValue("@surn", surname);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@add1", addr1);
            cmd.Parameters.AddWithValue("@add2", addr2);
            cmd.Parameters.AddWithValue("@city", city);
            cmd.Parameters.AddWithValue("@county", county);
            cmd.Parameters.AddWithValue("@acctype", accType);
            cmd.Parameters.AddWithValue("@sortcode", sortCode);
            cmd.Parameters.AddWithValue("@bal", bal);
            cmd.Parameters.AddWithValue("@overdraft", overdraftLim);

            cmd.ExecuteNonQuery();
            CloseCon();
        }
    }
}
