namespace Maps;

public class MyHashMap<TKey, TVal> where TKey: IEquatable<TKey>, IComparable<TKey>
{
    private const int Size = 10000;

    private Node<TKey, TVal>?[] _nodes; 
    
    public MyHashMap() {
        _nodes = new Node<TKey, TVal>?[Size];
    }
    
    public void Add(TKey key, TVal value) {
        int i = HashFunction(key);
        var node = _nodes[i];
        while(node is not null) {
            if(node.Key!.Equals(key)) {
                node.Value = value;
                return;
            }
            node = node?.Next;
        }
        var newNode = new Node<TKey, TVal>() { Key = key, Value = value, Next = _nodes[i] };
        _nodes[i] = newNode;
    }
    
    private TVal Get(TKey key) {
        int i = HashFunction(key);
        var node = _nodes[i];
        while(node is not null) {
            if(node.Key!.Equals(key)) return node.Value;
            node = node?.Next;
        }
        throw new ArgumentException($"The Key {key} does not exist in the Map.");
    }
    
    public bool ContainsKey(TKey key) {
        int i = HashFunction(key);
        var node = _nodes[i];
        while(node is not null) {
            if(node.Key!.Equals(key)) return true;
            node = node?.Next;
        }

        return false;
    }
    
    public void Remove(TKey key) {
        int i = HashFunction(key);
        var cur = _nodes[i];
        Node<TKey, TVal>? prev = null;
        while(cur is not null) {
            if(cur.Key!.Equals(key)) {
                if(prev is null) {
                    _nodes[i] = cur.Next;
                }
                else {
                    prev.Next = cur.Next;
                }
                break;
            }
            prev = cur;
            cur = cur.Next;
        }

    }

    public TVal this[TKey key]
    {
        get => Get(key);
        set => Add(key, value);
    }

    private int HashFunction(TKey key) {
        return ( Math.Abs(key!.GetHashCode()) % Size );
    }
}

public class Node<TKey, TVal> {
    public required TKey Key {get; set;}
    public required TVal Value {get; set;}
    public Node<TKey, TVal>? Next { get; set; }
}