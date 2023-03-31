using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
	internal class Search
	{
		public static int DirectSearch(int[] array, int value)
		{
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == value)
					return i;
			}
			return -1;
		}
	}
}
