using System;
using System.Collections.Generic;
using System.Data.Common;
using Vlk.Framework.Core.DataAccess;
using Vlk.Framework.Core.Exceptions;

namespace Vlk.Framework.DAL.UnitOfWork
{
    public class AdoNetUnitOfWork : IUnitOfWork
    {
        private DbConnection _connection;
        private DbTransaction _transaction;
        private List<Action> _trackingQueries;


        public AdoNetUnitOfWork(DbConnection connection)
        {
            this._connection = connection;
            if (connection.State != System.Data.ConnectionState.Open)
                throw new DataException("DbConnection must be open before using in unit of work.");

            this._transaction = connection.BeginTransaction();
            this._trackingQueries = new List<Action>();
        }

        public DbCommand CreateCommand()
        {
            var command = _connection.CreateCommand();
            command.Transaction = _transaction;
            return command;
        }

        public void Commit()
        {
            foreach (var trackedQuery in _trackingQueries)
            {
                trackedQuery();
            }
            _transaction.Commit();
            _trackingQueries.Clear();
        }

        public void Track(Action action)
        {
            _trackingQueries.Add(action);
        }

        public void Dispose()
        {
            _trackingQueries.Clear();
            _connection.Dispose();
            _transaction.Dispose();

            _trackingQueries = null;
            _transaction = null;
        }

        public void Rollback()
        {
            _trackingQueries.Clear();
            _transaction.Rollback();
        }
    }
}
