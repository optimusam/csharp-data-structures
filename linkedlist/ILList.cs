namespace linkedlist
{
    public interface ILList<T>
    {
        void AddFirst(T val);
        void AddLast(T val);
        Node<T>? GetHead();
        Node<T>? GetTail();
        T RemoveFirst();
        T RemoveLast();
    }
}