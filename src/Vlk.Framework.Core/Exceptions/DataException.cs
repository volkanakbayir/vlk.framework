﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vlk.Framework.Core.Exceptions
{
    public class DataException : System.Exception
    {
        //
        // For guidelines regarding the creation of new exception types, see
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cpgenref/html/cpconerrorraisinghandlingguidelines.asp
        // and
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dncscol/html/csharp07192001.asp
        //

        public DataException()
        {
        }

        public DataException(string message) : base(message)
        {
        }

        public DataException(string message, System.Exception inner) : base(message, inner)
        {
        }

    }
}
