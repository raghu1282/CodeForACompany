using ConsoleAppForCompany;
using NUnit.Framework;
using System;

namespace AppForCompanyTest
{
    public class CalculatePromotionsTest
    {
        private CalculatePromotions calcPromo; 
        [SetUp]
        public void Setup()
        {
            calcPromo = new CalculatePromotions();
        }

        //Scenario A
        [Test]
        [TestCase(1,1,1,0)]
        public void GetTotalAmountWithPromotionsWithNoPromo(Double AUnits, Double BUnits, Double CUnits, Double DUnits)
        {
            double expectedTotalAmt = 100, actualTotalAmt =0;
            actualTotalAmt = calcPromo.GetTotalAmountWithPromotions(AUnits, BUnits, CUnits, DUnits);
            Assert.AreEqual(expectedTotalAmt, actualTotalAmt);
        }

        //Scenario B
        [Test]
        [TestCase(5, 5, 1, 0)]
        public void GetTotalAmountWithPromotionsWithPromo(Double AUnits, Double BUnits, Double CUnits, Double DUnits)
        {
            double expectedTotalAmt = 370, actualTotalAmt = 0;
            actualTotalAmt = calcPromo.GetTotalAmountWithPromotions(AUnits, BUnits, CUnits, DUnits);
            Assert.AreEqual(expectedTotalAmt, actualTotalAmt);
        }

        //Scenario C
        [Test]
        [TestCase(3, 5, 1, 1)]
        public void GetTotalAmountWithPromotionsWithAllPromo(Double AUnits, Double BUnits, Double CUnits, Double DUnits)
        {
            double expectedTotalAmt = 280, actualTotalAmt = 0;
            actualTotalAmt = calcPromo.GetTotalAmountWithPromotions(AUnits, BUnits, CUnits, DUnits);
            Assert.AreEqual(expectedTotalAmt, actualTotalAmt);
        }

        //Scenario FAILED test
        [Test]
        [TestCase(3, 5, 5, 1)]
        public void GetTotalAmountWithPromotionsWithAllPromoFailed(Double AUnits, Double BUnits, Double CUnits, Double DUnits)
        {
            double expectedTotalAmt = 280, actualTotalAmt = 0;
            actualTotalAmt = calcPromo.GetTotalAmountWithPromotions(AUnits, BUnits, CUnits, DUnits);
            Assert.AreNotEqual(expectedTotalAmt, actualTotalAmt);
        }
    }
}
