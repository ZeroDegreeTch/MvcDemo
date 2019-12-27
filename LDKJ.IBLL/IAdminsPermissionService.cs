using System.Collections.Generic;
using System.Threading.Tasks;
using LDKJ.Dto;

namespace LDKJ.IBLL
{
    public interface IAdminsPermissionService
    {
        Task<int> AddAdminsPermissionAsync(int rolesId, int adminsMenuId);

        Task<int> EditAdminsPermissionAsync(int id,int rolesId, int adminsMenuId);

        Task<int> DeleteAdminsPermissionAsync(int id);

        Task<List<AdminsPermissionDto>> GetData();

        Task<List<AdminsPermissionDto>> GetDataByRolesId(int rolesId);

        Task<AdminsPermissionDto> GetDataById(int id);

    }
}