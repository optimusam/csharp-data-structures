using System;
namespace linkedlist
{
	public class ListEmptyException: Exception
	{
		public ListEmptyException(string message) : base(message) { } 
	}
}

