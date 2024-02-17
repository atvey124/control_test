
Console.Write("Введите сколько элементов вы хотите внести в массив: ");
try{
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
        Console.Write("[");
        for(int i = 0;i < arr.Length;i++)
        {
            Console.Write(arr[i] + ", ");
        }
        Console.WriteLine("]");
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
        return SortString;
    }


    string[] RandomStringArr = InputStringArr(size);
    PrintFunction(RandomStringArr);
    string[] SortStringArr = SortString(RandomStringArr);
    PrintFunction(SortStringArr);
}
catch{
    Console.WriteLine("Error:Input string was not in a correct format(input int)");
}