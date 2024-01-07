namespace Generic.Queue
{
    public class CustomQueueGeneric<T>
    {
        T[] items = new T[10];
        int head = 0;
        int back = 0;

        public void Enqueue(T item)
        {
            if(back > items.Length)
            {
                Array.Resize(ref items, items.Length + 10);
            }

            items[back] = item;
            back++;
        }

        public T Dequeue()
        {
            if(head > back)
            {
                return default(T);
            }

            T value = items[head];
            items[head] = default(T);
            head++;
            return value;
        }

        public T Peek()
        {
            return items[head];
        }
    }
}
