namespace Stack.StackExamples
{
    public class MyStack
    {
        public bool IsValid(char[] array)
        {
            if (array.Length % 2 == 0)
            {
                Stack<char> stack = new Stack<char>();
                char topElement = ' ';

                foreach (char item in array)
                {
                    if(stack.Count > 0)
                        topElement = stack.Peek();

                    if (IsMatch(topElement, item))
                        stack.Pop();
                    else
                        stack.Push(item);
                }

                return stack.Count == 0;
            }

            return false;
        }

        public bool IsMatch(char start, char end)
        {
            if (start == '[' && end == ']' ||
                start == '(' && end == ')' ||
                start == '{' && end == '}' ||
                start == '>' && end == '<')
            {
                return true;
            }

            return false;
        }

        public int CountOfUniqueItems(int[] array)
        {
            ;
            Stack<int> stack = new Stack<int>();
            stack.Push(array[0]);

            for (int i = 1; i < array.Length; i++)
            {
                int temp = stack.Peek();
                if (temp != array[i])
                    stack.Push(array[i]);
            }

            return stack.Count;
        }        
    }
}
