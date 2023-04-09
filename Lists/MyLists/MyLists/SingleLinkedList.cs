using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists
{ 
	internal class SingleLinkedList<T>
	{
		internal SingleNode<T> Head { get; set; }
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
		public void InsertNode(SingleNode<T> node, T value)
		{
			SingleNode<T> next = node.Next;
			SingleNode<T> newNode = new SingleNode<T>(value);
			node.Next = newNode;
			newNode.Next = next;
		}

		public void RemoveFirst()
		{
			if(Head != null)
				Head = Head.Next;
		}
		public void RemoveLast()
		{
			if(Head != null)
			{
				SingleNode<T> node = Head;
				while(node.Next != null)
				{
					if (node.Next.Next == null)
					{
						node.Next = null;
						return;
					}
					node = node.Next;
				}
				Head = null;
			}
		}

		public void Revers()
		{
			SingleNode<T> previous = null;
			SingleNode<T> current = Head;
			SingleNode<T> temp = null;
			while (current != null)
			{
				temp = current.Next;
				current.Next = previous;
				previous = current;
				current = temp;
			}
			Head = previous;
		}
		public SingleNode<T> SearchNode(T value)
		{
			SingleNode<T> node = Head;
			while(node != null)
			{
				if(node.Value.Equals(value)) return node;
				node = node.Next;
			}
			return null;
		}
	}
}
