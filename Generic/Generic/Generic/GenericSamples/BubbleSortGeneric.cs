using System.Collections;

namespace Generic.GenericSamples
{
    public class BubbleSortGeneric<T>
    {
        public static void Swap(ref T a, ref T b)
        {
            T c = a;
            a = b;
            b = c;
        }

        public static T[] Sort(T[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    //if (array[j] > array[j + 1])
                    if (string.Compare(array[j].ToString(), array[j + 1].ToString()) == 1)
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }

            return array;
        }
    }
}