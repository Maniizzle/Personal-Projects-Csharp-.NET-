using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonDealing.cs
{

    public class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public Order Order { get; set; }



        public void InformCustomer(Order order)
        {
            Console.WriteLine($"{order.Name} has been Placed");
        }

        public void PlaceOrder(Customer customer)
        {
            Amazon amazon = new Amazon();
            amazon.ItemOrdered += InformCustomer;
            amazon.AmazonPlaceOrder(customer.Order);
        }

    }


    public class Order
    {
        public string Name { get; set; }

    }
}
