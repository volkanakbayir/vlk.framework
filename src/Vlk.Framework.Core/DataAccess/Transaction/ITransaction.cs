﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vlk.Framework.Core.DataAccess.Transaction
{
    public interface ITransaction : IDisposable
    {
        void Commit();
        void Rollback();
    }
}
