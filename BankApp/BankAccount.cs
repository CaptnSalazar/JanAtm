//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BankApp
//{
//    class BankAccount
//    {
//       // private int _accountNo;
//        private string _accountName;

//        public string AccountName
//        {
//            get { return this._accountName; }
//            set { this._accountName = value; }
//        }
//        private double _balance;

//        public double Balance
//        {
//            get { return this._balance; }
//            set { this._balance = value; }
//        }

//        //private int _accountNo;
        
//            public string Bracnch { get; set; }
//            public int AccountNo { get; set; }


//        //public int GetAccountNo()
//        //{
//        //    return this._accountNo;
//        //}

//        //public void SetAccountNo(int accn)
//        //{
//        //    this._accountNo = accn;
//        //}


//        private string _password;

//        public string Password
//        {
//            set { this._password = value; }

//        }

//        private string _ifsccode="fdjlfjdsfds";

//        public string IFSCCode
//        {

//            get { return _ifsccode; }
//        }


//        private char _gender;

//        public char Gender
//        {


//            get { return this._gender; }

//            set
//            {
//                if (value.Equals('m') || value.Equals('M'))
//                {
//                    this._gender = 'M';
//                }
//                else if (value.Equals('f') || value.Equals('F'))
//                {
//                    this._gender = 'F';
//                }
//                else
//                {
//                    this._gender = 'x';
//                }
//            }
//        }


//        public void Deposit()
//        {
//            Console.WriteLine("enter the amount to deposit");
//        }

//        public void Withdraw()
//        {
//            Console.WriteLine("withdrawing the amount");
//        }

//        public void PrintDetails()
//        {
//         //   Console.WriteLine("Account no {0} Account name {1} Balance {2} ", this.AccountNo, this.AccountName, this.Balance);
//        }
//    }
//}
