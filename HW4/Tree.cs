namespace HW4;

public class Tree<T> where T : IComparable<T>
{
    public T value { get; set; }
    public Tree<T> next { get; set; }
    public Tree<T> right { get; set; }
    public Tree<T> left { get; set; }

    public Tree(T value)
    {
        this.value = value;
    }
}