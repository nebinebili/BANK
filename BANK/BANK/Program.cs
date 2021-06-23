using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANK
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            var cvc = random.Next(100, 999);
            var balanse = random.Next(10, 5000);
            DateTime dt = new DateTime(2021, 06, 01);
            BankCard bankcard1 = new BankCard
            {
                Bankname = "Kapital",
                PAN = "123-345-231",
                PIN = "2021",
                Fullname = "NebiliNebi",
                ExpireDate = dt,
                CVC = cvc.ToString(),
                Balans = balanse
            };

            Client client1 = new Client
            {
                age = 20,
                Id = 1,
                name = "Nebi",
                surname = "Nebili",
                salary = 2103.45,
                bankAccount = bankcard1
            };

            var cvc2 = random.Next(100, 999);
            var balanse2 = random.Next(10, 5000);
            DateTime dt2 = new DateTime(2021, 06, 01);
            BankCard bankcard2 = new BankCard
            {
                Bankname = "Kapital",
                PAN = "123-452-102",
                PIN = "6666",
                Fullname = "IdayetovKenan",
                ExpireDate = dt2,
                CVC = cvc2.ToString(),
                Balans = balanse2
            };

            Client client2 = new Client
            {
                age = 21,
                Id = 2,
                name = "Kenan",
                surname = "Idayetov",
                salary = 1223,
                bankAccount = bankcard2
            };

            Client[] clients = new Client[2]
            {
                 client1,client2
            };

            Bank KapitalBank = new Bank(clients);

            // Balance methods
            //KapitalBank.showCardBalance(bankcard2);
            //KapitalBank.showCardBalance("6666");

            var cvc3 = random.Next(100, 999);
            var balanse3 = random.Next(10, 5000);
            DateTime dt3 = new DateTime(2021, 06, 01);
            BankCard bankcard3 = new BankCard
            {
                Bankname = "Kapital",
                PAN = "123-567-345",
                PIN = "9900",
                Fullname = "EmiraslanEliyev",
                ExpireDate = dt3,
                CVC = cvc3.ToString(),
                Balans = balanse3
            };

            Client client3 = new Client
            {
                age = 27,
                Id = 3,
                name = "Emiraslam",
                surname = "Eliyev",
                salary = 2387,
                bankAccount = bankcard3
            };

            // AddClient method
            KapitalBank.AddClient(client3);
            // Delete by Id Client method
            KapitalBank.DeleteByIDClient(3);

            KapitalBank.ShowAllClient();

            Console.ReadLine();
        }
    }
}
