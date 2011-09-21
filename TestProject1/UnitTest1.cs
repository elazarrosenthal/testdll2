using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestDll;




namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestShouldPass()
        {
            Assert.IsTrue(UselessStuff.myTrue());
        }

        [TestMethod]
        public void TestShouldFail()
        {
            Assert.IsTrue(!(UselessStuff.myTrue()));
        }
    }
}
