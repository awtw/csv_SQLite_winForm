using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SpliteHelper
{
    class CalculatorHelper
    {

        public static List<double> CalStd(List<TemperatureRecord> temperatureRecords)
        {
            var result = new List<double>();
           

            for (int i = 1; i <= 6; i++)
            {
                string propertyName = $"第{i}段溫度顯示值";
                var average = temperatureRecords
                    .Select(x => GetValue(x,propertyName)).Average();
                var sumOfSquareOfDifferences = temperatureRecords
                    .Select(x => (GetValue(x,propertyName) - average) * (GetValue(x,propertyName) - average)).Sum();
                var sd = Math.Sqrt(sumOfSquareOfDifferences / temperatureRecords.Count);
                var maxNumber = temperatureRecords.Select(x => GetValue(x,propertyName)).Max();
                var minNumber = temperatureRecords.Select(x =>GetValue(x,propertyName)).Min();
               
                result.Add(Math.Round(sd,2));
            }

            return result;

        }

        public static double GetMaxValue(List<TemperatureRecord> temperatureRecords)
        {
            double maxDouble = 0;
            for (int i = 1; i <= 6; i++)
            {
                string propertyName = $"第{i}段溫度顯示值";
                var maxNumber = temperatureRecords.Select(x => GetValue(x,propertyName)).Max();
                if (maxDouble < maxNumber)
                {
                    maxDouble = maxNumber;
                }

                
            }
            return maxDouble;
        }
        public static double GetMinValue(List<TemperatureRecord> temperatureRecords)
        {
            double minDouble = 0;
            for (int i = 1; i <= 6; i++)
            {
                string propertyName = $"第{i}段溫度顯示值";
                var minNumber = temperatureRecords.Select(x => GetValue(x, propertyName)).Max();
                if (minDouble < minNumber)
                {
                    minDouble = minNumber;
                }
            }
            return minDouble;
        }
        private static double GetValue(TemperatureRecord record, string propertyName)
        {
            return (double)record.GetType().GetProperty(propertyName).GetValue(record);
        }
    }
}
