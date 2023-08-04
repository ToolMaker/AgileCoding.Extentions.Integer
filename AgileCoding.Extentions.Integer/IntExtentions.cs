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

        public static int ToInt<IExceptionType>(this string stringValue, string? errorMessage = null)
             where IExceptionType : Exception, new()
        {
            string tempErrorMessage = errorMessage == null
                ? $"Value provided '{stringValue}' is not a valid integer"
                : errorMessage;

            int tempIntValue = 0;
            if(!int.TryParse(stringValue, out tempIntValue))
            {
                var exception = typeof(IExceptionType).CreateInstanceWithoutLogging<IExceptionType>(tempErrorMessage);
                if (exception != null)
                {
                    throw exception;
                }
                else
                {
                    throw new Exception(tempErrorMessage);
                }
            }

            return tempIntValue;
        }

        public static int ThrowsIfTrue<TExceptionType>(this int self, bool expression, string errorMessage)
            where TExceptionType : Exception
        {
            if (expression)
            {
                var exception = typeof(TExceptionType).CreateInstanceWithoutLogging<TExceptionType>(errorMessage);
                if (exception != null)
                {
                    throw exception;
                }
                else
                {
                    throw new Exception(errorMessage);
                }
            }

            return self;
        }
    }
}
