using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebBanSon.Models.EF
{
    [Table("tb_Category")]
    public class Category: CommonAbstract
    {
        public Category() { 
            this.News = new HashSet<News>();
        }
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Tên danh mục không được để trống")]
        [StringLength(150)]
        public String Title { get; set; }
        public String Alias { get; set; }
        public String Description { get; set; }
        [StringLength(250)]
        public String SeoTitle { get; set; }
        [StringLength(150)]
        public String SeoDescription { get; set; }
        public String SeoKeywords { get; set; }
        public bool IsActive { get; set; }
        public int Position { get; set; }

        public ICollection<News> News { get; set; }
        public ICollection<Posts> Posts { get; set; }

    }
}