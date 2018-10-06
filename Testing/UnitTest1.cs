using ComponentConvert;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            double result = Class1.ConvertGramsToOunces(grams: 11);
            Assert.AreEqual(0.388014, 0.388014);

        }

        [TestMethod]
        public void TestMethod2()
        {
            double result = Class1.ConvertOuncesToGram(ounces: 11);
            Assert.AreEqual(311.845, 311.845);
        }
    }
}
