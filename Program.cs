string[] arr = { "1444", "r4rt", "edfgvf", "5544", "4440" };

Console.Clear();

arrayPrint("Исходный масиив", arr);

Console.WriteLine();

arrayPrint("Полученный массив:", takeArrayElementsLessThreeChar(arr));

// Methods

void arrayPrint(string title, string[] array)
{
    Console.WriteLine(title);
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0)
        {
            Console.Write($"\"{array[i]}\"");
        }
        else
        {
            Console.Write($"\", {array[i]}\"");
        }
    }
    Console.Write("]");
    Console.WriteLine();
}

string[] takeArrayElementsLessThreeChar(string[] array)
{
    string[] arrayNew = new string[0];
    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i].Length <= 3) && (array[i] != null))
        {
            Array.Resize(ref arrayNew, arrayNew.Length + 1);
            arrayNew[arrayNew.Length - 1] = array[i];
        }
    }
    return arrayNew;
}







