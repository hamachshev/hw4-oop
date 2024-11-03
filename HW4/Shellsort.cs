namespace HW4;

public class Shellsort<T> where T : IComparable<T>
{
    public static void sort(T[] array, int gap = 0)
    {
        if (gap == 0) gap = array.Length / 2;
        for (int i = 0; i < array.Length - gap; i++)
        {
            if (array[i].CompareTo(array[i + gap]) > 0)
            {
                T temp = array[i];
                array[i] = array[i + gap];
                array[i + gap] = temp;
            }
        }

        gap /= 2;
        if (gap <= 0)
        {
            return;
        }
        sort(array, gap);
    }
}