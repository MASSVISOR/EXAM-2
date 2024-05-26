using System;

class Program
{
    static void Main()
    {
        // Примеры массивов
        string[] array1 = { "Hello", "2", "world", ":-)" };
        string[] array2 = { "1234", "1567", "-2", "computer science" };
        string[] array3 = { "Russia", "Denmark", "Kazan" };

        // Вывод результатов для каждого массива
        PrintFilteredArray(array1);
        PrintFilteredArray(array2);
        PrintFilteredArray(array3);
    }

    static string[] FilterShortStrings(string[] inputArray)
    {
        // Считаем количество строк длиной <= 3
        int count = 0;
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        // Создаем новый массив нужного размера
        string[] result = new string[count];
        int index = 0;

        // Заполняем новый массив строками длиной <= 3
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                result[index] = str;
                index++;
            }
        }

        return result;
    }

    static void PrintFilteredArray(string[] array)
    {
        string[] filteredArray = FilterShortStrings(array);
        Console.WriteLine("[" + string.Join(", ", filteredArray) + "]");
    }
}
