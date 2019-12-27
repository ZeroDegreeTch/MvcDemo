using System;

namespace LDKJ.Dto
{
    public class RolesDto
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime UpdateTime { get; set; } = DateTime.Now;
    }
}
