// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] MakeNewRandomArray(int size, int beginValue, int endValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(beginValue, endValue + 1);
    }
    return array;
}

int GetInfo(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int numberSize = GetInfo("Введите размер массива: ");
int numberMin = GetInfo("Введите стартовый диапазон чисел: ");
int numberMax = GetInfo("Введите максимальный диапазон чисел: ");

int[] array = MakeNewRandomArray(numberSize, numberMin, numberMax);

Console.Write("[" + string.Join(", ", array) + "]");