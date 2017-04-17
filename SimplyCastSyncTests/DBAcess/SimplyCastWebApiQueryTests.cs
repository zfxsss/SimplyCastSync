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
    public class SimplyCastWebApiQueryTests
    {
        [TestMethod()]
        public void GetDataTest()
        {
            var client = new SimplyCastWebApiQuery("BaseAddress=https://app.simplycast.cm;PublicKey=a8fe3712113090e5666a6b374452dc930d710553;SecretKey=7dc2feccd12ec26534a405c611f0134481c3394e;");
            var result = client.GetData("?q=api/call&request=contactmanager/lists");
            Assert.Fail();
        }
    }
}