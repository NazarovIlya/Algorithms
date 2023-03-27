using Sorts;

int[] arr = new int[] { 6, 3, 9, 1, 0, -10, 2, 7 };

Console.WriteLine(string.Join(", ", arr));

SortsInt.BubbleSort(arr);

Console.WriteLine(string.Join(", ", arr));

Console.ReadLine();