using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
	internal class TreeNode<T>
	{
		public T Value { get; set; }
		public List<TreeNode<T>> Children { get; set; }

		public override string ToString()
		{
			if(Value != null)
				return string.Format("{0}", this.Value);
			return "value is null";
		}
	}
}
