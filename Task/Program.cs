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

void PrintArray(string [] array)
{
    System.Console.Write("[" + string.Join(", ", array) + "] -> ");
}

//------------------------------------------------------------------------

int N = ReadInt("Укажите количество элементов в массиве:");

string [] arr = FillArray(N);
PrintArray(arr);



