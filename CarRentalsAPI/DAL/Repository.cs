using CarRentalsAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CarRentalsAPI.DAL
{
    public class Repository<TModel> : IRepository<TModel> where TModel : class, IEntity
    {
        private readonly IRentalContext _dbContext;
        public Repository(IRentalContext dbContext)
        {
            _dbContext = dbContext;
        }
        public TModel Add(TModel model)
        {
            _dbContext.Set<TModel>().Add(model);
            _dbContext.SaveChanges();
            return model;
        }
        public TModel Delete(TModel model)
        {
            _dbContext.Set<TModel>().Remove(model);
            _dbContext.SaveChanges();
            return model;
        }
        public TModel GetById(int id)
        {
            return _dbContext.Set<TModel>().Find(id);
        }
        public IQueryable<TModel> GetAll()
        {
            return _dbContext.Set<TModel>();
        }
        public IQueryable<TModel> Query(Expression<Func<TModel, bool>> predicate)
        {
            return GetAll().Where(predicate);
        }
        public TModel Update(TModel model)
        {
            _dbContext.Entry(model).State = EntityState.Modified;
            _dbContext.SaveChanges();
            return model;
        }
    }
}
