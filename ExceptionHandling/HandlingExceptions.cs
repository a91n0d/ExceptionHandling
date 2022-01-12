using System;
#pragma warning disable CA2201, S112

namespace ExceptionHandling
{
    public static class HandlingExceptions
    {
        public static bool CatchException(object obj)
        {
            try
            {
                ThrowException(obj);
            }
            catch
            {
                return true;
            }

            return false;
        }

        public static bool CatchArgumentNullException(object obj, out string exceptionMessage)
        {
            exceptionMessage = string.Empty;

            try
            {
                ThrowException(obj);
            }
            catch (ArgumentNullException ex)
            {
                exceptionMessage = ex.Message;
                return true;
            }

            return false;
        }

        public static bool CatchArgumentException(int i, out string exceptionMessage)
        {
            exceptionMessage = string.Empty;

            try
            {
                ThrowException(new object(), i);
            }
            catch (ArgumentException ex)
            {
                exceptionMessage = ex.Message;
                return true;
            }

            return false;
        }

        public static bool CatchArgumentOutOfRangeException(int j, out string exceptionMessage)
        {
            exceptionMessage = string.Empty;

            try
            {
                ThrowException(new object(), 1, j);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                exceptionMessage = ex.Message;
                return true;
            }

            return false;
        }

        public static bool CatchExceptions(object obj, int i, int j, bool throwException, out string exceptionMessage)
        {
            exceptionMessage = string.Empty;

            try
            {
                ThrowException(obj, i, j, throwException);
            }
            catch (Exception ex)
            {
                exceptionMessage = ex.Message;
                return true;
            }

            return false;
        }

        private static void ThrowException(object obj, int i = 1, int j = 1, bool throwException = false)
        {
            if (obj is null)
            {
                throw new ArgumentNullException(nameof(obj), "obj is null.");
            }

            if (i == 0)
            {
                throw new ArgumentException("i parameter is invalid.", nameof(i));
            }

            if (j < 0 || j > 10)
            {
                throw new ArgumentOutOfRangeException(nameof(j), "j is out of range.");
            }

            if (throwException)
            {
                throw new Exception("exception is thrown.");
            }
        }
    }
}
