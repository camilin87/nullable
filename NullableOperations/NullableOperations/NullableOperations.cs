using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NullableOperations
{
    [TestClass]
    public class NullableOperations
    {
        [TestMethod]
        public void NullablesWithValues()
        {
            decimal? money1 = 5;
            decimal? money2 = 6;

            Assert.AreEqual(11, money1 + money2);
            Assert.AreEqual(-1, money1 - money2);
            Assert.AreEqual(30, money1 * money2);
            Assert.IsTrue(decimal.Equals(0.8333333333333333333333333333M, (money1 / money2).Value));
        }

        [TestMethod]
        public void FirstNullableWithoutValue()
        {
            decimal? money1 = null;
            decimal? money2 = 6;

            Assert.IsNull(money1 + money2);
            Assert.IsNull(money1 - money2);
            Assert.IsNull(money1 * money2);
            Assert.IsNull(money1 / money2);
        }
        
        [TestMethod]
        public void SecondNullableWithoutValue()
        {
            decimal? money1 = 5;
            decimal? money2 = null;

            Assert.IsNull(money1 + money2);
            Assert.IsNull(money1 - money2);
            Assert.IsNull(money1 * money2);
            Assert.IsNull(money1 / money2);
        }
    }
}
