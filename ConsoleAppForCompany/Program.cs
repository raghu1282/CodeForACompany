using System;

namespace ConsoleAppForCompany
{
    class Program
    {
       

        static void Main(string[] args)
        {
            double AUnit = 1, BUnit = 1, CUnit = 1, DUnit = 0;
            CalculatePromotions pro = new CalculatePromotions();
            Console.WriteLine("Total Cost of {0} A SKU's, {1} B SKU's, {2} C SKU's and {3} D SKU's after applying Active Promotion is {4} .",
                                AUnit, BUnit, CUnit, DUnit, pro.GetTotalAmountWithPromotions(AUnit, BUnit, CUnit, DUnit));
            Console.ReadKey();
        }
    }
}
