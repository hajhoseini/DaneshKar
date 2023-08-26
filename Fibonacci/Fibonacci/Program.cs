namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            Console.WriteLine("Enter Number:");
            number = Convert.ToInt32(Console.ReadLine());
            Fibonacci(number);

            Console.WriteLine("Enter Number:");
            number = Convert.ToInt32(Console.ReadLine());
            Print(RecursiveFibonacci(number));
        }

        static void Fibonacci(int count)
        {
            int first = 1;
            int second = 0;
            int sum = 0;

            for (int i = 0; i < count; i++)
            {
                sum = first + second;
                Print(sum);

                first = second;
                second = sum;
            }
        }

        static void Print(int input)
        {
            Console.WriteLine(input);
        }

        static int RecursiveFibonacci(int count)
        {
            if (count == 1 || count == 2)
            {
                return 1;
            }
            else
            {
                return RecursiveFibonacci(count - 2) + RecursiveFibonacci(count - 1);
            }
        }        
    }
}