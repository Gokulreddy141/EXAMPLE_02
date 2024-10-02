using System;
using LMSBL;
namespace LMSTESTS
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Book book = new Book();
            book.Available = true;
            string expected = "Available";
            string actual = book.CheckAvailability();
            Assert.AreEqual(expected, actual);
        }
        
    }
}