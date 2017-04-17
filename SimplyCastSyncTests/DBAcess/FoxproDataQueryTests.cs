using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimplyCastSync.DBAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyCastSync.DBAccess.Tests
{
    [TestClass()]
    public class FoxproDataQueryTests
    {
        [TestMethod()]
        public void GetDataTest()
        {
            var foxquery = new FoxproDataQuery("Provider=VFPOLEDB.1;Data Source=C:\\Users\\zhefeng\\Documents\\Foxpro;");
            var result = foxquery.GetData("select * from table_test1");
            Assert.Fail();
        }
    }
}