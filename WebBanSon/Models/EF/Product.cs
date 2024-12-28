﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebBanSon.Models.EF
{
    [Table("tb_Product")]
    public class Product
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(250)]
        public String Title { get; set; }
        public String Alias { get; set; }
        public String Description { get; set; }
        public String Detail { get; set; }
        public String Image { get; set; }
        public decimal Price { get; set; }
        public decimal PriceSale { get; set; }
        public int Quantity {  get; set; }
        public bool IsHome { get; set; }
        public bool IsSale { get; set; }
        public bool IsFeature { get; set; }
        public bool IsHot { get; set; }
        public int ProductCategoryId { get; set; }
        public string SeoTitle { get; set; }
        public string SeoDescription { get; set; }
        public string SeoKeywords { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }
    }
}