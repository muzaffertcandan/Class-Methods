using System;

namespace ClassMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Name = "Ahmet";
            customer1.Surname = "Yılmaz";
            customer1.Age = 33;
            customer1.Id = 1;

            Customer customer2 = new Customer();
            customer2.Name = "Efe";
            customer2.Surname = "Yıldırım";
            customer2.Age = 25;
            customer2.Id = 2;

            Customer customer3 = new Customer();
            customer3.Name = "Ata";
            customer3.Surname = "Kurt";
            customer3.Age = 25;
            customer3.Id = 2;

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };
            
            CustomerManager customerManager = new CustomerManager();

            customerManager.AddCustomer(customer1);
            customerManager.AddCustomer(customer2);

            customerManager.DeleteCustomer(customer3);
            customerManager.ListCustomer(customers);
        }
    }
}
