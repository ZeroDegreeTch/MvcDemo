using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LDKJ.Model
{
    public class WebMenu : BaseEntity
    {
        [Required]
        [StringLength(255)]
        [Column(TypeName = "varchar")]
        [Display(Name = "网站菜单名称")]
        public string Title { get; set; }

        [Required]
        [StringLength(255)]
        [Column(TypeName = "varchar")]
        [Display(Name = "网站菜单连接")]
        public string Link { get; set; }

        [Display(Name = "网站父级菜单编号")]
        public int ParentId { get; set; }
    }
}