namespace Trees;

public class Traversal<T>
{

    public static List<T> Inorder(TreeNode<T>? root)
    {
        List<T> list = new();
        InorderHelper(root, list);
        return list;
    }

    private static void InorderHelper(TreeNode<T>? root, List<T> list)
    {
        if (root is null)
        {
            return;
        }
        InorderHelper(root.Left, list);
        list.Add(root.Data!);
        InorderHelper(root.Right, list);
    }

    public static List<T> Postorder(TreeNode<T>? root)
    {
        List<T> list = new();
        PostorderHelper(root, list);
        return list;
    }

    private static void PostorderHelper(TreeNode<T>? root, List<T> list)
    {
        if (root is null)
        {
            return;
        }
        PostorderHelper(root.Left, list);
        PostorderHelper(root.Right, list);
        list.Add(root.Data!);
    }


    public static List<T> Preorder(TreeNode<T>? root)
    {
        List<T> list = new();
        PreorderHelper(root, list);
        return list;
    }

    private static void PreorderHelper(TreeNode<T>? root, List<T> list)
    {
        if (root is null)
        {
            return;
        }
        list.Add(root.Data!);
        PreorderHelper(root.Left, list);
        PreorderHelper(root.Right, list);
    }

    public static List<T> LevelOrder(TreeNode<T>? root)
    {
        List<T> list = new();

        if (root is null)
        {
            return list;
        }

        Queue<TreeNode<T>> q = new();
        q.Enqueue(root);
        while(q.Count > 0)
        {
            TreeNode<T> node = q.Dequeue(); 
            list.Add(node.Data!);
            if (node.Left is not null)
            {
                q.Enqueue(node.Left);
            }
            if (node.Right is not null)
            {
                q.Enqueue(node.Right);
            }
        }

        return list;
    }

}
