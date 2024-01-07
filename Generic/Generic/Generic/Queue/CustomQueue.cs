namespace Generic.Queue
{
    public class CustomQueue
    {
        /*
        public void test()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("a");
            queue.Dequeue();
        }
        */

        int[] items = new int[10];
        int head = 0;
        int back = 0;

        public void Enqueue(int item)
        {            
            items[back] = item;
            back++;
        }

        public int Dequeue()
        {
            int value = items[head];
            items[head] = 0;
            head++;
            return value;
        }

        public int Peek()
        {
            return items[head];
        }
    }
}
