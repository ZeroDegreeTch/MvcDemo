using System;

namespace LDKJ.Dto
{
    public class AdminsPermissionDto
    {
        public int Id { get; set; }
        public int RolesId { get; set; }
        public int AdminsMenuId { get; set; }
        public DateTime Type { get; set; } = DateTime.Now;
    }
}