using System;

namespace ExceptionHandling
{
    public static class ThrowingExceptions
    {
        public static void CheckParameterAndThrowException(object obj)
        {
            if (obj is null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
        }

        public static void CheckBothParametersAndThrowException(object obj1, object obj2)
        {
            if (obj1 is null)
            {
                throw new ArgumentNullException(nameof(obj1));
            }

            if (obj2 is null)
            {
                throw new ArgumentNullException(nameof(obj2));
            }
        }

        public static string CheckStringAndThrowException(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentNullException(nameof(str));
            }

            return str;
        }

        public static string CheckBothStringsAndThrowException(string str1, string str2)
        {
            if (string.IsNullOrEmpty(str1))
            {
                throw new ArgumentNullException(nameof(str1));
            }

            if (string.IsNullOrEmpty(str2))
            {
                throw new ArgumentNullException(nameof(str2));
            }

            return string.Concat(str1, str2);
        }

        public static int CheckEvenNumberAndThrowException(int evenNumber)
        {
            if (evenNumber % 2 != 0)
            {
                throw new ArgumentException($"{evenNumber} parameter is not even.", nameof(evenNumber));
            }

            return evenNumber;
        }

        public static int CheckCandidateAgeAndThrowException(int candidateAge, bool isCandidateWoman)
        {
            if (isCandidateWoman && (candidateAge < 16 || candidateAge > 58))
            {
                throw new ArgumentOutOfRangeException(nameof(candidateAge), $"{candidateAge} is less than 16 or greater then 58");
            }

            if (!isCandidateWoman && (candidateAge < 16 || candidateAge > 63))
            {
                throw new ArgumentOutOfRangeException(nameof(candidateAge), $"{candidateAge} is less than 16 or greater then 63");
            }

            return candidateAge;
        }

        public static string GenerateUserCode(int day, int month, string username)
        {
            if (day > 31 || day < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(day), $"{day} is less then 1 or greater then 31.");
            }

            if (month > 12 || month < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(month), $"{month} is less then 1 or greater then 12.");
            }

            if (string.IsNullOrEmpty(username))
            {
                throw new ArgumentNullException(nameof(username));
            }

            return $"{username}-{day}{month}";
        }
    }
}
