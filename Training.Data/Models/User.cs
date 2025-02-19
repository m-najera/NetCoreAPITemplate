﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Training.Data.Models
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
    }
}
