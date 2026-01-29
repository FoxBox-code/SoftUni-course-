



using System;
using System.Collections;

Console.WriteLine(GetBiggestElement(11,22,22));

int big = GetBiggestElement(11, 22, 33);

Console.WriteLine(big);



T GetBiggestElement<T>(T first, T second, T third) where T : IComparable<T>
{
    if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
    {
        return first;
    }
    if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
    {
        return second;
    }
    if (third.CompareTo(second) > 0 && third.CompareTo(first) > 0)
    {
        return third;
    }

    return default(T);

}