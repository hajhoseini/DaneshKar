namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            string operand1 = Console.ReadLine();

            Console.WriteLine("Enter the second number:");
            string operand2 = Console.ReadLine();

            Console.WriteLine("Enter the operator:");

            var operator1 = Console.ReadLine();

            if (!CheckValidation(operand1, operand2, operator1))
                return;

            int result = 0;

            switch (operator1)
            {
                case "+":
                    result = Convert.ToInt32(operand1) + Convert.ToInt32(operand2);
                    break;
                case "-":
                    result = Convert.ToInt32(operand1) - Convert.ToInt32(operand2);
                    break;
                case "*":
                    result = Convert.ToInt32(operand1) * Convert.ToInt32(operand2);
                    break;
                case "/":
                    result = Convert.ToInt32(operand1) / Convert.ToInt32(operand2);
                    break;
            }

            Console.WriteLine("result = " + result);
            Console.ReadKey();
        }

        static bool CheckValidation(string operand1, string operand2, string operatorr)
        {
            if (!int.TryParse(operand1, out int n1))
            {
                Console.WriteLine("First number is not valid!");
                return false;
            }

            if (!int.TryParse(operand2, out int n2))
            {
                Console.WriteLine("Second number is not valid!");
                return false;
            }

            if (!(operatorr == "+" || operatorr == "-" || operatorr == "*" || operatorr == "/"))
            {
                Console.WriteLine("The operator is not valid!");
                return false;
            }

            return true;
        }
    }
}