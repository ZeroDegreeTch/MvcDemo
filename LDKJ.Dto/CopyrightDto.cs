using System;

namespace LDKJ.Dto
{
    public class CopyrightDto
    {
        public int Id { get; set; }
        public string Title { get; set; }


        public string Detail { get; set; }


        public string Email { get; set; }


        public string WeChat { get; set; }

        public string Logo { get; set; }


        public string Images { get; set; }


        public string QQ { get; set; }


        public string QQ1 { get; set; }


        public string Tel { get; set; }


        public string Tel1 { get; set; }

        public string Address { get; set; }

        public DateTime  UpdateTime { get; set; } = DateTime.Now;
    }
}