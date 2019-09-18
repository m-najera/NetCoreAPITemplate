using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace Training.Data.Models
{
    public class Order
    {
        [Key]
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
        List<OrderProduct> OrderProducts { get; set; }
    }
}
