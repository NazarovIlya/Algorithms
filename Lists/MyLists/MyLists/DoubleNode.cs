using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists
{
	internal class DoubleNode<T>
	{
		private T value;
		private DoubleNode<T> next;
		private DoubleNode<T> previous;

		public T Value { get => value; set => this.value = value; }
		public DoubleNode<T> Next { get => next; set => next = value; }
		public DoubleNode<T> Previous { get => previous; set => previous = value; }

		public DoubleNode(T value)
		{
			this.Value = value;
		}
		public DoubleNode(T value, DoubleNode<T> next) : this(value)
		{
			Next = next;
		}
		public DoubleNode(T value, DoubleNode<T> next, DoubleNode<T> previous) : this(value, next)
		{
			this.Previous = previous;
		}

		public override string ToString()
		{
			return this.Value.ToString();
		}
	}
}
