using System;
namespace linkedlist;

public class LList<T> : ILList<T>
{
    private Node<T> _head;
    private Node<T> _tail;
    
    public LList()
    {
        _head = new Node<T> { };
        _tail = new Node<T> { };
        _head.Next = _tail;
        _tail.Prev = _head;
    }

    public void AddFirst(T val)
    {
        var newNode = new Node<T> { Data = val, Prev = _head, Next = _head.Next };
        _head.Next = newNode;
        newNode.Next!.Prev = newNode;
    }

    public void AddLast(T val)
    {
        var newNode = new Node<T> { Data = val, Prev = _tail.Prev, Next = _tail };
        _tail.Prev!.Next = newNode;
        _tail.Prev = newNode;
    }

    public Node<T>? GetHead()
    {
        if (_head.Next == _tail) return null;
        return _head.Next;
    }

    public Node<T>? GetTail()
    {
        if (_tail.Prev == _head) return null;
        return _tail.Prev;
    }

    public T RemoveFirst()
    {
        if(GetHead() is null)
        {
            throw new ListEmptyException("Cannot remove from an empty list");
        }
        var nodeToRemove = _head.Next;
        var nextNode = nodeToRemove!.Next;
        _head.Next = nextNode;
        nextNode!.Prev = _head;
        nodeToRemove.Next = null;
        nodeToRemove.Prev = null;
        return nodeToRemove.Data!;
    }

    public T RemoveLast()
    {
        if (GetTail() is null)
        {
            throw new ListEmptyException("Cannot remove from an empty list");
        }

        var nodeToRemove = _tail.Prev;
        var prevNode = nodeToRemove!.Prev;
        prevNode!.Next = _tail;
        _tail.Prev = prevNode;
        nodeToRemove.Next = null;
        nodeToRemove.Prev = null;
        return nodeToRemove.Data!;   
    }
}
