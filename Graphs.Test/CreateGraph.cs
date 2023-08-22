using Graphs;
using FluentAssertions;
namespace Graphs.Test;

public class CreateGraph
{
    [Fact]
    public void Graph_CreateGraph_NoEdgesShouldCreateEmptyGraph()
    {
        // Arrange
        GraphBuilder<int> graphBuilder = new GraphBuilder<int>();
        List<List<int>> edges = new List<List<int>>{};

        // Act
        var graph = graphBuilder.CreateGraph(edges);

        // Assert
        graph.Should().BeEmpty();
    }

    [Fact]
    public void Graph_CreateGraph_ShouldCreateStringGraph()
    {
        // Arrange
        GraphBuilder<string> graphBuilder = new GraphBuilder<string>();
        List<List<string>> edges = new List<List<string>>
        {
            new List<string> {"sameer", "aprajita"},
            new List<string> { "aprajita", "sameer"},
            new List<string> {"mehul","sameer"},
            new List<string> {"sameer","mehul"},
            new List<string> {"aprajita","avi"},
        };

        // Act
        var graph = graphBuilder.CreateGraph(edges);

        // Assert
        var neighboursOfSameer = new List<string> { "aprajita", "mehul" };
        var neighboursOfAprajita = new List<string> { "sameer", "avi"};
        var neighboursOfMehul = new List<string> { "sameer"};

        graph["sameer"].Should().BeEquivalentTo(neighboursOfSameer);
        graph["aprajita"].Should().BeEquivalentTo(neighboursOfAprajita);
        graph["mehul"].Should().BeEquivalentTo(neighboursOfMehul);
        graph["avi"].Should().BeEmpty();
    }
    
    [Fact]
    public void Graph_CreateGraph_ShouldCreateGraph()
    {
        // Arrange
        GraphBuilder<int> graphBuilder = new GraphBuilder<int>();
        List<List<int>> edges = new List<List<int>>
        {
            new List<int> {1,2},
            new List<int> {1,3},
            new List<int> {2,3}
        };

        // Act
        var graph = graphBuilder.CreateGraph(edges);

        // Assert
        var neighboursOf1 = new List<int> { 3, 2 };
        var neighboursOf2 = new List<int> { 3 };

        graph[1].Should().BeEquivalentTo(neighboursOf1);
        graph[2].Should().BeEquivalentTo(neighboursOf2);
        graph[3].Should().BeEmpty();

    }


}
