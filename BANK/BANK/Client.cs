using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANK
{
    class Client
    {
        public Client()
        {

        }

        public int Id { get; set; }
        public int age { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public double salary { get; set; }
        public BankCard bankAccount { get; set; }

        public Client(int ıd, int age, string name, string surname, double salary, BankCard bankAccount)
        {
            Id = ıd;
            this.age = age;
            this.name = name;
            this.surname = surname;
            this.salary = salary;
            this.bankAccount = bankAccount;
        }

        public void ShowClient()
        {
            Console.WriteLine("***************************");
            Console.WriteLine($"\nID->{Id}");
            Console.WriteLine($"Age->{age}");
            Console.WriteLine($"Name->{name}");
            Console.WriteLine($"Salary->{salary}");
            Console.WriteLine("\n--- BANKCARD INFO ---");
            bankAccount.ShowBankCard();
        }
    }
}
