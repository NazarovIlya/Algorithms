using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
	internal class RBTree<T>
	{
		TreeNode<T> Root { get; set; }

		public bool SearchNode(T value)
		{
			TreeNode<T> node = SearchNode(Root, value);
			if (node != null) { return true; }
			else { return false; }
		}
		private TreeNode<T> SearchNode(TreeNode<T> node, T value)
		{
			if (node.Value.Equals(value))
			{
				return node;
			}
			else
			{
                foreach (TreeNode<T> child in node.Children)
                {
					TreeNode<T> result = SearchNode(child, value);
					if (result != null) 
						return result;
                }
            }
			return null;
		}

	}
}
