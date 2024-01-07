namespace Generic.Stack
{
    public class CustomStack
    {
        int[] items = new int[10];
        int current = 0;

        public void Push(int item)
        {
            items[current] = item;
            current++;
        }

        public int Pop() 
        {
            var value = items[--current];
            items[current] = 0;
            return value;
        }
    }
}
