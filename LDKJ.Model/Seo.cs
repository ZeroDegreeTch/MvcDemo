using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LDKJ.Model
{
    public class Seo : BaseEntity
    {
        [Required]
        [StringLength(255)]
        [Column(TypeName = "varchar")]
        [Display(Name = "Seo优化名称")]
        public string Title { get; set; }

        [Required]
        [StringLength(255)]
        [Column(TypeName = "varchar")]
        [Display(Name = "Seo优化关键字")]
        public string Keyword { get; set; }

        [Required]
        [StringLength(255)]
        [Column(TypeName = "varchar")]
        [Display(Name = "Seo优化描述信息")]
        public string Description { get; set; }

        [ForeignKey(nameof(WebMenu))]
        [Display(Name = "网站菜单编号")]
        public int WebMenuId { get; set; }

        public WebMenu WebMenu { get; set; }
    }
}