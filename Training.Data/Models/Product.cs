using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Training.Data.Models
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int MerchantId { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

        public DTO.Product ToDTO()
        {
            return new DTO.Product
            {
                Id = Id.ToString(),
                Name = Name,
                Description = Description,
                Price = Price
            };
        }

        public Product ToDatabaseModel(DTO.Product p)
        {
            return new Product
            {
                Id = Guid.Parse(p.Id),
                Name = p.Name,
                Description = p.Description,
                Price = p.Price
            };
        }
    }
}
