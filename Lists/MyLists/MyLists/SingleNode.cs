using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MyLists
{
	internal class SingleNode<T>
	{
		protected T value;
		protected SingleNode<T> next;

		public T Value { get => value; set => this.value = value; }
		public SingleNode<T> Next { get => next; set => next = value; }

		public SingleNode(T value)
		{
			this.Value = value;
		}
		public SingleNode(T value, SingleNode<T> next) : this(value)
		{
			this.Next = next;
		}
		public override string ToString()
		{
			return this.Value.ToString();
		}
	}
}
