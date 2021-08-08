using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class TransactionsToDB : DAO
    {

        public void DepositToAcc(int accNumber, string ttype, decimal amount, string ddate, decimal newbalance)
        {
            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspDepositToAcc";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@accNo", accNumber);
            cmd.Parameters.AddWithValue("@ttype", ttype);
            cmd.Parameters.AddWithValue("@amount", amount);
            cmd.Parameters.AddWithValue("@depositdate", ddate);
            cmd.Parameters.AddWithValue("@newbalance", newbalance);
            cmd.ExecuteNonQuery();
            CloseCon();
        }

        public void WithdrawFromAcc(int accNumber, string ttype, decimal amount, string ddate, decimal newbalance)
        {
            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspWithdrawnFromAcc";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@accNo", accNumber);
            cmd.Parameters.AddWithValue("@ttype", ttype);
            cmd.Parameters.AddWithValue("@amount", amount);
            cmd.Parameters.AddWithValue("@withdrawdate", ddate);
            cmd.Parameters.AddWithValue("@newbalance", newbalance);
            cmd.ExecuteNonQuery();
            CloseCon();
        }
        public void TransferToAcc(int hAccNumber, string hName, string description, string ttype, int dsortcode, string dName, int destAccNo, decimal tAmount, string tDate, decimal newBalance)
        {
            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspTransfer";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@accno", hAccNumber);
            cmd.Parameters.AddWithValue("@hname", hName);
            cmd.Parameters.AddWithValue("@description", description);
            cmd.Parameters.AddWithValue("@ttype", ttype);
            cmd.Parameters.AddWithValue("@dsortcode", dsortcode);
            cmd.Parameters.AddWithValue("@dname", dName);
            cmd.Parameters.AddWithValue("@destaccno", destAccNo);
            cmd.Parameters.AddWithValue("@tamount", tAmount);
            cmd.Parameters.AddWithValue("@tdate", tDate);
            cmd.Parameters.AddWithValue("nbalance", newBalance);
            cmd.ExecuteNonQuery();
            CloseCon();
        }
        public void AddToTransaction(int accnumber, string ttype, decimal amount, string trdate, decimal newBalance)
        {
            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspTransaction";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@accno", accnumber);
            cmd.Parameters.AddWithValue("@ttype", ttype);
            cmd.Parameters.AddWithValue("@amount", amount);
            cmd.Parameters.AddWithValue("@trdate", trdate);
            cmd.Parameters.AddWithValue("@newBalance", newBalance);
            cmd.ExecuteNonQuery();
            CloseCon();
        }

        public bool CheckTransferAcc(int accnumber)
        {
            SqlCommand cmd = OpenCon().CreateCommand();
            int rowcount = 1;
            cmd.CommandText = "uspCheckAccNum";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@accnumber", accnumber);

            rowcount = (int)cmd.ExecuteScalar();
            CloseCon();
            return (rowcount == 0);
        }

        public bool CheckTransferStCode(int sortcode)
        {
            SqlCommand cmd = OpenCon().CreateCommand();
            int rowcount = 1;
            cmd.CommandText = "uspCheckSortCode";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@sortcode", sortcode);

            rowcount = (int)cmd.ExecuteScalar();
            CloseCon();
            return (rowcount == 0);
        }

        public void UpdateAccountBalance(int accNumber, decimal balance)
        {
            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspUpdateAccBalance";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@accnumber", accNumber);
            cmd.Parameters.AddWithValue("@balance", balance);
            cmd.ExecuteNonQuery();
            CloseCon();
        }


    }
}
