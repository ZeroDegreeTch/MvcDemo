using LDKJ.Dto;
using LDKJ.IBLL;
using LDKJ.IDAL;
using LDKJ.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDKJ.BLL
{
    public class AdminsService : IAdminsService
    {
        private IAdminsDal _adminsDal;
        public AdminsService(IAdminsDal adminsDal)
        {
            this._adminsDal = adminsDal;
        }


        public async Task<int> AddAdminsAsync(string account, string password, string nickname, string photo, int rolesId)
        {
            return await _adminsDal.AddAsync(new Admins()
            {
                Account = account,
                Password = password,
                NickName = nickname,
                Photo = photo,
                RolesId = rolesId
            });
        }

        public async Task<int> ChangeNickName(int id, string newNickName)
        {
            var data = await _adminsDal.GetDataById(id);
            if (data != null)
            {
                data.NickName = newNickName;
                return await _adminsDal.EditAsync(data);
            }
            else 
            {
                return -1;
            }
        }

        public async Task<int> ChangePassword(int id, string oldPwd, string newPwd)
        {
            var data = await _adminsDal.GetDataById(id);
            if (data != null)
            {
                if (data.Password.Equals(oldPwd))
                {
                    data.Password = newPwd;
                    return await _adminsDal.EditAsync(data);
                }
                else
                {
                    return -2;
                }
            }
            else 
            {
                return -1;
            }
        }

        public async Task<int> ChangePhoto(int id, string newPhoto)
        {
            var data = await _adminsDal.GetDataById(id);
            if (data != null)
            {
                data.Photo = newPhoto;
                return await _adminsDal.EditAsync(data);
            }
            else 
            {
                return -1;
            }
        }

        public async Task<int> DeleteAdminsAsync(int id)
        {
            var data = await _adminsDal.GetDataById(id);

            if (data != null)
            {
                return await _adminsDal.DeleteAsync(data);
            }
            else 
            {
                return -1;
            }

        }

        public async Task<List<AdminsDto>> GetDataAsync()
        {
            return await _adminsDal.GetData().Select(a => new AdminsDto()
            {
                Id = a.Id,
                Account = a.Account,
                Password = a.Password,
                NickName = a.NickName ,
                Photo = a.Photo,
                IsDisabled = a.IsDisabled,
                RolesId = a.RolesId,
                UpdateTime = a.UpDateTime
            }).ToListAsync();
        }

        public async Task<bool> GetDataByAccountAsync(string account)
        {
            var data = await _adminsDal.GetDataByChoose(a => a.Account.Equals(account)).ToListAsync();

            return data.Count > 0;
        }

        public async Task<AdminsDto> GetDataById(int id)
        {
            var data = await _adminsDal.GetDataById(id);
            if (data != null)
            {
                return new AdminsDto()
                {
                    Id = data.Id,
                    Account = data.Account,
                    Password = data.Password,
                    NickName = data.NickName,
                    Photo = data.Photo,
                    IsDisabled = data.IsDisabled,
                    RolesId = data.RolesId,
                    UpdateTime = data.UpDateTime
                };
            }
            else 
            {
                return null;
            }
        }

        public async Task<List<AdminsDto>> GetDataByNickNameAsync(string nickname)
        {
            return await _adminsDal.GetDataByChoose(a => a.NickName.Contains(nickname)).Select(a => new AdminsDto()
            {
                Id = a.Id,
                Account = a.Account,
                Password = a.Password,
                NickName = a.NickName,
                Photo = a.Photo,
                IsDisabled = a.IsDisabled,
                RolesId = a.RolesId,
                UpdateTime = a.UpDateTime
            }).ToListAsync();
        }

        public async Task<AdminsDto> LoginAsync(string account, string pwd)
        {
            return await _adminsDal.GetDataByChoose(
                    a => a.Account.Equals(account) && a.Password.Equals(pwd)).Select(
                    a => new AdminsDto() {
                        Id = a.Id,
                        Account = a.Account,
                        Password = a.Password,
                        NickName = a.NickName,
                        Photo = a.Photo,
                        IsDisabled = a.IsDisabled,
                        RolesId = a.RolesId,
                        UpdateTime = a.UpDateTime
                    } ).FirstOrDefaultAsync();
        }
    }
}
