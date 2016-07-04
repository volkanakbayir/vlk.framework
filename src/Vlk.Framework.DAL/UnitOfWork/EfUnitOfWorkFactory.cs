using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vlk.Framework.Core.DataAccess;
using Vlk.Framework.DAL.Context.Ef;

namespace Vlk.Framework.DAL.UnitOfWork
{
    public class EfUnitOfWorkFactory : IUnitOfWorkFactory
    {
        private ApplicationDbContext _context;

        public EfUnitOfWorkFactory(ApplicationDbContext context)
        {
            this._context = context;
        }

        public IUnitOfWork Create()
        {
            return new EfUnitOfWork(this._context);
        }
    }
}
