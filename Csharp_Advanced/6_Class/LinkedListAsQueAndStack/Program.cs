LinkedList<int> stack = new LinkedList<int> ();

stack.AddFirst (1);
stack.AddFirst (2);
stack.AddFirst (3);
stack.AddFirst (4);



while(stack.Count > 0)
{
    int value = stack.First.Value;
    stack.RemoveFirst();
    Console.WriteLine(value);
}
//Works like a stack
//

LinkedList<int> que = new LinkedList<int>();

stack.AddLast(1);
stack.AddLast(2);
stack.AddLast(3);
stack.AddLast(4);



while (stack.Count > 0)
{
    int value = stack.Last.Value;
    stack.RemoveFirst();
    Console.WriteLine(value);
}
//Works like a queue