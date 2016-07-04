using System;
using Vlk.Framework.Core.DataAccess;
using Vlk.Framework.Core.DataAccess.Transaction;
using Vlk.Framework.Core.Exceptions;
using Vlk.Framework.DAL.Concrete.Transaction;
using Vlk.Framework.DAL.Context.Ef;

namespace Vlk.Framework.DAL.UnitOfWork
{
    public class EfUnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _context;
        private ITransaction _transaction;
        private bool _transactionComitted = false;
        private bool disposedValue = false; 

        public EfUnitOfWork(ApplicationDbContext context)
        {
            this._context = context;
            this._transaction = new EfTransaction(_context.Database.BeginTransaction());
        }

        public void Commit()
        {
            this._context.SaveChanges(true);
            this._transaction.Commit();
            _transactionComitted = true;
        }

        public void Rollback()
        {
            if (_transactionComitted)
                throw new DataException("Transaction for the unit of work has been committed once.");

            if (this._transaction != null)
                this._transaction.Rollback();
        }
 
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    this._transaction.Dispose();
                    this._context.Dispose();
                }
                this._transaction = null;
                this._context = null;
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }
    }
}
