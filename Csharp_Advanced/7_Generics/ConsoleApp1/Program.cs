


List<int> intList = new List<int>()
{
    1,2, 3, 4, 5, 6, 7

};


List<long> longList = new List<long>()
{
    100 , 200 , 300, 400 ,5000

};

List<string> stringList = new List<string>()
{
    "one" , "two" , "tree"
};


PrintList(intList);
PrintList(longList);
PrintList(stringList);




void PrintList<T>(List<T> list)  // This is called generics its exreamlly usefull it allows us to leave the requried data to be selected by the client
{
    T defaults = default(T); 
    Type type = typeof(T); // This is a usfull way of seeing what data type we checked usefull for debugging
    Console.WriteLine(type.Name);
    Console.WriteLine(defaults);
    Console.WriteLine(String.Join(" ", list));
}





