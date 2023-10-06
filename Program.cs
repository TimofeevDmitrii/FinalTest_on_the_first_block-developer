string[] SelectRowsByLength(string[] inletArray, int selectLength)
{
    int i = 0;
    int k = 0;
    while (i<inletArray.Length)
    {
        if (inletArray[i].Length<=selectLength)
            k++;
        i++;
    }
    string[] outletArray = new string[k];
    i = 0;
    int n = 0;
    while (i<inletArray.Length)
    {
        if (inletArray[i].Length<=selectLength)
        {
            outletArray[n] = inletArray[i];
            n++;
        }
        i++;
    }
    return outletArray;
}
void PrintStringArray(string[] array)
{
    int l = 0;
    System.Console.Write("[");
    for (l=0; l<array.Length; l++)
    {
        System.Console.Write($"\"{array[l]}\"");
        if (l!=array.Length-1)
            System.Console.Write(", ");
    }
    System.Console.WriteLine("]");
}














