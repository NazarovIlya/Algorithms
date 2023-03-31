using Searches;

Console.Clear();

int[] arr = new int[] { 6, 3, 9, 1, 0, -10, 2, 7 };

int result = Search.DirectSearch(arr, -10);
Console.WriteLine($"Индекс найденного элемента: {result}");
Console.ReadLine();