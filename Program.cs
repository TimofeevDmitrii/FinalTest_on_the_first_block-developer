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

// Для тестирования программы написаны три входных массива. 
// Раскомментируйте для тестирования нужную строку с входным массивом и закомментируйте ту, 
// что использовалась ранее; Вы можете задать свой собственный массив на вход программы по данным примерам;

string[] stringArray = new string[] { "Size",":-)", "^-^", "Михайловка", "Bob", "Москва", "Нож", "3", "ABC", "Loo", "-4", "1457", "add", "Ярославль", "И2", "Texas"};
// string[] stringArray = new string[] {"Russia", "Denmark", "Kazan"};
// string[] stringArray = new string[] {"1234", "1567", "-2", "computer science"};
string[] newStringArray = SelectRowsByLength(stringArray, 3);
System.Console.WriteLine("Входной массив строк:");
PrintStringArray(stringArray);
System.Console.WriteLine("Выходной массив строк:");
PrintStringArray(newStringArray);













