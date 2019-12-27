using System;

namespace LDKJ.Dto
{
    public class AdminsMenuDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public int ParentId { get; set; }
        public DateTime  UpdateTime { get; set; } = DateTime.Now;
    }
}