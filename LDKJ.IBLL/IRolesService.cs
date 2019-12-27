using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LDKJ.Dto;

namespace LDKJ.IBLL
{
    public interface IRolesService
    {

        Task<int> AddRolesAsync(string title);
        Task<int> EditRolesAsync(int id,string title); 
        Task<int> DeleteRolesAsync(int id);

        Task<List<RolesDto>> GetDataAsync();
        Task<List<RolesDto>> GetDataByTitleAsync(string title);
        Task<RolesDto> GetDataByIdAsync(int id);
    }
}
