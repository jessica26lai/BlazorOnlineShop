﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlazorOnlineShop.Models
{
    public class Product
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public DateTime AddedDate { get; set; }
        public DateTime lastUpdatedDate { get; set; }

        public string? lastUpdatedBy { get; set; }

        public int CategoryID { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal SellingPrice { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Cost { get; set; }

        public string? Description { get; set; }

        public int viewedCount { get; set; }

        public string? imgUrl { get; set; }
    }
}
