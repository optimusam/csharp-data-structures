using Graphs;

namespace UnitTests.Graphs
{
	public class GraphFixture
	{
        private Dictionary<string, List<string>> _graph;
        public GraphFixture()
		{
            GraphBuilder<string> _graphBuilder = new GraphBuilder<string>();
            List<List<string>> edges = new List<List<string>>
            {
                new List<string> {"sameer", "aprajita"},
                new List<string> { "aprajita", "sameer"},
                new List<string> {"mehul","sameer"},
                new List<string> {"sameer","mehul"},
                new List<string> {"aprajita","avi"},
            };
            _graph = _graphBuilder.CreateGraph(edges);
        }
        public Dictionary<string, List<string>> Graph { get => _graph; }
    }
}

