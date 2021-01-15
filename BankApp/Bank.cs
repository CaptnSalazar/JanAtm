using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Bank

    {
        public string BankName { get; set; }

        public int IfscCode { get; set; }

        public BankAccount1[] _ba;


        public BankAccount1[] BA
        {

            get { return this._ba; }
            set { this._ba = value; }
        }

        public Bank(string bn,int ifsccode,BankAccount1[] b)
        {
            this.BankName = bn;
            this.IfscCode = ifsccode;
            this._ba = b;
        }

        public Boolean Deposit(int accno, double amt)
        {
            Boolean successFlag = false;
            foreach (var a in _ba) {

            if (a.AccountID == accno)
            {
                a.Balance = a.Balance + amt;
                successFlag = true;
                return successFlag;
            }
        }

            return successFlag;

        }

        public Boolean Deposit(string accname, double amt)
        {
            Boolean successFlag = false;
            foreach (var a in _ba)
            {

                if (a.AccountName == accname)
                {
                    a.Balance = a.Balance + amt;
                    successFlag = true;
                    return successFlag;
                }
            }

            return successFlag;

        }

        public Boolean WithDraw(int accno, double amt)
        {
            Boolean successFlag = false;
            foreach (var a in _ba)
            {
                if (a.AccountID == accno)
                {
                    a.Balance = a.Balance - amt;
                    successFlag = true;
                    return successFlag;
                }

            }
            return successFlag;

        }

        public override string ToString()
        {
            string arraval = null;
            foreach(var a in _ba)
            {
                arraval = arraval + a.ToString();
            }
            return string.Format("\n BankName {0} \n ifsccode {1} \n bankdetails {2}", this.BankName, this.IfscCode, arraval);
        }
    }
}
