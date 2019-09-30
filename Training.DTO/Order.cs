using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Training.DTO
{
    public class Order
    {
        public Guid Id { get; set; }
        public Guid User_Id {get; set;}
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
