using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebBanSon.Models.EF
{
    [Table("tb_News")]
    public class News :CommonAbstract
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "bạn không được để trống")]
        [StringLength(150)]
        public String Title { get; set; }
        public String Alias { get; set; }
        public String Description { get; set; }
        [AllowHtml]
        public String Detail { get; set; }
        public String Image { get; set; }
        public int CategoryId { get; set; }
        public string SeoTitle { get; set; }
        public string SeoDescription { get; set; }
        public string SeoKeywords{ get; set; }
        public bool IsActive { get; set; }
        public virtual Category Category { get; set; }
    }
}