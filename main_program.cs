
Console.Write("Введите сколько элементов вы хотите внести в массив: ");
int size = int.Parse(Console.ReadLine()!);

string[] InputStringArr(int size)
{
    string element = "";
    string[] RandomStringArr = new string[size];
    for(int i = 0;i < size;i++)
    {
        Console.WriteLine($"Введите элемент массива {i + 1}: ");
        element = Console.ReadLine()!;
        RandomStringArr[i] = element;

    }
    return RandomStringArr;
}

void PrintFunction(string[] arr)
{
    for(int i = 0;i < arr.Length;i++)
    {
        Console.Write(arr[i]);
    }
    Console.WriteLine();
}






string[] RandomStringArr = InputStringArr(size);

string[]SortString1 = SortString(RandomStringArr);