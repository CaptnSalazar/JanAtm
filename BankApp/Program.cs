using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //BankAccount bankobj = new BankAccount();

            //BankAccount bankobj;
            //bankobj = new BankAccount();
            //bankobj. = 123;
            //bankobj.AccountName = "Abijeet";
            //bankobj.Balance = 3000;

            //bankobj.Deposit();
            //bankobj.Withdraw();
            //bankobj.PrintDetails

            //BankAccount ba = new BankAccount();

            //ba.AccountName = "Shaswat";
            //ba.Balance = 10000;
            //ba.Password = "123welcome";
            //ba.Gender = 'c';
            //ba.AccountNo = 123;
            //  ba.IFSCCode = "dfsdfsd";
            //Console.WriteLine(ba.AccountName+"   "+ba.Balance+" "+ba.IFSCCode+"   "+ba.Gender+""+ba.AccountNo);

          //  BankAccount1 ba = new BankAccount1();
          //// ba.AccountID = 123;
          //  ba.AccountName = "shravya";
          //  ba.Password = "Welcome";
          //  // ba.Balance = 9000;
          //  ba.Gender = 'd';

            // ba.CompanyName = "abc";
            //Console.WriteLine("Account id :" + ba.AccountID+" account name :"+ba.AccountName+"balance:"+ba.Balance+"Gender :"+ba.Gender+"company name"+ba.CompanyName);


            //Console.WriteLine(ba.ToString());

           // BankAccount1 ba2 = new BankAccount1();
           // BankAccount1 ba3 = new BankAccount1();

            //Console.WriteLine(ba2.ToString());
            //Console.WriteLine(ba3.ToString());
            //BankAccount1 ba4 = new BankAccount1("shaswat", 8000, 'm', new DateTime(1990, 01, 01));
            //Console.WriteLine(ba4.ToString());
            BankAccount1 ba5 = new BankAccount1("shaswat", 8000, 'm', new DateTime(1990, 01, 01),"patel road , kolkatta");

            //Console.WriteLine(ba5.ToString());

            BankAccount1[] barray = new BankAccount1[3];

            barray[0] = new BankAccount1();
            barray[1] = new BankAccount1("akhil", 8000, 'm', new DateTime(2000, 01, 01));
            barray[2] = new BankAccount1("spoorty", 8000, 'm', new DateTime(2000, 01, 01), "bengaluru");

            Bank hdfcbank = new Bank("HDFC", 443243242, barray);
            Console.WriteLine(hdfcbank.ToString());
            Console.WriteLine("depositing");
            hdfcbank.Deposit("spoorty", 2000);
            Console.WriteLine(hdfcbank.ToString());
            hdfcbank.WithDraw(1003, 5000);
            // Console.WriteLine(hdfcbank.ToString());

            //SalariedAccount sa = new SalariedAccount();
            //Console.WriteLine(sa.ToString());
            //SalariedAccount sa2 = new SalariedAccount("abc", "gowtham", "9000");
            //Console.WriteLine(sa2.ToString());

            //SalariedAccount sa3 = new SalariedAccount("xyz", "abhijeet", "8000", "abhi", 9000, 'm', new DateTime(2000, 01, 01));
            //Console.WriteLine(sa3.ToString());

            //SalariedAccount sa4 = new SalariedAccount("xyz", "abhijeet", "8000", "abhi", 9000, 'm', new DateTime(2000, 01, 01),"chennai");
            //Console.WriteLine(sa4.ToString());

            //Ameneties a = new Ameneties();
            ////a.RD();
            //a.fd();

            //c c=new c();
            //SavingAccount sa = new SavingAccount();
            //sa.NomineeName = "Ram";
            //sa.officename = "abc";
            //sa.AccountName = "Ram varma";
            //sa.Balance = 9000;

            //Console.WriteLine(sa.GetDetails());
            //p p =new p();
            //BankAccount1 ba = new BankAccount1();
            //ba.AccountName = "sheetal";
            //ba.Balance = 900;
            //Console.WriteLine(ba.GetDetails());

            //p p=nw c();
            int a = 10;
            double b = a;
            BankAccount1 ba = new SalariedAccount();


            ba.AccountName = "sharad";
            
            Console.WriteLine(ba.GetDetails());

            //c c=new p();

            //double d = 99.0;
            //int a1 = d;
           // SalariedAccount s = new BankAccount1();


           
            Console.ReadLine();
        }
    }
}
