using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Vlk.Framework.Core.DataAccess;
using Vlk.Framework.DAL.Infrastructure;

namespace Vlk.Framework.DAL.UnitOfWork
{
    public class AdoNetUnitOfWorkFactory : IUnitOfWorkFactory
    {
        private SqlConnection _conntection;

        public AdoNetUnitOfWorkFactory(SqlConnection connection)
        {
            this._conntection = connection;
        }

        public IUnitOfWork Create()
        {
            return new AdoNetUnitOfWork(_conntection);
        }
    }
}
