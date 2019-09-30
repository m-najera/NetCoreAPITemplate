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
        public String Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public ICollection<OrderProduct> OrderProducts { get; set; }

        public DTO.Order ToDTO()
        {
            return new DTO.Order
            {
                Id = Id,
                Status = Status,
                CreatedAt = CreatedAt
            };
        }
    }
}
