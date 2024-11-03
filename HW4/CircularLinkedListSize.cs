namespace HW4;

public class CircularLinkedListSize<T>
{
    public static int size(CircularLinkedListNode<T> root, CircularLinkedListNode<T> head)
    {
        if (head == null)
            head = root;
        else if (head == root)
            return 0;
        
        return 1 + size(root.Next, head);
    }
    
    
 
}