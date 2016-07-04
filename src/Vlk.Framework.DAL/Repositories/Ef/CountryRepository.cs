using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Vlk.Framework.DAL.Context.Ef;
using Vlk.Framework.Models.Entities;
using Vlk.Framework.Models.Infrastructure;

namespace Vlk.Framework.DAL.Repositories.Ef
{
    public class CountryRepository : ICountryRepository
    {
        private ApplicationDbContext _context;
        private DbSet<Country> _set;

        public CountryRepository(ApplicationDbContext context)
        {
            _context = context;
            _set = _context.Set<Country>();
        }

        public void Create(Country entity)
        {
            _set.Add(entity);
        }

        public void Delete(Country entity)
        {
            _set.Remove(entity);
        }

        public void Delete(int id)
        {
            var removingData = _set.FirstOrDefault(d => d.Id == id);
            if (removingData != null)
                _set.Remove(removingData);
        }

        public IEnumerable<Country> GetAll()
        {
            return _set.AsNoTracking().ToList();
        }
        
        public Country GetById(int id)
        {
            return _set.FirstOrDefault(d => d.Id == id);
        }

        public IEnumerable<Country> GetCountriesByCountryNamesIncluding(string searchingName)
        {
            return _set.Where(d => d.Name.Contains(searchingName)).ToList(); 
        }

        public void Update(Country entity)
        {
            var entry = _context.Entry<Country>(entity);
            if (entry.State == EntityState.Detached)
                entry.State = EntityState.Modified;
        }
    }
}
