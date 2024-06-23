namespace LabWorkFunctions
{
    public static class Functions
    {
        public static ulong GetFactorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            if (n > 0)
            {
                return (ulong)n * GetFactorial(n - 1);
            }
            else
            {
                return 1 / GetFactorial(-n);
            }
        }

        public static double GetPower(double x, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            if (n < 0)
            {
                return 1 / GetPower(x, -n);
            }
            else
            {
                return (double)x * GetPower(x, n - 1);
            }
        }

        static double FastGetPower(double x, int n)
        {
            if (n < 0)
            {
                return -1;
            }
            else if (n == 0)
            {
                return 1;
            }
            else if (n == 1)
            {
                return x;
            }
            else if (n % 2 == 0)
            {
                double y = FastGetPower(x, n / 2);
                return y * y;
            }
            else
            {
                double y = FastGetPower(x, (n - 1) / 2);
                return y * y * x;
            }
        }
    }
}
