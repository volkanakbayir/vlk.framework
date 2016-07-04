namespace Vlk.Framework.Core.DataAccess
{
    public interface ICanUpdate<TEntity> where TEntity : class
    {
        void Update(TEntity entity);
    }
}
