namespace Generic.GenericSamples
{
    public class BubbleSort
    {
        public static void Swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }

        public static int[] Sort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }

            return array;
        }
    }
}