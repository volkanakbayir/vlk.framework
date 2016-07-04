namespace Vlk.Framework.Core.DataAccess
{
    public interface ICanDelete<TEntity, TIdentityType> where TEntity : class  
    {
        void Delete(TIdentityType id);
        void Delete(TEntity entity);
    }
}
