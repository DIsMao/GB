﻿Console.Clear();

void PrintNaturalNumbers(int n)
{
    if (n != 0)
    {
        Console.Write(n + " ");
        PrintNaturalNumbers(n - 1);
    }
}

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

PrintNaturalNumbers(N);