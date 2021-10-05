using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RecepieProject.Core.Domain.Common
{
    public interface IRepository<TEntity> where TEntity : Entity,new()
    {
        void Insert(TEntity entity);
        void Remove(TEntity entity);
        void Update(TEntity entity);
        void SaveChange();
        TEntity Get(Guid Id);
        IEnumerable<TEntity> GetAll();
        bool Exists(Expression<Func<TEntity, bool>> expression);
    }
}
