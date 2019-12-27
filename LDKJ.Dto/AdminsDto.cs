using System;

namespace LDKJ.Dto
{
    public class AdminsDto
    {
        public int Id { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public string NickName { get; set; }
        public string Photo { get; set; }
        public int RolesId { get; set; }
        public bool IsDisabled { get; set; } = false;
        public DateTime UpdateTime { get; set; } = DateTime.Now;

    }
}