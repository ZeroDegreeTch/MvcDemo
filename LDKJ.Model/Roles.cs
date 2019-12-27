using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LDKJ.Model
{
    public class Roles : BaseEntity
    {
        [Required]
        [StringLength(255)]
        [Column(TypeName = "varchar")]
        [Display(Name = "权限名称")]
        public string Title { get; set; }
    }
}