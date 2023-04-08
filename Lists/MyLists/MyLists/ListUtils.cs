using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists
{
	internal class ListUtils
	{
		public static void PrintList<T>(MyLinkedList<T> list)
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
