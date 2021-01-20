using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() ;
            customer1.CustomerName = "Onur";
            customer1.CustomerLastName = "Çetinkaya";
            customer1.Id = 101;

            Customer customer2 = new Customer();
            customer2.CustomerName = "Arif";
            customer2.CustomerLastName = "Solak";
            customer2.Id = 102;

            Customer customer3 = new Customer();
            customer3.CustomerName = "Rıfkı";
            customer3.CustomerLastName = "Piliç";
            customer3.Id = 103;

            Customer customer4 = new Customer();
            customer4.CustomerName = "Feyzullah";
            customer4.CustomerLastName = "Küçük";
            customer4.Id = 104;

            Customer customer5 = new Customer();
            customer5.CustomerName = "Samet";
            customer5.CustomerLastName = "İlker";
            customer5.Id = 105;

            Customer[] customers = new Customer[] { customer1,customer2,customer3,customer4,customer5};

            CustomerManager customerManager = new CustomerManager();

            foreach (var customer in customers)
            {
                customerManager.Add(customer);
            }

           
            customerManager.List();
            

            foreach (var customer in customers)
            { 
                customerManager.Delete(customer);
            }

            customerManager.List();
            customerManager.Add(customer1);
            customerManager.Add(customer4);
            customerManager.List();

            
            
            
            










        }
    }
}
