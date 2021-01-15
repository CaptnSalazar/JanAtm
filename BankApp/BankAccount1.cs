using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class BankAccount1
    {
        private int _accountID;

        public virtual string GetDetails()
        {
            return string.Format("accont name {0} balance{1}", this._accountName, this.Balance);
        }
        public int AccountID
        {


            get { return this._accountID; }
          
        }

        private string _accountName;

        public string AccountName
        {
            get { return this._accountName; }
            set { this._accountName = value; }
        }

        private string _password;


        public string Password
        {
         
            set { this._password = value; }
        }

        private double _balance=10000;

        public double Balance
        {
            get { return this._balance; }
            set { this._balance = value; }
            
        }

        private char _gender;


        public char Gender
        {
            get { return this._gender; }
            set
            {
                if (value.Equals('m') || value.Equals('M'))
                {
                    this._gender = 'M';
                }
                else if (value.Equals('f') || value.Equals('F'))
                {
                    this._gender = 'F';
                }
                else
                {
                    this._gender = 'x';
                }
            }
        }

      
        public string Address
        {
            get;
            set;
        }

        // auto implemented propery for companyname

        public string CompanyName { get; set; }

        public override string ToString()
        {
            return string.Format(" \n account name :{0}\n accound id {1} \n address {2} \n gender {3} \n balance {4}", this._accountName, this._accountID, this.Address, this._gender, this.Balance);
        }

        public DateTime Doj { get; set; }

        private static int assignedno = 1001;
        public BankAccount1()
        {
            assignedno++;
            this._accountID = this._accountID + assignedno;
        }

       public BankAccount1(string an,double balance,char g,DateTime d)
        {
            assignedno++;
            this._accountID = this._accountID + assignedno;
            this._accountName = an;
            this._balance = balance;
            this._gender = g;
            this.Doj = d;

        }

        public BankAccount1(string an, double balance, char g, DateTime d,string add)
        {
            assignedno++;
            this._accountID = this._accountID + assignedno;
            this._accountName = an;
            this._balance = balance;
            this._gender = g;
            this.Doj = d;
            this.Address = add;

        }


    }
}
