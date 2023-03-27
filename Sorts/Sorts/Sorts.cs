using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Sorts;
	public  class SortsInt 
	{
		public static int[] BubbleSort(int[] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				for(int j = 0; j < array.Length - 1; j++)
				{
					if (array[j] > array[j + 1])
					{
						int temp = array[j];
						array[j] = array[j + 1];
						array[j + 1] = temp;
					}
				}
			}
			return array;
		}
	}

