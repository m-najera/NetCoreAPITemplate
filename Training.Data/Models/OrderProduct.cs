using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Training.Data.Models
{
    public class OrderProduct
    {
        [Key]
        public Guid Id { get; set; }
        public int Quantity { get; set; }
        public Guid ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }

    }
}
