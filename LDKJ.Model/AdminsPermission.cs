using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LDKJ.Model
{
    public class AdminsPermission : BaseEntity
    {
        [ForeignKey(nameof(Roles))]
        [Display(Name = "权限编号")]
        public int RolesId { get; set; }

        public Roles Roles { get; set; }

        [ForeignKey(nameof(AdminsMenu))]
        [Display(Name = "管理员菜单编号")]
        public int AdminsMenuId { get; set; }
        public AdminsMenu AdminsMenu { get; set; }

    }
}