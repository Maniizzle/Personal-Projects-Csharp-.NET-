using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonDealing.cs
{
    public delegate  void ProcessOrder(Order order);
    public class Amazon
    {
        public event ProcessOrder ItemOrdered;
       // public event EventHandler<OrderEventArgs> OrderConfirmed;

        List<string> Mystock = new List<string> { "Bread", "Beans", "Akara" };
        

        internal  void AmazonPlaceOrder(Order order)
        {
            foreach (var item in Mystock)
            {
                if (order.Name ==item)
                    ItemOrdered?.Invoke(order);
            }
            
        }

      

        
    }









    

    }
