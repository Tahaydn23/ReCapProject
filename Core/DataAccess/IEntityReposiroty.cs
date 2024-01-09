
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public interface IEntityReposiroty<T> where T : class,IEntity,new()
    {
        List<T> GetAllCars(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void GetByld(T entity);
        void GetAll(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
