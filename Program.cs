using System;

class Program
{
    static void Main()
    {
        // Примеры массивов
        string[][] testArrays = {
            new string[] { "Hello", "2", "world", ":-)" },
            new string[] { "1234", "1567", "-2", "computer science" },
            new string[] { "Russia", "Denmark", "Kazan" }
        };

        // Обработка каждого массива
        foreach (var array in testArrays)
        {
            string[] filteredArray = FilterShortStrings(array);
            PrintResult(array, filteredArray);
        }
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

    static void PrintResult(string[] originalArray, string[] filteredArray)
    {
        Console.WriteLine($"[{string.Join(", ", originalArray)}] → [{string.Join(", ", filteredArray)}]");
    }
}
