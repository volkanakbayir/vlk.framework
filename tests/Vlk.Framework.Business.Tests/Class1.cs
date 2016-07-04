using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vlk.Framework.Business.Tests
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    [TestClass]
    public class Class1
    {
        public Class1()
        {
        }

        [TestMethod]
        public void ShouldFail()
        {
            Assert.IsTrue(true);
        }
    }
}
