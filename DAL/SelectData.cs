using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class SelectData : DAO
    {
        SqlDataReader dreader;
        SqlDataAdapter dAdpt;
        DataTable dtable;
        
        public List<string> PComboBox()
        {
            List<string> cbo = new List<string>();
            string acc = "No Accounts";
            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspAllAccount";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            dreader = cmd.ExecuteReader();
            while (dreader.Read())
            {
                acc = dreader["AccountNumber"].ToString();
                cbo.Add(acc);
            }
            CloseCon();

            return cbo;
        }

        public string PopulateFields(string accNo, string field)
        {
            SqlCommand cmd = OpenCon().CreateCommand();
            string fieldSelected = " ";
            
            cmd.CommandText = "uspSelectByAccNum";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@accNo", accNo);

            dreader = cmd.ExecuteReader();
            while (dreader.Read())
            {
                fieldSelected = dreader[field].ToString();

            }
            CloseCon();
            return fieldSelected;
            
        }

        public void UpdateBankAcc(string phone, string email, string add1, string add2, string city, string county, string accNo)
        {
            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspUpdateAcc";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@accNo", accNo);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@add1", add1);
            cmd.Parameters.AddWithValue("@add2", add2);
            cmd.Parameters.AddWithValue("@city", city);
            cmd.Parameters.AddWithValue("@county", county);

            cmd.ExecuteNonQuery();

            CloseCon();


        }

        public DataTable SelectAllTransaction()
        {
            dAdpt = new SqlDataAdapter();
            dtable = new DataTable();

            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspAllTransaction";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            dAdpt.SelectCommand = cmd;
            dAdpt.Fill(dtable);

            return dtable;
        }

        public DataTable SelectTransactionByAcc(int accNo)
        {
            dAdpt = new SqlDataAdapter();
            dtable = new DataTable();

            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspTransactionByAcc";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@accNo", accNo);
            dAdpt.SelectCommand = cmd;
            dAdpt.Fill(dtable);

            return dtable;
        }


        public DataTable SelectAllAccounts()
        {
            dAdpt = new SqlDataAdapter();
            dtable = new DataTable();

            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspAllAccount";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            dAdpt.SelectCommand = cmd;
            dAdpt.Fill(dtable);

            return dtable;
        }


    }
}
