Action<string> namePrint = NameList;

string[] inputOfNames = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);


foreach (string name in inputOfNames)
{
    namePrint(name);
}







void NameList(string name)
{

    Console.WriteLine("Sir " + name);
}
















