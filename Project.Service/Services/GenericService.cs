using Microsoft.EntityFrameworkCore;
using Project.Core.Interfaces;
using Project.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.Service.Services
{
    public class GenericService<TEntity> : IGenericService<TEntity> where TEntity : class
    {
        public readonly IUnitOfWork _unitOfWork;

        public GenericService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<bool> Create(TEntity entity)
        {
            if (entity != null)
            {
                await _unitOfWork.GetRepository<TEntity>().Add(entity);
                return true;
            }
            return false;
        }

        public async Task<bool> Delete(int id)
        {
            if (id > 0)
            {
                var entity = await _unitOfWork.GetRepository<TEntity>().GetById(id);
                if (entity != null)
                {
                    _unitOfWork.GetRepository<TEntity>().Delete(entity);
                    return await _unitOfWork.SaveChangesAsync() > 0;
                }
            }
            return false;
        }

        public async Task<bool> Delete(TEntity model)
        {

            {
                _unitOfWork.GetRepository<TEntity>().Delete(model);
                return true;
            }
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _unitOfWork.GetRepository<TEntity>().GetAll();
        }

        public async Task<TEntity> GetById(int id)
        {
            if (id > 0)
            {
                return await _unitOfWork.GetRepository<TEntity>().GetById(id);
            }
            return null;
        }

        public async Task<bool> Update(TEntity entity)
        {
            if (entity != null)
            {
                _unitOfWork.GetRepository<TEntity>().Update(entity);
                return true;
            }
            return false;
        }

        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null,
         Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
         string includeProperties = "")
        {
            var query = _unitOfWork.GetRepository<TEntity>().Get();

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query);
            }
            return query;
        }
    }
}
