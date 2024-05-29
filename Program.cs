using System;

class Program
{
    static void Main()
    {
        // Примеры массивов строк
        string[][] testArrays = {
            new string[] { "Hello", "2", "world", ":-)" },
            new string[] { "1234", "1567", "-2", "computer science" },
            new string[] { "Russia", "Denmark", "Kazan" }
        };

        // Обработка каждого массива из примеров
        foreach (var array in testArrays)
        {
            // Фильтруем строки длиной <= 3 символам и сохраняем в новый массив
            string[] filteredArray = FilterShortStrings(array);
            // Выводим исходный и отфильтрованный массивы
            PrintResult(array, filteredArray);
        }
    }

    static string[] FilterShortStrings(string[] inputArray)
    {
        // Инициализируем счётчик строк длиной <= 3 символам
        int count = 0;
        // Подсчитываем количество строк, длина которых <= 3 символам
        foreach (string str in inputArray)
        {
            // Проверяем длину строки
            if (str.Length <= 3)
            {
                // Увеличиваем счётчик, если длина строки <= 3 символам
                count++;
            }
        }

        // Создаем новый массив нужного размера для строк длиной <= 3 символам
        string[] result = new string[count];
        int index = 0; // Индекс для вставки строк в новый массив

        // Заполняем новый массив строками, длина которых <= 3 символам
        foreach (string str in inputArray)
        {
            // Проверяем длину строки
            if (str.Length <= 3)
            {
                // Добавляем строку в новый массив и увеличиваем индекс
                result[index] = str;
                index++;
            }
        }

        // Возвращаем отфильтрованный массив
        return result;
    }

    static void PrintResult(string[] originalArray, string[] filteredArray)
    {
        // Выводим исходный массив и отфильтрованный массив в требуемом формате
        Console.WriteLine($"[{string.Join(", ", originalArray)}] → [{string.Join(", ", filteredArray)}]");
    }
}
