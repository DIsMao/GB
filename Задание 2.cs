﻿Console.Clear();

int SumMN(int numM, int numN)
{
    if (numM != numN) return numM + SumMN(numM + 1, numN);
    else return numM;
}

Console.Write("от m - ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("до n -  ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма чисел от {m} до {n} = {SumMN(m, n)}");