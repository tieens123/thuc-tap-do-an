using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebBanSon.Models.EF
{
    [Table("tb_Adv")]
    public class Adv : CommonAbstract
    {
        [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public String Title { get; set; }
        [StringLength(500)]
        public String Description { get; set; }
        [StringLength(500)]
        public String Image { get; set; }
        [StringLength(500)]
        public String Link { get; set; }
        public int Type { get; set; }
    }
}