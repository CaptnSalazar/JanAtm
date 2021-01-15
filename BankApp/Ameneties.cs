using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
  public  partial  class Ameneties
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int AccountType { get; set; }

        public void fd()
        {
            Console.WriteLine("applying for fd");
            RD();
        }

         partial void RD();
    }


}
