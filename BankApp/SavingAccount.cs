using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class SavingAccount:SalariedAccount
    {
        public string AccountType { get; set; }

        public string NomineeName = "narmadha";

        public new string GetDetails()
        {
            return string.Format("accont name {0} balance{1} office name {2} nominee name {3}", this.AccountName, this.Balance,this.officename,this.NomineeName);
        }
    }
}
