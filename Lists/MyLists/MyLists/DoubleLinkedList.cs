using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists
{
	internal class DoubleLinkedList<T>
	{
		internal DoubleNode<T> Head { get; set; }
		internal DoubleNode<T> Tail { get; set; }
		public void AddFirst(T value)
		{
			DoubleNode<T> node = new DoubleNode<T>(value);
			if(Head != null)
			{
				node.Next = Head;
				Head.Previous = node;
			}
			else
				Tail = node;
			Head = node;
		}
		public void AddLast(T value)
		{
			DoubleNode<T> node = new DoubleNode<T>(value);
			if(Tail != null)
			{
				node.Previous = Tail;
				Tail.Next = node;
			}
			else 
				Head = node;
			Tail = node;
		}
	}
}
