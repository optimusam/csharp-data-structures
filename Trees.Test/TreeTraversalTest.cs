namespace Trees.Test;
using trees;
public class TreeTraversalTest: IClassFixture<TreeFixture>
{

    private TreeFixture _fixture;
    public TreeTraversalTest(TreeFixture fixture)
    {
        _fixture = fixture;
    }

    [Fact]
    public void Traversal_PreorderTraversal_NonNullRootShouldReturnCorrectOrder()
    {
        // Arrange
        TreeNode<int>? root = _fixture.Root;
        Traversal<int> traversal = new Traversal<int>();

        // Act
        List<int>? preorderList = traversal.Preorder(root);

        // Assert
        List<int> expected = new List<int> { 1, 2, 4, 5, 3 };
        Assert.Equal<int>(expected, preorderList);
      
    }

    [Fact]
    public void Traversal_PreorderTraversal_NullRootShouldReturnNull()
    {
        // Arrange
        TreeNode<int>? root = null;
        Traversal<int> traversal = new Traversal<int>();

        // Act
        List<int>? preorderList = traversal.Preorder(root);

        // Assert
        Assert.Null(preorderList);      
    }

    [Fact]
    public void Traversal_InorderTraversal_NonNullRootShouldReturnCorrectOrder()
    {
        // Arrange
        TreeNode<int>? root = _fixture.Root;
        Traversal<int> traversal = new Traversal<int>();

        // Act
        List<int>? inorderList = traversal.Inorder(root);

        // Assert
        List<int> expected = new List<int> { 4, 2, 5, 1, 3 };
        Assert.Equal<int>(expected, inorderList);
    }


    [Fact]
    public void Traversal_InorderTraversal_NullRootShouldReturnNull()
    {
        // Arrange
        TreeNode<int>? root = null;
        Traversal<int> traversal = new Traversal<int>();

        // Act
        List<int>? inorderList = traversal.Inorder(root);

        // Assert
        Assert.Null(inorderList);
    }

    [Fact]
    public void Traversal_PostorderTraversal_NonNullRootShouldReturnCorrectOrder()
    {
        // Arrange
        TreeNode<int>? root = _fixture.Root;
        Traversal<int> traversal = new Traversal<int>();

        // Act
        List<int>? postorderList = traversal.Postorder(root);

        // Assert
        List<int> expected = new List<int> { 4, 5, 2, 3, 1 };
        Assert.Equal<int>(expected, postorderList);
    }

    [Fact]
    public void Traversal_PostorderTraversal_NullRootShouldReturnNull()
    {
        // Arrange
        TreeNode<int>? root = null;
        Traversal<int> traversal = new Traversal<int>();

        // Act
        List<int>? postorderList = traversal.Postorder(root);

        // Assert
        Assert.Null(postorderList);
    }

}

