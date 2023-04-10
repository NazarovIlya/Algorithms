using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists
{
	internal class ListUtils
	{
		public static void PrintList<T, userT>(T list)
		{
			if (list is SingleLinkedList<T>)
				PrintSList(list as SingleLinkedList<userT>);
			if (list is DoubleLinkedList<userT>)
				PrintDList(list as DoubleLinkedList<userT>);
			else throw new Exception("Unknow type of list.");


		}
		private static void PrintSList<T>(SingleLinkedList<T> list)
		{
			var item = list.Head;

			while (item != null)
			{
				Console.WriteLine(item);
				item = item.Next;
			}
		}
		private static void PrintDList<T>(DoubleLinkedList<T> list)
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
