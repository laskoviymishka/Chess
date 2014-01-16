using Chess.Infrastructure.DataAccess.Model.Portal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Infrastructure.DataAccess
{
    public interface IRepository<T> where T : IMongoEntity
    {
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        IQueryable<T> SearchFor(Expression<Func<T, bool>> predicate);
        IQueryable<T> GetAll();
        T GetById(string id);
        T GetOne(Expression<Func<T, bool>> predicate);
    }
}
