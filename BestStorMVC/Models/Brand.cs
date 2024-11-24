﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace BestStorMVC.Models
{
    public class Brand
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; } = "";

        public DateTime CreatedAt { get; set; }
    }
}