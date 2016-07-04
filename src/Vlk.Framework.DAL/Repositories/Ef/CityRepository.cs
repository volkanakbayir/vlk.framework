using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vlk.Framework.DAL.Context.Ef;
using Vlk.Framework.DAL.Infrastructure;
using Vlk.Framework.DAL.Infrastructure.Repositories;
using Vlk.Framework.Models.Entities;
using Vlk.Framework.Models.Infrastructure;

namespace Vlk.Framework.DAL.Repositories.Ef
{
    public class CityRepository : ICityRepository
    {
        private ApplicationDbContext _context;
        private DbSet<City> _set;

        public CityRepository(ApplicationDbContext context)
        {
            this._context = context;
            _set = context.Set<City>();
        }

        public void Create(City entity)
        {
            _set.Add(entity);
        }

        public void Delete(City entity)
        {
            _set.Remove(entity);
        }

        public void Delete(int id)
        {
            var deletingItem = _set.FirstOrDefault(d => d.Id == id);
            if (deletingItem != null)
                _set.Remove(deletingItem);
        }

        public IEnumerable<City> GetAll()
        {
            return _set.AsNoTracking().ToList();
        }

        public City GetById(int id)
        {
            return _set.FirstOrDefault(d => d.Id == id);
        }

        public IEnumerable<City> GetCitiesByCityNamesIncludes(string searchingName)
        {
            return _set.Where(d => d.Name.Contains(searchingName))
                .AsNoTracking()
                .ToList();
        }

        public void Update(City entity)
        {
            var entry = _context.Entry<City>(entity);
            if (entry.State == EntityState.Detached)
                entry.State = EntityState.Modified;
        }
    }
}
