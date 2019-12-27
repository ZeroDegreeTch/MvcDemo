using System;

namespace LDKJ.Dto
{
    public class SeoDto 
    {
        public int Id { get; set; }
        public int Title { get; set; }
        public int Keyword { get; set; }
        public int Description { get; set; }
        public int WebMenuId { get; set; }
        public DateTime Type { get; set; } = DateTime.Now;

    }
}