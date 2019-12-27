using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LDKJ.Model
{
    public class AdminsMenu : BaseEntity
    {
        [Required]
        [StringLength(255)]
        [Column(TypeName = "varchar")]
        [Display(Name = "管理员菜单名称")]
        public string Title { get; set; }

        [Required]
        [StringLength(255)]
        [Column(TypeName = "varchar")]
        [Display(Name = "管理员菜单连接")]
        public string Link { get; set; }

        [Display(Name = "管理员父级菜单编号")]
        public int ParentId { get; set; }

    }
}