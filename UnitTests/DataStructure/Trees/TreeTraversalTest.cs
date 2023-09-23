using DataStructure.Trees;

namespace UnitTests.DataStructure.Trees;

public class TreeTraversalTest : IClassFixture<TreeFixture>
{
    private readonly TreeFixture _fixture;

    public TreeTraversalTest(TreeFixture fixture)
    {
        _fixture = fixture;
    }

    [Fact]
    public void Traversal_PreorderTraversal_NonNullRootShouldReturnCorrectOrder()
    {
        // Arrange
        var root = _fixture.Root;

        // Act
        var preorderList = Traversal<int>.Preorder(root);

        // Assert
        var expected = new List<int> { 1, 2, 4, 5, 3 };
        Assert.Equal<int>(expected, preorderList);
    }

    [Fact]
    public void Traversal_PreorderTraversal_NullRootShouldReturnEmptyList()
    {
        // Arrange
        TreeNode<int>? root = null;

        // Act
        var preorderList = Traversal<int>.Preorder(root);

        // Assert
        Assert.Empty(preorderList);
    }

    [Fact]
    public void Traversal_InorderTraversal_NonNullRootShouldReturnCorrectOrder()
    {
        // Arrange
        var root = _fixture.Root;

        // Act
        var inorderList = Traversal<int>.Inorder(root);

        // Assert
        var expected = new List<int> { 4, 2, 5, 1, 3 };
        Assert.Equal<int>(expected, inorderList);
    }


    [Fact]
    public void Traversal_InorderTraversal_NullRootShouldReturnEmptyList()
    {
        // Arrange
        TreeNode<int>? root = null;
        // Act
        var inorderList = Traversal<int>.Inorder(root);

        // Assert
        Assert.Empty(inorderList);
    }

    [Fact]
    public void Traversal_PostorderTraversal_NonNullRootShouldReturnCorrectOrder()
    {
        // Arrange
        var root = _fixture.Root;

        // Act
        var postorderList = Traversal<int>.Postorder(root);

        // Assert
        var expected = new List<int> { 4, 5, 2, 3, 1 };
        Assert.Equal<int>(expected, postorderList);
    }

    [Fact]
    public void Traversal_PostorderTraversal_NullRootShouldReturnEmptyList()
    {
        // Arrange
        TreeNode<int>? root = null;

        // Act
        var postorderList = Traversal<int>.Postorder(root);

        // Assert
        Assert.Empty(postorderList);
    }

    [Fact]
    public void Traversal_LevelOrder_NonNullRootShouldReturnCorrectOrder()
    {
        // Arrange
        var root = _fixture.Root;

        // Act
        var levelOrder = Traversal<int>.LevelOrder(root);

        // Assert
        var expected = new List<int> { 1, 2, 3, 4, 5 };
        Assert.Equal<int>(expected, levelOrder);
    }
}