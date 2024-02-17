
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
    Console.WriteLine(string.Join(", ",RandomStringArr));
    return RandomStringArr;
}

string[] SortString(string[] RandomStringArr)
{
    string convertor = "";
    string[] SortString = new string[RandomStringArr.Length];
    int index = 0;
    for(int i = 0;i < RandomStringArr.Length;i++)
    {
        convertor = RandomStringArr[i];
        if(convertor.Length <= 3)
        {
            SortString[index] = convertor;
            index++;
        }
    }
    Console.WriteLine(string.Join(", ",SortString));
    return SortString;
}







string[] RandomStringArr = InputStringArr(size);

string[]SortString1 = SortString(RandomStringArr);