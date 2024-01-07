namespace Generic.Stack
{
    public class CustomStackGeneric<T>
    {
        T[] items = new T[10];
        int current = 0;

        public void Push(T item)
        {
            if(current > items.Length)
            {
                Array.Resize(ref items, items.Length + 10);
            }

            items[current] = item;
            current++;
        }

        public T Pop()
        {
            var value = items[--current];
            items[current] = default(T);

            return value;
        }
    }
}
