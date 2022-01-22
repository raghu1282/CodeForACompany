using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppForCompany
{
    public class CalculatePromotions
    {
        Double totalAmt = 0;

        public double GetTotalAmountWithPromotions(Double AUnits,Double BUnits,Double CUnits, Double DUnits)
        {

            return totalAmt;
        }

    }

    public static class Utility
    {
        static double totalDiscountItem = 0, totalActualItems = 0;
        public static double Calculate(int AcutalPrice , int DiscountPrice, double Units, int UnitsWithDiscount)
        {
            totalDiscountItem = Math.Floor(Units / UnitsWithDiscount);
            totalActualItems = Units % UnitsWithDiscount;

            return totalActualItems * AcutalPrice + totalDiscountItem * DiscountPrice;
        }

    }
}
