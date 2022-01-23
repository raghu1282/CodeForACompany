using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppForCompany
{
    enum SKUIDs_Units : int
    {
        SKUIDs_A_UnitPrice = 50,
        SKUIDs_B_UnitPrice = 30,
        SKUIDs_C_UnitPrice = 20,
        SKUIDs_D_UnitPrice = 15,
        SKUIDs_A_Promotion_Price = 130,
        SKUIDs_B_Promotion_Price = 45,
        SKUIDs_CnD_Promotion_Price = 30,
        SKUID_A_PromoUnits = 3,
        SKUID_B_PromoUnits = 2
    }
    public class CalculatePromotions
    {
        Double totalAmt = 0;

        public double GetTotalAmountWithPromotions(Double AUnits,Double BUnits,Double CUnits, Double DUnits)
        {
            
            totalAmt += Utility.Calculate(Convert.ToInt32(SKUIDs_Units.SKUIDs_A_UnitPrice), Convert.ToInt32(SKUIDs_Units.SKUIDs_A_Promotion_Price) , Convert.ToInt32(SKUIDs_Units.SKUID_A_PromoUnits), AUnits);

            totalAmt += Utility.Calculate(Convert.ToInt32(SKUIDs_Units.SKUIDs_B_UnitPrice),Convert.ToInt32(SKUIDs_Units.SKUIDs_B_Promotion_Price), Convert.ToInt32(SKUIDs_Units.SKUID_B_PromoUnits), BUnits);

            totalAmt += Math.Min(CUnits, DUnits) * Convert.ToUInt32(SKUIDs_Units.SKUIDs_CnD_Promotion_Price);

            totalAmt += (CUnits - DUnits) > 0 ? Math.Abs(CUnits - DUnits) * (int)(SKUIDs_Units.SKUIDs_C_UnitPrice) :
                                                                    Math.Abs(CUnits - DUnits) * (int)(SKUIDs_Units.SKUIDs_D_UnitPrice);

            return totalAmt;
        }

    }

    public static class Utility
    {
        static double totalDiscountItem = 0, totalActualItems = 0;
        public static double Calculate(int AcutalPrice , int DiscountPrice, int UnitsWithDiscount, double Units)
        {
            totalDiscountItem = Math.Floor(Units / UnitsWithDiscount);
            totalActualItems = Units % UnitsWithDiscount;

            return totalActualItems * AcutalPrice + totalDiscountItem * DiscountPrice;
        }

    }
}
