using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonDealing.cs
{
    public class OrderEventArgs: EventArgs
    {
        public Order Order { get; set; }
        

    }
}
