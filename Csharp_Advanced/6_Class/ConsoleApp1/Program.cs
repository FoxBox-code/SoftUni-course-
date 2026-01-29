LinkedList<int> linkedList = new LinkedList<int>();

linkedList.AddLast(1);
linkedList.AddLast(2);
linkedList.AddLast(3);
linkedList.AddLast(4);
linkedList.AddLast(5);

LinkedListNode<int> node = linkedList.First;

while (node != null)
{
    Console.WriteLine(node.Value);
    node = node.Next;
}
//this is how we go trough a Linked List collection.
//Linked list cannot be selected from Indexes like an array 

Console.WriteLine("_______________");


LinkedList<int> addfrist = new LinkedList<int>();

addfrist.AddFirst(1);
addfrist.AddFirst(2);
addfrist.AddFirst(3);
addfrist.AddFirst(4);
addfrist.AddFirst(5);// Every new element goes in front of the train 

LinkedListNode<int> firstAddNode = addfrist.First;

while(firstAddNode != null)
{
    Console.WriteLine(firstAddNode.Value);
    firstAddNode = firstAddNode.Next;
    
}

//Going backwards in a LinkedList
Console.WriteLine("From Tail to Head movement");
node = linkedList.Last;

while(node != null)
{
    Console.WriteLine(node.Value);
    node=node.Previous;
}
Console.WriteLine("_________");
//We can also remove parts by only using RemoveFirst() and RemovingLast().Removing can only happen from the LinkedList not from the Node it self.

linkedList.RemoveFirst();
linkedList.RemoveLast();
node = linkedList.First;

while (node != null)
{
    Console.WriteLine(node.Value);
    node = node.Next;
}