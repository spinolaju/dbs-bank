using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections.Specialized;
using DAL;

namespace BIZ
{
    public class BankAccount
    {
        private decimal balance;

        private int initialBal;
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string AccountType { get; set; }

        public readonly int SortCode = int.Parse(ConfigurationManager.AppSettings.Get("SortCode"));

        public decimal Balance
        {
            get
            {
                return initialBal + balance;
            }

            set
            {
                if (value >= 0)
                    balance = value;

                else
                    throw new ArgumentOutOfRangeException();

            }
        }
        AddAccount aacc = new AddAccount();
        public decimal OverdraftLimit { get; set; } = 0;

        public BankAccount()
        {

        }
     
        public BankAccount(decimal bal, string firstName, string surname, string email, string phone, string addr1, string addr2, string city, string county, string accType, decimal overdraftLim)
            
        {
            Balance = bal;
            FirstName = firstName;
            Surname = surname;
            Email = email;
            Phone = phone;
            Address1 = addr1;
            Address2 = addr2;
            City = city;
            County = county;
            AccountType = accType;
            OverdraftLimit = overdraftLim;

        }

        public void AddNewAccDB()
        {
            aacc.AddStuToDB(Balance, FirstName, Surname, Email, Phone, Address1, Address2, City, County, AccountType, OverdraftLimit, SortCode);
        }

    }
}
