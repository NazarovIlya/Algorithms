using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists
{
	internal class DoubleNode<T> : SingleNode<T> where T : class
	{
		private DoubleNode<T>? previous;
		internal DoubleNode<T> Previous { get => previous; set => previous = value; }

		public DoubleNode(T value, DoubleNode<T> next, DoubleNode<T> previous) : base(value, next)
		{
			this.Previous = previous;
		}

		public override string? ToString()
		{
			return this.Value.ToString();
		}
	}
}
