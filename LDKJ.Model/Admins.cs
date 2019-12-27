using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LDKJ.Model
{
    public class Admins : BaseEntity
    {
        [Required]
        [StringLength(255)]
        [Column(TypeName = "varchar")]
        [Display(Name = "管理员账号")]
        public string Account { get; set; }

        [Required]
        [StringLength(255)]
        [Column(TypeName = "varchar")]
        [Display(Name = "管理员密码")]
        public string Password { get; set; }

        [Required]
        [StringLength(255)]
        [Column(TypeName = "varchar")]
        [Display(Name = "管理员昵称")]
        public string NickName { get; set; }

        [Required]
        [StringLength(255)]
        [Column(TypeName = "varchar")]
        [Display(Name = "管理员头像")]
        public string Photo { get; set; }

        [ForeignKey(nameof(Roles))]
        [Display(Name = "管理员权限")]
        public int RolesId { get; set; }

        public Roles Roles { get; set; }

        [Display(Name = "是否禁用")]
        public bool IsDisabled { get; set; } = false;
    }
}