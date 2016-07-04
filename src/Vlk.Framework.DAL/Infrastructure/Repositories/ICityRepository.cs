using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vlk.Framework.Models.Entities;
using Vlk.Framework.Core.DataAccess;

namespace Vlk.Framework.DAL.Infrastructure.Repositories
{
    public interface ICityRepository : IRepository<City, int>, ICanUpdate<City>, ICanDelete<City, int>, ICanCreate<City>
    {
        IEnumerable<City> GetCitiesByCityNamesIncludes(string searchingName);
    }
}
