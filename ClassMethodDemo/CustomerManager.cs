using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public List<Customer> customers = new List<Customer>();
        
        public void Add(Customer customer)
        {
            customers.Add(customer);
            Console.WriteLine("***-----Müşteri Kaydedildi-----***");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.CustomerName);
            Console.WriteLine(customer.CustomerLastName);
            Console.WriteLine();


        }

        public void List()
        {
            Console.WriteLine( "*----Müşteri Listesi----*" );
            
            Console.WriteLine();
            
            foreach (Customer customer in customers)
            {
                Console.WriteLine("Müşteri Id: " + customer.Id);
                Console.WriteLine("Müşteri Adı: " + customer.CustomerName);
                Console.WriteLine("Müşteri Soyadı: " + customer.CustomerLastName);
                Console.WriteLine("");
            }

            Console.WriteLine("--------------------------");
        }


        public void Delete(Customer customer)
        {
            customers.Remove(customer);
            Console.WriteLine("***-----Müşteri Silindi-----***");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.CustomerName);
            Console.WriteLine(customer.CustomerLastName);
            Console.WriteLine();

        }

        
    }
}

