using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vlk.Framework.Models.Infrastructure;

namespace Vlk.Framework.Models.Entities
{
    public class Neighborhood : IEntity<long>, ICanHaveName
    {
        public long Id { get; set; }
        public string Name { get; set; }

    }
}
