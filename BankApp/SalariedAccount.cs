using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class SalariedAccount : BankAccount1
    {
        public string officename="ABC";
        private string empno;
        private string bonus;

        public SalariedAccount():base()
        {

        }

        public SalariedAccount(string on,string en,string bonus):base()
        {
            this.officename = on;
            this.empno = en;
            this.bonus = bonus;

        }


        //SalariedAccount sa3 = new SalariedAccount("xyz", "abhijeet", "8000", "abhi", 9000, 'm', new DateTime(2000, 01, 01));

            public SalariedAccount(string on,string en,string bonus,string aaccn,double balance,char g,DateTime d):base(aaccn,balance,g,d)
        {
            this.officename = on;
            this.empno = en;
            this.bonus = bonus;
            //base.AccountName = AccountName;
            //base.Balance = balance;
            //base.Doj = d;
            //base.Gender = g;
        }
        public SalariedAccount(string on, string en, string bonus, string aaccn, double balance, char g, DateTime d,string address) : base(aaccn, balance, g, d,address)
        {
            this.officename = on;
            this.empno = en;
            this.bonus = bonus;
            //base.AccountName = AccountName;
            //base.Balance = balance;
            //base.Doj = d;
            //base.Gender = g;
        }
        public override string ToString()
        {
            return string.Format("\n officename {0} \n empno {1} \n bonus{2},\n accnoid{3},\n accname{4} balance {5}", this.officename, this.empno, this.bonus, this.AccountID, this.AccountName, this.Balance, this.Gender);
        }

        public override  string GetDetails()
        {
            
            return string.Format("accont name {0} balance{1} office name {2}", this.AccountName, this.Balance,this.officename);
        }
    }
}
