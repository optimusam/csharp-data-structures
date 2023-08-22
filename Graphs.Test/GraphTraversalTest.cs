using System;
using FluentAssertions;
namespace Graphs.Test
{
    [Collection("Graph Collection")]
    public class GraphTraversalTest
	{
        private GraphFixture _fixture;

        public GraphTraversalTest(GraphFixture fixture)
		{
            _fixture = fixture;
		}

        [Fact]
        public void Traversal_Bfs_ShouldReturnCorrectOrder()
        {
            // Arrange
            var graph = _fixture.Graph;
            var source = "sameer";
            // Act
            var levelOrder = GraphTraversal<string>.Bfs(graph, source);
            // Assert
            List<List<string>> expected = new List<List<string>>
            {
                new List<string> {"sameer"},
                new List<string> {"mehul", "aprajita"},
                new List<string> {"avi"}
            };

            levelOrder.Should().BeEquivalentTo(expected);
        }
        
        [Fact]
        public void Traversal_Bfs_InvalidSourceShouldReturnEmptyList()
        {
            // Arrange
            var graph = _fixture.Graph;
            var source = "this does not exist in the graph";
            // Act
            var levelOrder = GraphTraversal<string>.Bfs(graph, source);
            // Assert
            levelOrder.Should().BeEmpty();
        }

	}
}

