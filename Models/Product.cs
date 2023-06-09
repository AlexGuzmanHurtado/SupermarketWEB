﻿using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace SupermarketWEB.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

		[Column(TypeName = "decimal(6,2)")]

		public decimal Price { get; set; }

        public int Stock { get; set; }

        public int CategoryId { get; set; }

        public ICollection<Category>? categories { get; set; }
    }
}
