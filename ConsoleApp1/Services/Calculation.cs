namespace ConsoleApp1.Services
{
    public static class Calculation
    {
        public static bool IsPrime(int num)
        {
            if (num < 2) return false;
            int i = 2;
            while (i <= num / i)
            {
                if (num % i == 0) return false;
                i++;
            }
            return true;
        }

        public static bool IsEven(int num)
        {
            return num % 2 == 0;
        }
    }
}