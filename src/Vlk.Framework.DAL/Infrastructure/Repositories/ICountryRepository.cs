using Vlk.Framework.Core.DataAccess;
using Vlk.Framework.Models.Entities;
namespace Vlk.Framework.Models.Infrastructure
{
    public interface ICountryRepository :  IRepository<Country, int>, ICanUpdate<Country>, ICanDelete<Country, int>, ICanCreate<Country>
    {
    }
}