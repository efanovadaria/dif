using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using dif;

namespace difTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculateTotal_ValidData_ReturnsCorrectValue()
        {
            double result =
                difLogic.CalculateTotal(1000, 2, 10);

            Assert.AreEqual(550, result);
        }

        [TestMethod]
        public void CalculateTotal_NoTips_ReturnsCorrectValue()
        {
            double result =
                difLogic.CalculateTotal(1000, 2, 0);

            Assert.AreEqual(500, result);
        }

        [TestMethod]
        public void CalculateTotal_OneGuest_ReturnsCorrectValue()
        {
            double result =
                difLogic.CalculateTotal(1000, 1, 15);

            Assert.AreEqual(1150, result);
        }

        [TestMethod]
        public void CalculateTotal_BillAmountZero_ThrowsException()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                difLogic.CalculateTotal(0, 2, 10);
            });
        }

        [TestMethod]
        public void CalculateTotal_GuestsZero_ThrowsException()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                difLogic.CalculateTotal(1000, 0, 10);
            });
        }

        [TestMethod]
        public void CalculateTotal_NegativeTips_ThrowsException()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                difLogic.CalculateTotal(1000, 2, -5);
            });
        }

        [TestMethod]
        public void CalculateTotal_ResultIsPositive()
        {
            double result =
                difLogic.CalculateTotal(1000, 2, 5);

            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void CalculateTotal_ResultIsNotIncorrect()
        {
            double result =
                difLogic.CalculateTotal(1000, 2, 10);

            Assert.AreNotEqual(400, result);
        }
        [TestMethod]
        public void CalculateTotal_MinimumBillAmount_ReturnsCorrectValue()
        {
            double result =
                difLogic.CalculateTotal(1, 1, 0);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void CalculateTotal_MinimumGuests_ReturnsCorrectValue()
        {
            double result =
                difLogic.CalculateTotal(1000, 1, 5);

            Assert.AreEqual(1050, result);
        }

        [TestMethod]
        public void CalculateTotal_LargeBillAmount_ReturnsCorrectValue()
        {
            double result =
                difLogic.CalculateTotal(1000000, 10, 15);

            Assert.AreEqual(115000, result);
        }

        [TestMethod]
        public void CalculateTotal_MinimumDecimalBill_ReturnsCorrectValue()
        {
            double result =
                difLogic.CalculateTotal(0.01, 1, 0);

            Assert.AreEqual(0.01, result);
        }

        [TestMethod]
        public void CalculateTotal_LargeGuestsCount_ReturnsCorrectValue()
        {
            double result =
                difLogic.CalculateTotal(1000, 100, 10);

            Assert.AreEqual(11, result);
        }
    }
}