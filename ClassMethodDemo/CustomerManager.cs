using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("-----Müşteri Kaydedildi-----");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.CustomerName);
            Console.WriteLine(customer.CustomerLastName);
            Console.WriteLine("");


        }

        public void List(Customer customer)
        {
            Console.WriteLine("Müşteri Id: " + customer.Id);
            Console.WriteLine("Müşteri Adı: " + customer.CustomerName);
            Console.WriteLine("Müşteri Soyadı: " + customer.CustomerLastName);
            Console.WriteLine("");
            
        }


        public void Delete(Customer customer)
        {
            Console.WriteLine("-----Müşteri Silindi-----");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.CustomerName);
            Console.WriteLine(customer.CustomerLastName);
            Console.WriteLine("");

        }

        
    }
}

