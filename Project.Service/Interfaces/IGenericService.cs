using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.Service.Interfaces
{
    public interface IGenericService<T>
    {
        Task<bool> Create(T model);

        Task<IEnumerable<T>> GetAll();

        Task<T> GetById(int Id);

        Task<bool> Update(T model);

        Task<bool> Delete(int Id);
        Task<bool> Delete(T model);
        IEnumerable<T> Get(Expression<Func<T, bool>> filter = null,
Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
string includeProperties = "");
    }
}
