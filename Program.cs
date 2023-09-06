// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.

/*
Console.Write("Input value of N: ");
int n = Convert.ToInt32(Console.ReadLine());

PrintNaturalNumbers(n);

void PrintNaturalNumbers(int n)
{
    if (n < 1)
    {
        return; 
    }

    if (n != 1)
    {
        Console.Write(n + " "); 
    }
    else
    {
        Console.WriteLine(n); 
    }

    PrintNaturalNumbers(n - 1); 
}
*/

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
//сумму натуральных элементов в промежутке от M до N.

/*

int CalculateSum(int m, int n)
{
    int sum = 0;
        
    for (int i = m; i <= n; i++)
    {
        sum += i;
    }

return sum;
}

Console.Write("Input value M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input value N: ");
int n = Convert.ToInt32(Console.ReadLine());

int sum = CalculateSum(m, n);

Console.WriteLine($"Summ of natural numbers from {m} to {n} equal to {sum}");

*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

/*

int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
        else if (m > 0 && n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else if (m > 0 && n > 0)
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
        else
        {
            throw new ArgumentException("Значения m и n должны быть неотрицательными.");
    }
}

Console.Write("Введите значение m: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите значение n: ");
int n = int.Parse(Console.ReadLine());

int result = Ackermann(m, n);
Console.WriteLine($"Ackermann({m}, {n}) = {result}");

*/