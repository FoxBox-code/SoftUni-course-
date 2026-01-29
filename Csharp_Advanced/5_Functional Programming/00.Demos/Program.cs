using System.Runtime.CompilerServices;

Action<string> print = name => Console.WriteLine(name); // this is equal to writing void method.


print("Gorge");


static void PrintMethod(string name)
{
    Console.WriteLine(name);
}

PrintMethod("William");// this is equal to the action from above.


Func<int,int,int> num = (num1,num2) => num1 + num2; // This is equal to method with a return function.

Console.WriteLine(num(5,5));
Console.WriteLine(ReturnNum(2,2));

static int ReturnNum(int numOne , int numTwo)
{
    return numOne + numTwo;
}


Predicate<int> isEven = num => num % 2 == 0; // this is even to bool return method

Console.WriteLine(isEven(3));

Console.WriteLine(IsItEven(6));





static bool IsItEven(int num)
{
    return num % 2 == 0;
}