using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANK
{
    class Bank
    {
        public Client[] Clients { get; set; }

        public Bank(Client[] clients)
        {
            Clients = clients;
        }

        public void showCardBalance(BankCard bankcard)
        {
            Console.WriteLine($"Balance->{bankcard.Balans}");
        }
        public void showCardBalance(string PIN)
        {
            foreach (var client in Clients)
            {
                if (client.bankAccount.PIN == PIN)
                {
                    Console.WriteLine($"Balance->{client.bankAccount.Balans}");
                }
            }
        }

        public void AddClient(Client newclient)
        {
            Client[] newclients = new Client[Clients.Length + 1];
            for (int i = 0; i < Clients.Length; i++)
            {
                newclients[i] = Clients[i];
            }
            newclients[Clients.Length] = newclient;
            Clients = newclients;
            
        }
        public void DeleteByIDClient(int ID)
        {
            for (int i = 0; i < Clients.Length; i++)
            {
                if (Clients[i].Id == ID)
                {
                    Client[] newclients = new Client[Clients.Length - 1];
                    for (int k = 0,j=0; j < Clients.Length; j++)
                    {
                        if (j != i) newclients[k++] = Clients[j];
                    }
                    Clients = newclients;
                }
            }
            
        }
        public void ShowAllClient()
        {
            foreach (var client in Clients)
            {
                client.ShowClient();
            }
        }
    }
}
