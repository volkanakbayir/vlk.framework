using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vlk.Framework.Models.Entities;

namespace Vlk.Framework.DAL.Context.Ef
{
    public class BaseContext : DbContext
    {
        public DbSet<City> City { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<District> District { get; set; }
        public DbSet<Neighborhood> Neighborhood { get; set; }
    }
}
