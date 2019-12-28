using LDKJ.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LDKJ.IDAL
{
    public interface IBaseDAL<T> where T: BaseEntity,new()
    {
        Task<int> AddAsync(T model);

        Task<int> EditAsync(T model);

        Task<int> DeleteAsync(T model);

        IQueryable<T> GetData();

        IQueryable<T> GetDataByChoose(Expression<Func<T, bool>> whereLambda);

        Task<T> GetDataById(int id);
    }
}
