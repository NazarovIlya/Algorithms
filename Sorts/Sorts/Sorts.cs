using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Sorts;
public class SortsInt
{
	public static int[] BubbleSort(int[] array)
	{
		for (int i = 0; i < array.Length; i++)
		{
			for (int j = 0; j < array.Length - 1; j++)
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

	public static int[] SelectSort(int[] array)
	{
		for (int i = 0; i < array.Length - 2; i++)
		{
			int minPosition = i;
			for (int j = i + 1; j < array.Length - 1; j++)
			{
				if (array[j] < array[minPosition])
				{
					minPosition = j;
				}
			}
			int temp = array[minPosition];
			array[minPosition] = array[i];
			array[i] = temp;
		}
		return array;
	}

	public static int[] HeapSort(int[] array)
	{
		for (int i = array.Length / 2 - 1; i >= 0; i--)
			Heapify(array, array.Length, i);
		for(int i = array.Length - 1; i >= 0; i--)
		{
			int temp = array[0];
			array[0] = array[i];
			array[i] = temp;

			Heapify(array, i, 0);
		}
		return array;
	}
	private static void Heapify(int[] array, int heapSize, int rootIndex) 
	{
		int largest = rootIndex;
		int leftChild = 2 * rootIndex + 1;
		int rightChild = 2 * rootIndex + 2;
		if(leftChild < heapSize && array[leftChild] > array[largest])
			largest = leftChild;
		if(rightChild < heapSize && array[rightChild] > array[largest])
			largest = rightChild;
		if(largest != rootIndex)
		{
			int temp = array[rootIndex];
			array[rootIndex] = array[largest];
			array[largest] = temp;
			Heapify(array, heapSize, largest);
		}
		
	}
}

