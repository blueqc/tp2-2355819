namespace FizzBuzz
{
    public class Program
    {
        private const int MIN = 1;
        private const int MAX = 100;

        public static void Main(string[] args)
        {
            for (int i = MIN; i <= MAX; i++)
            {
                bool isDivisbleBy3 = IsDivisibleBy(i, 3);
                bool isDivisbleBy5 = IsDivisibleBy(i, 5);

                if (isDivisbleBy3 && isDivisbleBy5)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (isDivisbleBy3)
                {
                    Console.WriteLine("Fizz");
                }
                else if (isDivisbleBy5)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool IsDivisibleBy(int value, int divisor)
        {
            return value % divisor == 0;
        }
    }
}