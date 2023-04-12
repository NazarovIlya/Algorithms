using Trees;

Console.Clear();

LLRBTRee lLRBTree = new LLRBTRee();

lLRBTree.AddChild(5);
lLRBTree.AddChild(3);
lLRBTree.AddChild(8);
lLRBTree.AddChild(0);
lLRBTree.AddChild(4);
lLRBTree.AddChild(9);



Console.WriteLine(lLRBTree.Root);







//void PostOrder(LLRBNode node)
//{
//	PostOrder(node.LeftChild);
//	PostOrder(node.RightChild);
//    Console.WriteLine(node.Value);
//}


//PostOrder(lLRBTree.Root);