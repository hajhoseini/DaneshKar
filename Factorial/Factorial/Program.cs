namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            //long factorial = Factorial(Convert.ToInt32(Console.ReadLine()));
            long factorial = RecursiveFactorial(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("result = " + factorial);
        }

        static long Factorial(int input)
        {
            int result = 1;

            while(input > 1)
            {
                result *= input;
                input--;
            }

            return result;
        }

        static long RecursiveFactorial(int input)
        {
            if (input == 0)
                return 1;
            else
                return input * RecursiveFactorial(input - 1);
        }
    }
}