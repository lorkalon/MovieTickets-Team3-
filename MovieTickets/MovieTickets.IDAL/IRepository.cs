using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieTickets.Entities;

namespace MovieTickets.IDAL
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> GetAll();
        TEntity GetById(object id);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }

    //Write there IRepository|Entity| interfaces with necessary methods
     
    public interface IRepositoryUser : IRepository<User>
    {
        
    }
}
