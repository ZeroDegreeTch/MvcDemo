using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LDKJ.Model
{
    public class Copyright : BaseEntity
    {
        [StringLength(255)]
        [Column(TypeName = "varchar")]
        [Display(Name = "版权名称")]
        public string Title { get; set; }

        [StringLength(2000)]
        [Column(TypeName = "varchar")]
        [Display(Name = "版权描述信息")]
        public string Detail { get; set; }

        [StringLength(255)]
        [Column(TypeName = "varchar")]
        [Display(Name = "版权电子邮件")]
        public string Email { get; set; }

        [StringLength(255)]
        [Column(TypeName = "varchar")]
        [Display(Name = "版权微信号")]
        public string WeChat { get; set; }

        [StringLength(255)]
        [Column(TypeName = "varchar")]
        [Display(Name = "版权Logo图片")]
        public string Logo { get; set; }

        [StringLength(255)]
        [Column(TypeName = "varchar")]
        [Display(Name = "版权图片")]
        public string Images { get; set; }

        [StringLength(255)]
        [Column(TypeName = "varchar")]
        [Display(Name = "版权QQ")]
        public string QQ { get; set; }

        [StringLength(255)]
        [Column(TypeName = "varchar")]
        [Display(Name = "版权QQ1")]
        public string QQ1 { get; set; }

        [StringLength(255)]
        [Column(TypeName = "varchar")]
        [Display(Name = "版权电话")]
        public string Tel { get; set; }

        [StringLength(255)]
        [Column(TypeName = "varchar")]
        [Display(Name = "版权电话1")]
        public string Tel1 { get; set; }

        [StringLength(255)]
        [Column(TypeName = "varchar")]
        [Display(Name = "版权地址")]
        public string Address { get; set; }
    }
}