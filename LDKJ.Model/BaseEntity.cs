using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LDKJ.Model
{
    public class BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "编号")]
        public int Id { get; set; }

        [Display(Name="创建时间")]
        public DateTime CreateTime { get; set; } = DateTime.Now;
        
        [Display(Name = "修改时间")]
        public DateTime UpDateTime { get; set; } = DateTime.Now;

    }
}