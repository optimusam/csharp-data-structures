namespace Graphs
{
    public class GraphTraversal<T> where T : IComparable<T>
    {
        public static List<List<T>> Bfs(Dictionary<T, List<T>> graph, T source)
        {
            var levelOrder = new List<List<T>>();

            if (graph.ContainsKey(source) == false)
            {
                return levelOrder;
            }

            ISet<T> visited = new HashSet<T>();
            Queue<T> q = new();
            q.Enqueue(source);
            visited.Add(source);

            while (q.Count > 0)
            {
                List<T> sameLevel = new();
                int size = q.Count;
                for (int i = 0; i < size; i++)
                {
                    T node = q.Dequeue();
                    sameLevel.Add(node);
                    foreach (var neighbour in graph[node])
                    {
                        if (visited.Contains(neighbour) == false)
                        {
                            q.Enqueue(neighbour);
                            visited.Add(neighbour);
                        }
                    }
                }
                levelOrder.Add(sameLevel);
            }
            return levelOrder;
        }

        public static List<T> Dfs(Dictionary<T, List<T>> graph, T source)
        {
            List<T> res = new();
            var visited = new HashSet<T>();
            DfsHelper(graph, visited, source, res);
            return res;
        }

        private static void DfsHelper(Dictionary<T, List<T>> graph, HashSet<T> visited,
            T source, List<T> res)
        {
            if (!graph.ContainsKey(source) || visited.Contains(source))
            {
                return;
            }
            res.Add(source);
            visited.Add(source);
            foreach (var neighbour in graph[source])
            {
                DfsHelper(graph, visited, neighbour, res);
            }
        }
    }
}

