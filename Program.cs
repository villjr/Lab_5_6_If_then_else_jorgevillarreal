using System;
using System.Collections.Generic;

namespace Lab_5_6_If_then_jorgevillarreal
{
    class Program
    {
        struct Customer
        {
            public string first_name;
            public string last_name;
            public int age;
            public bool membership_status;
        }



        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            Customer customer2 = new Customer();
            Customer customer3 = new Customer();

            customer1.first_name = "John";
            customer1.last_name = "Doe";
            customer1.age = 17;
            customer1.membership_status = false;

            customer2.first_name = "Davy";
            customer2.last_name = "Jones";
            customer2.age = 56;
            customer2.membership_status = false;

            customer3.first_name = "Grace";
            customer3.last_name = "Jones";
            customer3.age = 78;
            customer3.membership_status = true;

            Customer[] allCustomers = { customer1, customer2, customer3 };

            for (int i = 0; i < allCustomers.Length; i++)
            {
                if (allCustomers[i].age < 21)
                {
                    Console.WriteLine(allCustomers[i].first_name + " " + allCustomers[i].last_name + " is not allowed to place an order");
                }
                else
                {
                    Console.WriteLine(allCustomers[i].first_name + " " + allCustomers[i].last_name + " can place an order");
                }

                if (allCustomers[i].membership_status == true)
                {
                    Console.WriteLine(allCustomers[i].first_name + " " + allCustomers[i].last_name + " is a premium member.");
                }
                else
                {
                    Console.WriteLine(allCustomers[i].first_name + " " + allCustomers[i].last_name + " is not a premium" +
                        " member.");
                }
            }
        }
    }
}
