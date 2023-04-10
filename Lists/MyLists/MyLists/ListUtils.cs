using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists
{
	internal class ListUtils<T, userT>
		where T : class
		where userT : struct
	{
		public void PrintList(T list)
		{
			if (list is SingleLinkedList<T>)
				PrintSList(list as SingleLinkedList<userT>);
			if (list is DoubleLinkedList<userT>)
				PrintDList(list as DoubleLinkedList<userT>);
			else throw new Exception("Unknow type of list.");


		}
		private void PrintSList<T>(SingleLinkedList<T> list)
		{
			var item = list.Head;

			while (item != null)
			{
				Console.WriteLine(item);
				item = item.Next;
			}
		}
		private void PrintDList<T>(DoubleLinkedList<T> list)
		{
			var item = list.Head;

			while (item != null)
			{
				Console.WriteLine(item);
				item = item.Next;
			}
		}
	}
}
