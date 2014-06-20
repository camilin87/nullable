using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NullableOperations
{
    [TestClass]
    public class NullableUnaryOperations
    {
        [TestMethod]
        public void NullablesWithValues()
        {
            decimal? money1 = 5;
            decimal? money2 = 5;

            Assert.AreEqual(6, ++money1);
            Assert.AreEqual(4, --money2);
        }
        
    }
}