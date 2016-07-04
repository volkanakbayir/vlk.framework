using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vlk.Framework.Core.DataAccess.Transaction;

namespace Vlk.Framework.DAL.Concrete.Transaction
{
    public class EfTransaction : ITransaction
    {
        private IDbContextTransaction _innerTransaction;

        public EfTransaction(IDbContextTransaction innerTransaction)
        {
            this._innerTransaction = innerTransaction;
        }
        public void Commit()
        {
            this._innerTransaction.Commit();
        }

        public void Dispose()
        {
            this._innerTransaction.Dispose();
        }

        public void Rollback()
        {
            this._innerTransaction.Rollback();
        }
    }
}
