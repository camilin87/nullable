using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NullableOperations
{
    [TestClass]
    public class NullableUnaryArithmeticOperations
    {
        [TestMethod]
        public void NullablesWithValues()
        {
            decimal? money1 = 5;
            decimal? money2 = 5;

            Assert.AreEqual(6, ++money1);
            Assert.AreEqual(4, --money2);
        }
        
        [TestMethod]
        public void NullablesWithoutValues()
        {
            decimal? money1 = null;
            decimal? money2 = null;

            Assert.IsNull(++money1);
            Assert.IsNull(--money2);
        }
    }
}