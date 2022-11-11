/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int GetNumber(string message)
{
    Console.WriteLine(message);
    bool isCorrect = false;
    int result = 0;
    while (!isCorrect)
        if (int.TryParse(Console.ReadLine(), out result))
            isCorrect = true;
        else
            Console.WriteLine("Введено не число. Повторите ввод.");

    return result;
}

int SumOfNumbers(int m, int n)
{
    if (m > n) (m, n) = (n, m);
    if (m == n)
        return m;
    else
        return n + SumOfNumbers(m, n - 1);
}

int m = GetNumber("Введите число M ");
int n = GetNumber("Введите число N ");
Console.WriteLine($"M = {m}; N = {n} -> {SumOfNumbers(m, n)}");
