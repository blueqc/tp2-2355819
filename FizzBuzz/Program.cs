namespace FizzBuzz
{
    public class Program
    {
        private const int MIN = 1;
        

        public static void Main(string[] args)
        {
            int max = AskMaxNumber();


            for (int i = MIN; i <= max; i++)
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

        public static int AskMaxNumber()
        {
            Console.WriteLine("Entrez un nombre :");
            int max = int.Parse(Console.ReadLine());

            return max;
        }
    }
}