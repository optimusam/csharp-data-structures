using System;
using System.Collections.Generic;

namespace Graphs
{
    public class GraphBuilder<T> where T : IComparable<T>
    {
        private Dictionary<T, List<T>> _dict;

        public GraphBuilder()
        {
            _dict = new();
        }

        public Dictionary<T, List<T>> CreateGraph(List<List<T>> edges)
        {
            foreach (var edge in edges)
            {
                if (_dict.ContainsKey(edge[0]) == false)
                {
                    _dict.Add(edge[0], new List<T>());
                }
                if (_dict.ContainsKey(edge[1]) == false)
                {
                    _dict.Add(edge[1], new List<T>());
                }
                _dict[edge[0]].Add(edge[1]);
            }
            return _dict;
        }
    }
}

