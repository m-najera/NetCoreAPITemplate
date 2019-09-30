using System;
using System.Collections.Generic;
using System.Text;

namespace Training.DTO
{
    public class OrderItems
    {
        public Guid OrderID { get; set; }
        public Guid ProductID { get; set; }
        public int Quantity { get; set; }
    }
}
