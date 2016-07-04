using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vlk.Framework.Models.Infrastructure;

namespace Vlk.Framework.Models.Entities
{
    public class City : IEntity<int>, ICanHaveName
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
