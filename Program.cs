﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
Console.WriteLine("Введите число m: "); int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n: "); int n = Convert.ToInt32(Console.ReadLine());
int A(int m, int n)
{
  if (m == 0) {
    return n + 1;
  }
  else if (n == 0) {
      return A(m - 1, 1);
  }
  else return A(m - 1, A(m, n - 1));
}

int funAn = A(m, n);
Console.Write($"A({m}, {n}) = {funAn} ");