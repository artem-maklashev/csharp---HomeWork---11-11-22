/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

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

int AckermannFunktion(int m, int n)
{
    if (m==0)
        return n+1;
    else if (m>0 && n==0)
        return AckermannFunktion(m-1,1);
    else return AckermannFunktion(m-1, AckermannFunktion(m,n-1));
}

int m = GetNumber("Введите число m ");
int n = GetNumber("Введите число n ");
Console.WriteLine($"m = {m}; n = {n} --> {AckermannFunktion(m,n)}");
