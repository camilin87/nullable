using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NullableOperations
{
    [TestClass]
    public class NullableArithmeticOperationsWithNull
    {
        [TestMethod]
        public void FirstNullableWithoutValue()
        {
            decimal? money2 = 6;

            Assert.IsNull(null + money2);
            Assert.IsNull(null - money2);
            Assert.IsNull(null * money2);
            Assert.IsNull(null / money2);
            Assert.IsNull(null % money2);
        }
        
        [TestMethod]
        public void SecondNullableWithoutValue()
        {
            decimal? money1 = 5;

            Assert.IsNull(money1 + null);
            Assert.IsNull(money1 - null);
            Assert.IsNull(money1 * null);
            Assert.IsNull(money1 / null);
            Assert.IsNull(money1 % null);
        }   
        
        [TestMethod]
        public void BothNullableWithoutValue()
        {
            Assert.IsNull(null + (decimal?) null);
            Assert.IsNull(null - (decimal?) null);
            Assert.IsNull(null * (decimal?) null);
            Assert.IsNull(null / (decimal?) null);
            Assert.IsNull(null % (decimal?) null);
        }
    }
}