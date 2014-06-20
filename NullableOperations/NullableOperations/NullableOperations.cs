using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NullableOperations
{
    [TestClass]
    public class NullableArithmeticOperations
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
            Assert.AreEqual(5, money1 % money2);
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
            Assert.IsNull(money1 % money2);
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
            Assert.IsNull(money1 % money2);
        }

        [TestMethod]
        public void BothNullableWithoutValue()
        {
            decimal? money1 = null;
            decimal? money2 = null;

            Assert.IsNull(money1 + money2);
            Assert.IsNull(money1 - money2);
            Assert.IsNull(money1 * money2);
            Assert.IsNull(money1 / money2);
            Assert.IsNull(money1 % money2);
        }
    }

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
            Assert.IsNull(null + (decimal?)null);
            Assert.IsNull(null - (decimal?)null);
            Assert.IsNull(null * (decimal?)null);
            Assert.IsNull(null / (decimal?)null);
            Assert.IsNull(null % (decimal?)null);
        }
    }

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
        public void NullablesWithoutValuesDirectly()
        {
            decimal? money1 = null;

            Assert.IsNull(++money1);
            Assert.IsNull(--money1);
        }

        [TestMethod]
        public void NullablesWithoutValuesAfterAssignment()
        {
            decimal? money1 = null;
            decimal? money2 = ++money1;
            decimal? money3 = --money1;

            Assert.IsNull(money2);
            Assert.IsNull(money3);
        }
    }
}
