﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShop.Mvc.Models
{
    public class OrderLine
    {
        public virtual Book Book { get; set; }

        [Required]
        [ForeignKey(nameof(Models.Book))]
        [Column(Order = 0)]
        public int BookId { get; set; }

        public virtual Order Order { get; set; }

        [Required]
        [ForeignKey(nameof(Models.Order))]
        [Column(Order = 1)]
        public int OrderId { get; set; }

        [Range(1, 5)]
        [Required]
        public int Quantity { get; set; }

        public decimal Price => Quantity * Book.Price;        
    }
}
