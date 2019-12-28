using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using LDKJ.IDAL;
using LDKJ.Model;

namespace LDKJ.DAL
{
    public class BaseDAL<T> : IBaseDAL<T> where T : BaseEntity, new()
    {
        private DbContext Db
        {
            get { return new LD_Context(); }
        }


        public async Task<int> AddAsync(T model)
        {
            Db.Entry<T>(model).State = EntityState.Added;
            return await Db.SaveChangesAsync();
        }

        public async Task<int> EditAsync(T model)
        {
            Db.Entry<T>(model).State = EntityState.Modified;
            return await Db.SaveChangesAsync();

        }

        public async Task<int> DeleteAsync(T model)
        {
            Db.Entry<T>(model).State = EntityState.Deleted;
            return await Db.SaveChangesAsync();
        }

        public IQueryable<T> GetData()
        {
            return Db.Set<T>();
        }

        public IQueryable<T> GetDataByChoose(Expression<Func<T, bool>> whereLambda)
        {
           return Db.Set<T>().Where(whereLambda); 
        }

        public async Task<T> GetDataById(int id)
        {
            return await Db.Set<T>().FindAsync(id);
        }
    }
}
