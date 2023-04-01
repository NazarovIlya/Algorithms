using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists
{ 
	internal class MyLinkedList<T>
	{
		SingleNode<T> head;

		internal SingleNode<T> Head { get => head; set => head = value; }
		public void AddFirst(T value)
		{
			SingleNode<T> node = new SingleNode<T>(value);
			if (Head != null)
				node.Next = Head;
			Head = node;
		}
		public void AddLast(T value)
		{
			SingleNode<T> node = new SingleNode<T>(value);
            if (Head == null)
				Head = node;
			else
			{
				SingleNode<T> lastNode = Head;
				while (lastNode.Next != null)
					lastNode = lastNode.Next;
				lastNode.Next = node;
			}
        }
	}
}
