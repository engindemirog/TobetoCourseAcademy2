using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess;

public interface IEntityRepository<TEntity,TEntityId>
    where TEntity : Entity<TEntityId>
{
    TEntity Get(Expression<Func<TEntity, bool>> filter);
    IList<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null);
    void Add(TEntity entity);
    void Update(TEntity entity);
    void Delete(TEntity entity);
}