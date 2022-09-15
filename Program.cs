//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
Console.Write("Введите число для M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число для N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"M={M}, N={N}");
void result(int M, int N)
{
  if (M>N) {
    for (int i = M; i > N; i--) {
        Console.Write(i + ", ");
    }
    Console.WriteLine($"{(N)}");
  }
    else if (M<N) {
    for (int i = M; i < N; i++) { 
        Console.Write(i + ", ");
    }
        Console.WriteLine($"{(N)}");
    }
    else { Console.Write("Они не могут быть равны"); }
}
result(M, N);
