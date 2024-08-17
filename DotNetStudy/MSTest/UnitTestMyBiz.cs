using CoreConsoleApp.OnlyForUnitTest;

namespace MSTest
{
    [TestClass]
    public class UnitTestMyBiz
    {
        [TestMethod]
        public void TestGetTriangle()
        {
            int[] sideArr = { 5, 5, 5 };
            Assert.AreEqual("等边三角形", MyBiz.GetTriangle(sideArr));


            int[] sideArr2 = { 5, 5 };
            Assert.AreEqual("不构成三角形", MyBiz.GetTriangle(sideArr2));
        }



        [TestMethod]
        public void TestMyFoo()
        {
            //actual express
            var actual = true;

            //expected express
            var expected = true;

            // assert  
            Assert.AreEqual(expected, actual);
        }
    }
}