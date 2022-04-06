using DotNetLibraryClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetTest
{
    [TestClass]
    public class UnitTest1
    {
        Class1 classObj2 = new Class1();

        [TestMethod]
        public void TestMethod1()
        {

            Assert.AreEqual("Addition = 3", classObj2.Add(1,2));
        }
        [TestMethod]
        public void TestMethod2()
        {

            Assert.AreNotEqual("Multiplication = 3", classObj2.Mul(2,3));
        }
    }
}
