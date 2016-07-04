using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vlk.Framework.Models.Infrastructure
{
    public interface ICanHaveName
    {
        string Name { get; set; }
    }
}
