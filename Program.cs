/*
Задача 64: 
Задайте значение N. 
Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
Console.Write("Ввведите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
/// <summary>
/// Печать чисел от N до 1
/// </summary>
/// <param name="start"> левая граница (N) </param>
/// <param name="end"> правая граница (1)</param>
/// <returns> строчку с числами от N до 1 </returns>
string GetStringOfNumbers(int start, int end)
{
    // Базовый случай - выход
    if (start == end) return start.ToString(); // Вернул последнее число в формате строчки

    // Рекурсивный случай
    return start + ", " + GetStringOfNumbers(start - 1, end);
}
Console.WriteLine();
Console.WriteLine($"Все натуральные числа в промежутке от {N} до 1 ");
Console.WriteLine(GetStringOfNumbers(N, 1)); // start = N, end = 1