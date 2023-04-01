using MyLists;

MyLinkedList<int> ml = new MyLinkedList<int>();

ml.AddFirst(1);
ml.AddFirst(2);
ml.AddFirst(3);
ml.AddFirst(4);

ml.AddLast(1);
ml.AddLast(2);
ml.AddLast(3);
ml.AddLast(4);

var item = ml.Head;

while (item != null)
{
	Console.WriteLine(item);
	item = item.Next;
}

Console.WriteLine();


