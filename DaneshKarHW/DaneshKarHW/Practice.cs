using System.Text;

namespace DaneshKarHW
{
    internal class Practice
    {
        #region Practice1 - IsAnagram
        public bool IsAnagramByLinq(string first, string second)
        {
            if (first == second)
                return true;

            if (first.Length != second.Length)
                return false;

            return first.OrderBy(x => x).SequenceEqual(second.OrderBy(x => x));
        }

        public bool IsAnagramByList(string first, string second)
        {
            if (first == second)
                return true;

            if (first.Length != second.Length)
                return false;

            List<char> firstList = first.ToList();
            firstList.Sort();

            List<char> secondList = second.ToList();
            secondList.Sort();

            return firstList.SequenceEqual(secondList);
        }
        #endregion

        #region Practice2 - AddDigits
        public int AddDigits(int number)
        {
            while (number >= 10)
            {
                int sum = 0;
                foreach (char item in number.ToString())
                {
                    sum += Convert.ToInt32(item.ToString());
                }

                number = AddDigits(sum);
            }

            return number;
        }
        #endregion

        #region MyRegion Practice3 - IsUgly  

        public bool IsUgly(int number)
        {
            // Base Cases
            if (number <= 0)
                return false;

            if (number == 1)
                return true;

            // Condition to check if the number is divided by 2, 3 or 5            
            if (number % 2 == 0)
                return IsUgly(number / 2);
            else if (number % 3 == 0)
                return IsUgly(number / 3);
            else if (number % 5 == 0)
                return IsUgly(number / 5);

            return false;
        }

        #endregion

        #region Practice4 - MoveZeroes
        public void MoveZeroes(int[] numbers)
        {
            Queue<int> queue = new Queue<int>();
            int zeroCount = 0;
            foreach (int item in numbers)
            {
                if (item > 0)
                    queue.Enqueue(item);
                else
                    zeroCount++;
            }

            for (int i = 0; i < zeroCount; i++)
            {
                queue.Enqueue(0);
            }

            string result = string.Join(",", queue);
            MessageBox.Show($"result is {result}");
        }
        #endregion

        #region Practice4 - WordPattern
        public bool WordPattern(string pattern, string s)
        {
            string[] sArray = s.Split(' ');
            if (pattern.Length != sArray.Length)
                return false;

            Dictionary<char, string> dictionary = new Dictionary<char, string>();
            for(int i = 0; i < pattern.Length; i++)
            {
                if (!dictionary.ContainsKey(pattern[i]) && !dictionary.ContainsValue(sArray[i]))
                {
                    dictionary.Add(pattern[i], sArray[i]);
                }
            }

            StringBuilder newPattern = new StringBuilder();
            foreach (char c in pattern)
            {
                if (dictionary.ContainsKey(c))
                {
                    newPattern.Append(dictionary[c]);
                    newPattern.Append(" ");
                }
            }           

            return (newPattern.ToString().Trim() == s);
        }
        #endregion
    }
}
