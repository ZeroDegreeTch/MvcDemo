using LDKJ.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDKJ.IBLL
{
    public interface ICopyrightSerivce
    {
        Task<int> AddCopyrightAsync(string title,string detail,string email,string wechat,string logo,string image,string qq,string qq1,string tel,string tel1,string address);

        Task<int> EditCopyrightAsync(int id, string title, string detail, string email, string wechat, string logo, string image, string qq, string qq1, string tel, string tel1, string address);

        Task<int> DeleteCopyrightAsync(int id);

        Task<List<CopyrightDto>> GetDataAsync();

        Task<CopyrightDto> GetDataByIdAsync(int id);
    }
}
