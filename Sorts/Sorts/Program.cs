﻿using Sorts;

int[] arr = new int[] { 6, 3, 9, 1, 0, -10, 2, 7 };

Console.WriteLine(string.Join(", ", arr));

int[] arrayForSort = new int[arr.Length];
arr.CopyTo(arrayForSort, 0);

//SortsInt.BubbleSort(arrayForSort);
//SortsInt.SelectSort(arrayForSort);
//SortsInt.InsertSort(arrayForSort);
//sortsint.heapsort(arrayforsort);
SortsInt.QuickSort(arrayForSort);

Console.WriteLine(string.Join(", ", arrayForSort));

Console.ReadLine();