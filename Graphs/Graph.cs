using System;
using System.Collections.Generic;

namespace Graphs
{
	public class GraphBuilder<T> where T: IComparable<T>
	{
		public Dictionary<T, List<T>> CreateGraph(List<List<T>> edges)
		{
			Dictionary<T, List<T>> dict = new();

            foreach (var edge in edges)
			{
				if (dict.ContainsKey(edge[0]) == false)
				{
					dict.Add(edge[0], new List<T>());
				}
                if (dict.ContainsKey(edge[1]) == false)
                {
                    dict.Add(edge[1], new List<T>());
                }
                dict[edge[0]].Add(edge[1]);
			}
			return dict;
		}
	}
}

