using LDKJ.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDKJ.IBLL
{
    public interface ISeoService
    {
        Task<int> AddSeoAsync(string title, string keyword, string description, int webmenuId);
        Task<int> EditSeoAsync(int id,string title, string keyword, string description, int webmenuId);
        Task<int> DeleteSeoAsync(int id);
        Task<List<SeoDto>> GetDataAsync();
        Task<List<SeoDto>> GetDataByTitleAsync(string title);
        Task<SeoDto> GetDataByIdAsync(int id);

    }
}
