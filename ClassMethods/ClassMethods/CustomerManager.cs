using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethods
{
    internal class CustomerManager
    {
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + customer.Surname + " adlı müşteri eklendi.");
        }
        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + customer.Surname + " adlı müşteri silindi.");
        }
        public void ListCustomer(Customer[] customers)
        {
            Console.WriteLine("Mevcut Müşteriler");
            foreach (var i in customers)
            {
                
                Console.WriteLine(i.Name);
            }
            Console.WriteLine("Listelenen müşteri sayısı: " + customers.Count());

        }
    }
}
