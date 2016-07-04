using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Vlk.Framework.DAL.Infrastructure.Repositories;
using Vlk.Framework.DAL.UnitOfWork;
using Vlk.Framework.Models.Entities;

namespace Vlk.Framework.DAL.Repositories.AdoNet
{
    public class CityRepository : ICityRepository
    {
        private IDbConnection _connection;
        private AdoNetUnitOfWork _uow;

        public CityRepository(IDbConnection connection, AdoNetUnitOfWork uow)
        {
            this._connection = connection;
            this._uow = uow;
        }

        public void Create(City entity)
        {
            string commandText = "insert into dbo.City (Name) values (:p1); select Id from @@inserted;";
            var command = _uow.CreateCommand();
            command.CommandText = commandText;
            var parameter = command.CreateParameter();
            parameter.Value = entity.Name;
            parameter.ParameterName = "p1";
            command.Parameters.Add(parameter);
            _uow.Track(() =>
            {
                entity.Id = (int)command.ExecuteScalar();
            });
        }

        public void Delete(City entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<City> GetAll()
        {
            throw new NotImplementedException();
        }

        public City GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<City> GetCitiesByCityNamesIncludes(string searchingName)
        {
            throw new NotImplementedException();
        }

        public void Update(City entity)
        {
            throw new NotImplementedException();
        }
    }
}
