using System.Collections.Generic;
using System.Threading.Tasks;
using LDKJ.Dto;

namespace LDKJ.IBLL
{
    public interface IAdminsService
    {
        Task<int> AddAdminsAsync(string account, string password, string nickname, string photo, int rolesId);

        Task<int> ChangePassword(int id,string oldPwd, string newPwd);

        Task<int> ChangeNickName(int id, string newNickName);
        Task<int> ChangePhoto(int id, string newPhoto);

        Task<int> DeleteAdminsAsync(int id);

        Task<List<AdminsDto>> GetDataAsync();

        Task<bool> GetDataByAccountAsync(string account);

        Task<List<AdminsDto>> GetDataByNickNameAsync(string nickname);

        Task<AdminsDto> GetDataById(int id);

        Task<AdminsDto> LoginAsync(string account, string pwd);
    }
}