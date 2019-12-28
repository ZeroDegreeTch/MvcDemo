using LDKJ.Dto;
using LDKJ.IBLL;
using LDKJ.IDAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDKJ.BLL
{
    public class AdminsMenuService : IAdminsMenuService
    {
        private IAdminsMenuDal _adminsMenuDal;

        public AdminsMenuService(IAdminsMenuDal adminsMenuDal)
        {
            this._adminsMenuDal = adminsMenuDal;
        }

        public async Task<int> AddAdminsMenuAsync(string title, string link, int parentId)
        {
            return await _adminsMenuDal.AddAsync(new Model.AdminsMenu()
            {
                Title = title,
                Link = link,
                ParentId = parentId
            }); 
        }

        public async Task<int> DeleteAdminsMenuAsync(int id)
        {
            var data = await _adminsMenuDal.GetDataById(id);
            if (data != null)
            {
                return await _adminsMenuDal.DeleteAsync(data);
            }
            else 
            {
                return -1;
            }
        }

        public async Task<int> EditAdminsMenuAsync(int id, string title, string link, int parentId)
        {
            var data = await _adminsMenuDal.GetDataById(id);
            if (data != null)
            {
                data.Title = title;
                data.Link = link;
                data.ParentId = parentId;
                data.UpDateTime = DateTime.Now;

                return await _adminsMenuDal.EditAsync(data);
            }
            else
            {
                return -1;
            }
        }

        public async Task<List<AdminsMenuDto>> GetDataAsync()
        {
            return await _adminsMenuDal.GetData().Select(am => new AdminsMenuDto()
            {
                Id = am.Id,
                Title = am.Title,
                Link = am.Link,
                ParentId = am.ParentId,
                UpdateTime = am.UpDateTime

            }).ToListAsync();
        }

        public async Task<AdminsMenuDto> GetDataByIdAsync(int id)
        {
            var data = await _adminsMenuDal.GetDataById(id);
            if (data != null)
            {
                return new AdminsMenuDto
                {
                    Id = data.Id,
                    Title = data.Title,
                    Link = data.Link,
                    ParentId = data.ParentId,
                    UpdateTime = data.UpDateTime

                };
            }
            else
            {
                return null;
            }
        }

        public async Task<List<AdminsMenuDto>> GetDataByTitleAsync(string title)
        {
            return await _adminsMenuDal.GetDataByChoose(am => am.Title.Contains(title))
                                       .Select(am => new AdminsMenuDto()
                                       {
                                           Id = am.Id,
                                           Title = am.Title,
                                           Link = am.Link,
                                           ParentId = am.ParentId,
                                           UpdateTime = am.UpDateTime
                                       }).ToListAsync();
        }
    }
}
