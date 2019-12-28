using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LDKJ.Dto;
using LDKJ.IBLL;
using LDKJ.IDAL;
using LDKJ.Model;
using System.Data.Entity;
namespace LDKJ.BLL
{
    public class RolesService : IRolesService
    {
        private IRolesDal _rolesDal;
        public RolesService(IRolesDal rolesDal)
        {
            this._rolesDal = rolesDal;
        }


        public async Task<int> AddRolesAsync(string title)
        {
            return await _rolesDal.AddAsync(new Model.Roles()
            {
                Title = title
            });
        }

        public async Task<int> DeleteRolesAsync(int id)
        {
            var model = await  _rolesDal.GetDataById(id);
            if (model != null)
            {
                return await _rolesDal.DeleteAsync(model);
            }
            else 
            {
                return -1;
            }
        }

        public async Task<int> EditRolesAsync(int id, string title)
        {
            var model = await _rolesDal.GetDataById(id);
            if (model != null)
            {
                model.Title = title;
                model.UpDateTime = DateTime.Now;

                return await _rolesDal.EditAsync(model);
            }
            else
            {
                return -1;
            }
        }

        public async Task<List<RolesDto>> GetDataAsync()
        {
            return await _rolesDal.GetData().Select(r => new RolesDto()
            {
                Id = r.Id,
                Title = r.Title,
                UpdateTime = r.UpDateTime

            }).ToListAsync();
        }

        public async Task<RolesDto> GetDataByIdAsync(int id)
        {
            var data = await _rolesDal.GetDataById(id);
            if (data != null)
            {
                return new RolesDto
                {
                    Id = data.Id,
                    Title = data.Title,
                    UpdateTime = data.UpDateTime
                };
            }
            else 
            {
                return null;
            }
        }

        public async Task<List<RolesDto>> GetDataByTitleAsync(string title)
        {
            return await _rolesDal.GetDataByChoose(r=> r.Title.Contains(title)).Select(r => new RolesDto()
            {
                Id = r.Id,
                Title = r.Title,
                UpdateTime = r.UpDateTime

            }).ToListAsync();
        }
    }
}
