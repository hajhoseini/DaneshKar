using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExamples
{
    public class ListMethods
    {
        public bool FindDuplicate(List<int> numbers)
        {
            bool result = false;

            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = 0; j < numbers.Count; j++)
                {
                    if (i != j && numbers[i] == numbers[j])
                    {
                        result = true;
                        break;
                    }
                }
            }

            return result;
        }

        public int GetSecondLargestNumber(List<int> numbers)
        {
            int largest = int.MinValue;
            int second = int.MinValue;
            foreach (int item in numbers)
            {
                if (item > largest)
                {
                    second = largest;
                    largest = item;
                }
                else if (item > second)
                    second = item;
            }

            return second;
        }

        public int GetSecondLargestNumber2(List<int> numbers)
        {
            var list = numbers;
            list.Sort();
            int largest = list[list.Count - 1];
            list.Remove(largest);
            return list[list.Count - 1];
        }

        public List<int> Inverse(List<int> numbers)
        {
            List<int> result = new List<int>();
            for(int i = numbers.Count - 1; i >= 0; i--)
            {
                result.Add(numbers[i]);
            }

            return result;
        }
    }
}
