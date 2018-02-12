using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessTest.Extensions
{
    public static class NumberExtensions
    {
        /// <summary>
        /// To the number.
        /// </summary>
        /// <param name="strValue">The string value.</param>
        /// <returns>System.Int32.</returns>
        public static int ToNumber(this string strValue)
        {
            int rtn = 0;
            Int32.TryParse(strValue, out rtn);
            return rtn;
        }
    }
}