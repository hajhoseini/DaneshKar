namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String:");
            string input = Console.ReadLine();
            
            //var resultstring = new string(input.ToCharArray().Reverse().ToArray());

            bool result = IsPalindrome(input);
            Console.WriteLine("Output : " + result);          
        }

        static bool IsPalindrome(string input)
        {
            string palindrome = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                palindrome += input[i];
            }

            return input == palindrome ? true : false;            
        }
    }
}