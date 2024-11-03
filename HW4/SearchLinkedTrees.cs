namespace HW4;

using System.Collections.Generic;

public class SearchLinkedTrees<T> where T : IComparable<T>
{
    public static bool search(LinkedList<Tree<T>> root, T value)
    {
        Console.WriteLine(root.First.Value.value);
        if (root.First?.Value.value.CompareTo(value) == 0) return true;
        if (root.First?.Value.left != null)
        {
            if (search(root.First.Value.left, value)) return true;
        }

        if (root.First?.Value.right != null)
        {
            if (search(root.First.Value.right, value)) return true;
        }
        root.RemoveFirst();
        if (root.Count > 0)
        {
            return search(root, value);
        }
        else
        {
            return false;
        }

    }

    public static bool search(Tree<T> root, T value)
    {
        if (root.value.CompareTo(value) == 0) return true;
        if(root.left != null) if(search(root.left, value)) return true;
        if(root.right != null)  if(search(root.right, value)) return true;
        
        return false;
        
    }
}