using MyLists;

DoubleLinkedList<int> ml = new DoubleLinkedList<int>();
ListUtils<DoubleLinkedList<int>, int> utilsD = new ListUtils<DoubleLinkedList<int>, int>();

ml.AddFirst(1);
ml.AddFirst(2);
ml.AddFirst(3);
ml.AddFirst(4);

Console.WriteLine("Список содержит:");
utilsD.PrintList(ml);

ml.AddLast(1);
ml.AddLast(20);
ml.AddLast(30);
ml.AddLast(40);

Console.WriteLine("Список содержит:");
utilsD.PrintList(ml);

//ml.RemoveFirst();
//ml.RemoveLast();

//Console.WriteLine("Список содержит уделния:");
//ListUtils.PrintList(ml);

//SingleNode<int> node = ml.SearchNode(1);
//ml.InsertNode(node, 500);
//Console.WriteLine("Список содержит после вставки:");
//ListUtils.PrintList(ml);

//Console.WriteLine("Список после разворота:");
//ml.Revers();
//ListUtils.PrintList(ml);

Console.WriteLine();


