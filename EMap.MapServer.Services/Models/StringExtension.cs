using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMap.MapServer.Services.Models
{
    public static class StringExtension
    {
        public static double[] ToDoubleValues(this string value,char split=' ')
        {
            string[] array = value?.Split(split,StringSplitOptions.RemoveEmptyEntries);
            double[] doubleValues = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                bool ret = double.TryParse(array[i], out double doubleValue);
                if (!ret)
                {
                    return null;
                }
                doubleValues[i] = doubleValue;
            }
            return doubleValues;
        }
    }
}
