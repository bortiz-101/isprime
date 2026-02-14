using System;

namespace Utils
{
    public class Prime
    {
        public bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;
            for (int i = 3; i <= Math.Sqrt(number); i ++)
            {
                if (number % i == 0) 
                    return false;
            }
            return true;
        }
    }
}
