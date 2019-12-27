using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using LDKJ.Dto;

namespace LDKJ.IBLL
{
    public interface IAdminsMenuService
    {
        Task<int> AddAdminsMenuAsync(string title, string link, int parentId);
        Task<int> EditAdminsMenuAsync(int id,string title, string link, int parentId);
        Task<int> DeleteAdminsMenuAsync(int id);

        Task<List<AdminsMenuDto>> GetDataAsync();
        Task<List<AdminsMenuDto>> GetDataByTitleAsync(string title);
        Task<AdminsMenuDto> GetDataByIdAsync(int id);
    }
}