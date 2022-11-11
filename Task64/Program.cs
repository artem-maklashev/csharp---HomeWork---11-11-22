/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

int GetNumber(string message)
{
    Console.WriteLine(message);
    bool isCorrect = false;
    int result = 0;
    while (!isCorrect)
        if (int.TryParse(Console.ReadLine(), out result))
            isCorrect = true;
        else
            Console.WriteLine("Введено не число или неверный тип числа. Повторите ввод.");

    return result;
}

string OutputNumbers(int n)
{
    if (1 > n)
    {
        return OutputNumbers(n + 1) + "," + n; //Если введено число меньше 1
    }
    if (n <= 1)
        return n.ToString();
    else
    {
        return n + "," + OutputNumbers(n - 1);
    }
}

//int m = GetNumber("Введите число M ");
int n = GetNumber("Введите число N ");
Console.WriteLine($"N = {n} -> {OutputNumbers(n)}");
