using System.Collections;
using Generic.GenericSamples;

namespace Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            GenericTest();
            StackTest();
        }

        public static void GenericTest()
        {
            Helper helper = new();

            SwapModel<int> swap = new SwapModel<int>() { X = 1, Y = 2 };
            var result = helper.Run(swap);

            SwapModel<char> swap2 = new SwapModel<char>() { X = 'a', Y = 'b' };
            var result2 = helper.Run(swap2);

            SwapModel<Student> swap3 = new SwapModel<Student>()
            {
                X = new Student() { Name = "Ali" },
                Y = new Student() { Name = "Hasan" }
            };
            var result3 = helper.Run(swap3);

            /*
            ArrayList array = new ArrayList();
            array.Add(5);
            array.Add("ssss");

            List<int> ints = new List<int>();
            ints.Add(1);
            ints.Add("sss");
            */

            int[] array = new int[] { 6, 2, 8, 4, 9 };
            //array = BubbleSort.Sort(array);

            array = BubbleSortGeneric<int>.Sort(array);            
        }

        public static void StackTest()
        {
            int[] array2 = new int[5];
            array2[1] = 30;
            array2[2] = 40;
            Array.Resize(ref array2, 20);


        }
    }
}