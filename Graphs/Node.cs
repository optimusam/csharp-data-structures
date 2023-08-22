using System;
namespace Graphs
{
	public class Node<T>
	{
		private T _data;
		private List<T> _neighbours;
		public Node(T data)
		{
			_data = data;
			_neighbours = new();
		}
		public T Data { get => _data; }
		public List<T> Neighbours { get => _neighbours; }

	}
}

