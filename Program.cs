// Main programm

// Enter strings to array here
string[] arr = { "123", "12345", "abc", "ab12", "a", "1", "", "!@#" };
// samples
// string[] arr = {"Hello", "2", "world", ":-)"};
// string[] arr = {"1234", "1567", "-2", "computer science"};
// string[] arr = {"Russia", "Denmark", "Kazan"};

Console.Clear();
arrayPrint("Исходный масиив", arr);
Console.WriteLine();
arrayPrint("Полученный массив:", takeArrayElementsLessThreeChar(arr));

// Methods

//  Распечатывает массив в формате 
//  Title:
//  [e1, e2, .., eN]
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

//  Возвращает массив, состоящий из элементов массива array, длина которых меньше или равна трем смволам 
string[] takeArrayElementsLessThreeChar(string[] array)
{
    string[] arrayNew = new string[0];
    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i].Length <= 3) && (array[i] != ""))
        {
            Array.Resize(ref arrayNew, arrayNew.Length + 1);
            arrayNew[arrayNew.Length - 1] = array[i];
        }
    }
    return arrayNew;
}





