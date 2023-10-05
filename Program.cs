// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

// Начало программы

Console.Clear();

int number;

do
{
    Console.Write("Выберите номер варианта:\n1. Hello, 2, world, :-)\n2. 1234, 1567, -2, computer science\n3. Russia, Denmark, Kazan\n\n");
    Console.Write("Выберите вариант с 1 до 3 для теста программы: ");

    if (int.TryParse(Console.ReadLine(), out number))
    {
        switch (number)
        {
            case 1:
                string[] array1 = { "Hello", "2", "world", ":-)" };
                PrintArray(array1);
                break;

            case 2:
                string[] array2 = { "1234", "1567", "-2", "computer science" };
                PrintArray(array2);
                break;

            case 3:
                string[] array3 = { "Russia", "Denmark", "Kazan" };
                PrintArray(array3);
                break;

            default:
                Console.WriteLine("Такого номера нет, выберите номера от 1 до 3 \n");
                Console.WriteLine(" ---------------- \n ");
                break;
        }
    }
    else
    {
        Console.WriteLine("\n Некорректный ввод. Введите число, а не буквы или символы !!!\n");
        Console.WriteLine(" ---------------- \n ");
    }

} while (number != 1 && number != 2 && number != 3);

void PrintArray(string[] arr)
{
    string[] newArray = new string[arr.Length];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            newArray[i] = arr[i];
        }
    }

    Console.Write($"[{string.Join(" ", newArray)}]");
}