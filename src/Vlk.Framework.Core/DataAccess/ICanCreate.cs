
namespace Vlk.Framework.Core.DataAccess
{
    public interface ICanCreate<TEntity> where TEntity : class
    {
        void Create(TEntity entity);
    }
}
