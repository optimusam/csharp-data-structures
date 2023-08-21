namespace trees;

public class Traversal<T>
{
    private List<T> _list;

    public Traversal()
    {
        _list = new();
    }

    public List<T>? Inorder(TreeNode<T>? root)
    {
        if(root is null)
        {
            return null;
        }
        Inorder(root.Left);
        _list.Add(root.Data!);
        Inorder(root.Right);
        return _list;
    }

    public List<T>? Postorder(TreeNode<T>? root)
    {
        if(root is null)
        {
            return null;
        }
        Postorder(root.Left);
        Postorder(root.Right);
        _list.Add(root.Data!);
        return _list;
    }

    public List<T>? Preorder(TreeNode<T>? root)
    {
        if(root is null)
        {
            return null;
        }
        _list.Add(root.Data!);
        Preorder(root.Left);
        Preorder(root.Right);
        return _list;
    }
}
