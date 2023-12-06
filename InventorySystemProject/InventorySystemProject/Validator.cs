using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystemProject
{
    internal static class Validator
    {
        /// <summary>
        /// Numeric validation 
        /// </summary>
        /// <param name="value">The value to validate</param>
        /// <returns>The result of the validation</returns>
        public static bool IsNumeric(string value)
        {
            return double.TryParse(value, out double a);
        }
    }
}
