using System;
using trees;
namespace Trees.Test
{
	public class TreeFixture: IDisposable
	{
        /*
         *  1
         *  /\
         *  2 3
         *  /\
         *  4 5
         */
        private TreeNode<int>? _root;
		public TreeFixture()
		{
            _root = new TreeNode<int>
            {
                Data = 1,
                Left = new TreeNode<int> { Data = 2 },
                Right = new TreeNode<int> { Data = 3 }
            };
            _root.Left.Left = new TreeNode<int> { Data = 4 };
            _root.Left.Right = new TreeNode<int> { Data = 5 };
     
        }
        public TreeNode<int>? Root { get => _root; }

        public void Dispose()
        {
            _root = null;
        }
    }
}

