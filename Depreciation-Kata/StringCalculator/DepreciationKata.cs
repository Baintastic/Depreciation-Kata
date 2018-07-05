using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class DepreciationKata
    {
        public object CalculationDepreciationAmount(double assetCost, double salvageValue, int usefulLife, DateTime acquiredDate, DateTime financialYearEndDate)
        {
            var yearDepreciationAmounts = new Dictionary<int, double>();
            var life = usefulLife;
            int acquiredDay = acquiredDate.Day;
            int acquiredYear = acquiredDate.Year;
            var depreciationAmount = 0.00; 
            if (acquiredDay > 1)
            {
                acquiredDay = 1;
            }
            while (life >=1) {
                depreciationAmount = (assetCost - salvageValue) / usefulLife;
                yearDepreciationAmounts.Add(acquiredYear, depreciationAmount);
                assetCost -= depreciationAmount;
                acquiredYear++;
                life--;
            }            
                depreciationAmount = yearDepreciationAmounts[financialYearEndDate.Year];

              return depreciationAmount;
        }
    }
}
