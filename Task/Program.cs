int ReadInt(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

string [] FillArray (int N)
{
    string [] array = new string [N];
    System.Console.WriteLine("Введите элементы массива:");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = System.Console.ReadLine();
    }
    return array;
}

string [] NewArray(string [] array)
{
    int q = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j].Length < 4)
        {
            q++;
        }
    }
    string [] newarr = new string [q];
    int k = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            newarr[k] = array[i];
            k++;
        }
    }
    return newarr;
}

void PrintArray(string [] array)
{
    System.Console.Write("[" + string.Join(", ", array) + "] -> ");
}

void NewPrintArray(string [] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

//------------------------------------------------------------------------

int N = ReadInt("Укажите количество элементов в массиве:");

string [] arr = FillArray(N);
PrintArray(arr);

string [] ar = NewArray(arr);
NewPrintArray(ar);
