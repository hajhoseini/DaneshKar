namespace SumOfTwoArrayElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] arrayNumbers = { 28, 16, 75, 28, 1 };

            string result = Compare(arrayNumbers, number);
            if(result == "")
                Console.WriteLine("Not Found!");
            else
                Console.WriteLine("Output: " + result);
        }

        static string Compare(int[] arrayNumbers, int number)
        {
            string result = "";

            for(int i = 0; i < arrayNumbers.Length; i++)
            {
                for(int j= i + 1; j < arrayNumbers.Length; j++)
                {
                    if(arrayNumbers[i] + arrayNumbers[j] == number)
                    {
                        result = result + "[" + i + " , " + j + "]";
                        break;
                    }
                }
            }

            return result;
        }
    }
}