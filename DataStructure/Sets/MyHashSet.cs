namespace DataStructure.Sets;

/// <summary>
/// HashSet implemented using collision chaining technique.
/// </summary>
public class MyHashSet<T> where T: IEquatable<T>
    
{
    private const int Size = (int)1e4;
    private Node<T>?[] _nodes;
    public MyHashSet()
    {
        _nodes = new Node<T>[Size];
    }
    
    public void Add(T key) {
        var pos = HashFunction(key);
        if (_nodes[pos] is null)
        {
            _nodes[pos] = new Node<T>() { Key = key };
        }
        else
        { 
            if(Contains(key)) return;
            var newNode = new Node<T>() { Key = key, Next = _nodes[pos]};
            _nodes[pos] = newNode;
        }
    }

    public void Remove(T key)
    {
        int pos = HashFunction(key);
        if (_nodes[pos] is null) return;
        Node<T>? cur = _nodes[pos];
        Node<T>? prev = null;
        while (cur is not null)
        {
            if (cur.Key.Equals(key))
            {
                if (prev is null)
                {
                    _nodes[pos] = cur.Next;
                }
                else
                { 
                    prev.Next = cur.Next;
                }
                return;
            }
            prev = cur;
            cur = cur.Next;
        }
    }
    
    public bool Contains(T key)
    {
        int pos = HashFunction(key);
        if (_nodes[pos] is null) return false;
        Node<T>? node = _nodes[pos];
        while (node is not null)
        {
            if (node.Key.Equals(key)) return true;
            node = node.Next;
        }
        return false;
    }
    
    private static int HashFunction(T key)
    {
        int pos = Math.Abs(key.GetHashCode()) % Size;
        return pos;
    }
    
}

public class Node<T>
{
    public required T Key { get; set; }
    public Node<T>? Next { get; set; }
}
