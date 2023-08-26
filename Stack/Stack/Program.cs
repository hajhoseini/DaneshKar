using Stack.StackExamples;

namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack stack = new MyStack();

            int[] nums = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };            
            int result = stack.CountOfUniqueItems(nums);

            char[] input = new char[] { '(', ')'};
            bool output = stack.IsValid(input);

            input = new char[] { '(', ')', '[', ']', '{', '}' };
            output = stack.IsValid(input);

            input = new char[] { '(', ']' };
            output = stack.IsValid(input);

            input = new char[] { '(', '[', ']', ')', '[', ']', '{', '(', ')', '}' };
            output = stack.IsValid(input);
        }
    }
}