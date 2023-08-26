using System.Data.Common;

namespace ListExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 5, 7, 6, 12, 23, 5, 16, 19, 6, 20 };

            ListMethods listMethods = new ListMethods();

            List<int> result = listMethods.Inverse(list);

            string str = "";
            foreach (int i in result)
            {
                str += i + ",";
            }
            Console.WriteLine("Inverse = {" + str + "}");

            var find = listMethods.FindDuplicate(list);
            if(find)
                Console.WriteLine("The list has duplicate numbers!");

            int secondLargestNumber = 0;
            secondLargestNumber = listMethods.GetSecondLargestNumber(list);
            secondLargestNumber = listMethods.GetSecondLargestNumber2(list);
            Console.WriteLine("The Second Largest Number Is:" + secondLargestNumber);

            Console.ReadKey();
        }
    }
}