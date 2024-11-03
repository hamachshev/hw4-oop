namespace HW4;

using System.Collections.Generic;

public class LinkedListToString <T>
{
    public static void toString(LinkedList<T> list)
    {
        if (list.Count == 0) return;
        Console.WriteLine(list.First.Value);
        list.RemoveFirst();
        toString(list);
    }
}