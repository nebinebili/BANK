using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANK
{
    class BankCard
    {
        public BankCard(string bankname, string fullname, string pAN, string pIN, string cVC, DateTime expireDate, double balans)
        {
            Bankname = bankname;
            Fullname = fullname;
            PAN = pAN;
            PIN = pIN;
            CVC = cVC;
            ExpireDate = expireDate;
            Balans = balans;
        }

        public BankCard() { }

        public string Bankname { get; set; }
        public string Fullname { get; set; }
        public string PAN { get; set; }
        public string PIN { get; set; }
        public string CVC { get; set; }
        public DateTime ExpireDate { get; set; }
        public double Balans { get; set; }

       public void ShowBankCard()
       {
            Console.WriteLine($"Bankname->{Bankname}");
            Console.WriteLine($"Fullname->{Fullname}");
            Console.WriteLine($"PAN->{PAN}");
            Console.WriteLine($"PIN->{PIN}");
            Console.WriteLine($"CVC->{CVC}");
            Console.WriteLine($"ExpireDate->{ExpireDate}");
            Console.WriteLine($"Balance->{Balans}");
       }
    }
}
