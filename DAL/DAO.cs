﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAO
    {
        SqlConnection con;

        public DAO()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["BankingApp"].ConnectionString);
        }

        public SqlConnection OpenCon()
        {
            if (con.State == ConnectionState.Closed || con.State == ConnectionState.Broken)
            {
                con.Open();
            }

            return con;
        }

        public void CloseCon()
        {
            if (con != null)
            {
                if (con.State == ConnectionState.Open)
                { con.Close(); }
            }
        }



    }
}
