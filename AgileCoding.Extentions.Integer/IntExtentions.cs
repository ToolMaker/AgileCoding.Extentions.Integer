using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgileCoding.Extentions.Activators;

namespace AgileCoding.Extentions.Integers
{
    public static class IntExtentions
    {
        public static int ToInt(this string stringValue)
        {
            int tempIntValue = 0;
            int.TryParse(stringValue, out tempIntValue);
            return tempIntValue;
        }

        public static int ToInt<IExceptionType>(this string stringValue, string errorMessage = null)
             where IExceptionType : Exception, new()
        {
            string tempErrorMessage = errorMessage == null
                ? $"Value provided '{stringValue}' is not a valid integer"
                : errorMessage;

            int tempIntValue = 0;
            if(!int.TryParse(stringValue, out tempIntValue))
            {
                throw typeof(IExceptionType).CreateInstanceWithoutLogging<IExceptionType>(tempErrorMessage);
            }

            return tempIntValue;
        }

        public static int ThrowsIfTrue<TExceptionType>(this int self, bool expression, string errorMessage)
            where TExceptionType : Exception
        {
            if (expression)
            {
                throw typeof(TExceptionType).CreateInstanceWithoutLogging<TExceptionType>(errorMessage);
            }

            return self;
        }
    }
}
