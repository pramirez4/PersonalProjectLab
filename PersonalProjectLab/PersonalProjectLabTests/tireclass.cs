using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonalProjectLab; 

namespace PersonalProjectLabTests
{
    [TestClass]
    public class tireclass
    {
        [TestMethod]
        public void tireConverionTest()
        {
            //arrange
            TireClass real = new TireClass();

            // act
            decimal actualSpeed = real.tireConverion(235, 225, 45);

            // asserting
            Assert.AreEqual(47.0m, actualSpeed);

        }
    }
}
