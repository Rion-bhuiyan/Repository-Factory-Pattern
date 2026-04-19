using ex_2_RepositoryFactoryproject.Model;
using ex_2_RepositoryFactoryproject.Model.Repostitories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ex_2_RepositoryFactoryproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Displayoption();
            Console.ReadKey();
        }
        public static void Displayoption()
        {
            Console.WriteLine("1. Show All Client");
            Console.WriteLine("2. Insert Client");
            Console.WriteLine("3. Update Client");
            Console.WriteLine("4. Delete Client");

            var index=int.Parse(Console.ReadLine());
            show(index);
        }

        private static void show(int index)
        {
            ClientRepo clientRepo = new ClientRepo();
            //Index 1 for get all client
            if (index == 1)
            {
                var clientList = clientRepo.GetAll();
                if (clientList.Count() == 0)
                {
                    Console.WriteLine("=============================");
                    Console.WriteLine("No item fount in the list!!!");
                    Console.WriteLine("=============================");
                    Displayoption();
                }
                else
                {
                    foreach (var item in clientRepo.GetAll())
                    {
                        Console.WriteLine($"Client Id:{item.ClientID},Name:{item.ClientName},Age{item.Age}");
                    }
                    Console.WriteLine("=============================");
                    Displayoption();
                }

            }
            else if (index == 2)//for insert
            {
                Console.WriteLine("=============================");
                Console.Write("Name:");
                string name = Console.ReadLine();
                Console.Write("Age:");
                int age = int.Parse(Console.ReadLine());
                int maxId = clientRepo.GetAll().Any() ? clientRepo.GetAll().Max(x => x.ClientID) : 0;
                Client client = new Client()
                {
                    ClientID = maxId + 1,
                    ClientName = name,
                    Age = age
                };
                clientRepo.Insert(client);
                Console.WriteLine("Data inserted succesfully!");
                Console.WriteLine("=============================");
                Displayoption();

            }
            else if (index == 3) //for update
            {
                Console.WriteLine("=============================");
                Console.Write("Entry Client Id to update:");
                int id = int.Parse(Console.ReadLine());
                var _client = clientRepo.GetByID(id);
                if (_client == null)
                {
                    Console.WriteLine("=============================");
                    Console.WriteLine("Client id is invalid!!!");
                    Console.WriteLine("=============================");
                    Displayoption();
                }
                else
                {
                    Console.WriteLine($"Update info for client Id:{id}");
                    Console.WriteLine("=============================");
                    Console.Write("Name:");
                    string name = Console.ReadLine();
                    Console.Write("Age:");
                    int age = int.Parse(Console.ReadLine());
                    Client client = new Client()
                    {
                        ClientID = id,
                        ClientName = name,
                        Age = age
                    };
                    clientRepo.Update(client);
                    Console.WriteLine("Data updated succesfully!");
                    Console.WriteLine("=============================");
                    Displayoption();
                }
            }
            else if (index == 4) //for Delete
            {

            }
            


        }


    }
}
