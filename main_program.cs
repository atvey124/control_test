try{
    Console.Write("Введите сколько элементов вы хотите внести в массив: ");

    int size = int.Parse(Console.ReadLine()!);

    Console.WriteLine("Введите сколько символов в строке должно быть,дабы отсортировать ее(включая само число): ");

    int quantity = int.Parse(Console.ReadLine()!);

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
            if (i + 1 != arr.Length)
            {
                Console.Write(arr[i] + ", ");
                
            }
            else
            {
                Console.Write(arr[i]);
            }
        }
        Console.WriteLine("]");
    }


    string[] SortString(string[] RandomStringArr,int quantity)
    {
        string convertor = "";
        int size_new_arr = 0;
        int index = 0;

        for(int i = 0;i < RandomStringArr.Length;i++)
        {
            convertor = RandomStringArr[i];
            if(convertor.Length <= quantity)
                size_new_arr++;
        }

        convertor = "";
        string[] SortString = new string[size_new_arr];
        
        for(int i = 0;i < RandomStringArr.Length;i++)
        {
            convertor = RandomStringArr[i];
            if(convertor.Length <= quantity)
            {
                SortString[index] = convertor;
                index++;
            }
        }

        return SortString;
    }


    string[] RandomStringArr = InputStringArr(size);
    PrintFunction(RandomStringArr);
    string[] SortStringArr = SortString(RandomStringArr,quantity);
    PrintFunction(SortStringArr);
}
catch{
    Console.WriteLine("Error:Input string was not in a correct format(input int)");
}