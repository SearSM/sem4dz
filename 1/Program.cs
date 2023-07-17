// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Degree(int numberA, int numberB)
{
    int result = numberA;
    for (int i = 1; i < numberB; i++)
    {
        result *= numberA;
    }
    return result;
}

int GetInfo(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int numA = GetInfo("Введите число A: ");
int numB = GetInfo("Введите число B: ");

int result = Degree(numA, numB);

Console.WriteLine($"Число {numA} в натуральной степени {numB} -> {result}");