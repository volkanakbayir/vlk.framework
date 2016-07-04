using System.Collections.Generic;
namespace Vlk.Framework.Core.DataAccess
{
    public interface IRepository<TEntity, TIdentityType> where TEntity : class 
    {
        TEntity GetById(TIdentityType id);
        IEnumerable<TEntity> GetAll();
    }
}
