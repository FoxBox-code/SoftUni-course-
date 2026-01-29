
int[] ints = new int[5] {1, 2 ,3 ,4, 5};
double[] doubles = new double[5] {1.5, 2.7 ,3.3 ,4.99, 5};


bool result = FindElement(ints, 5);
bool results = FindElement(doubles, 0.55);

Console.WriteLine(result);
Console.WriteLine(results);


bool FindElement<T>(T[] array , T element)
{
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Equals(element))   // To compare data when using T generics we need to use a limited amount of given Methods in this case we use Equals
        {
            return true;
        }
    }
    return false;
}
//since T cannot be sure if the two given datas are matched we can only use 4 methods.
//defualt(T) gives us null if the data type is string or 0 if the data type is using numbers.