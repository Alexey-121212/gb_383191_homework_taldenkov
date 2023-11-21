string[] arr = { "1", "rrt", "edfgvf", "55", "0" };

Console.Clear();

arrayPrint("Исходный масиив", arr);

arrayPrint("Полученный массив:", takeArrayElementsLessThreeChar(arr));

// Methods

void arrayPrint(string title, string[] array)
{
    Console.WriteLine(title);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine($"Элемент {i} = \"{array[i]}\"");
    }
    Console.WriteLine();
}

string[] takeArrayElementsLessThreeChar(string[] array)
{
    string[] arrayNew=array;
    return arrayNew;
}







