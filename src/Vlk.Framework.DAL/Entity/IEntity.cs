using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vlk.Framework.DAL.Entity
{
    public interface IEntity
    {

    }
    public interface IEntity<TIdentityType> : IEntity
    {
        TIdentityType Id { get; set; }
    }
}
