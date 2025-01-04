using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebBanSon.Models.EF
{
    [Table("tb_Posts")]
    public class Posts:CommonAbstract
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(150)] 
        public String Title { get; set; }
        [StringLength(150)]
        public String Alias { get; set; }
        public String Description { get; set; }
        [AllowHtml]
        public String Detail { get; set; }
        [StringLength(250)]
        public String Image { get; set; }
        public int CategoryId { get; set; }
        [StringLength(250)]
        public string SeoTitle { get; set; }
        [StringLength(500)]
        public string SeoDescription { get; set; }
        [StringLength(250)]
        public string SeoKeywords { get; set; }
        public bool IsActive { get; set; }
        public virtual Category Category { get; set; }
    }
}