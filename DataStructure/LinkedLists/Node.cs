namespace DataStructure.LinkedLists;

public class Node<T>
{
    public T? Data { get; set; }
    public Node<T>? Prev { get; set; } = null;
    public Node<T>? Next { get; set; } = null;
}