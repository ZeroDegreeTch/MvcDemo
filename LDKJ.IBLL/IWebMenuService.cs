using System.Collections.Generic;
using System.Threading.Tasks;
using LDKJ.Dto;

namespace LDKJ.IBLL
{
    public interface IWebMenuService
    {
        Task<int> AddWebMenuAsync(string title, string link, int parentId);
        Task<int> EditWebMenuAsync(int id, string title, string link, int parentId);
        Task<int> DeleteWebMenuAsync(int id);

        Task<List<WebMenuDto>> GetDataAsync();
        Task<List<WebMenuDto>> GetDataByTitleAsync(string title);
        Task<WebMenuDto> GetDataByIdAsync(int id);
    }
}