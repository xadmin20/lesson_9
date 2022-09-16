# lesson_9
 
#### Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

`M = 1; N = 5. -> ""1, 2, 3, 4, 5""`

```csharp
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
```

#### Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

`M = 1; N = 15 -> 120`


```csharp
Console.Write("Введите число для M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число для N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"M={M}, N={N}");
void result(int M, int N) {
    int sum = 0;
    if (M>N) {
        for (int i = M; i > N; i--) {
            sum = sum + i;
            Console.Write(i + ", ");
        }
        Console.WriteLine($"{(N)} сумма будет равна {sum+N}");
    }
    else if (M<N) {
    for (int i = M; i < N; i++) { 
        sum = sum + i;
        Console.Write(i + ", ");
    }
        Console.WriteLine($"{(N)} сумма будет равна {sum+N}");
    }
    else { Console.Write("Они не могут быть равны"); }
}

result(M, N);
```


#### //Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

`m = 3, n = 2 -> A(m,n) = 29`

```csharp
Console.WriteLine("Введите число m: "); int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n: "); int n = Convert.ToInt32(Console.ReadLine());

int A(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return A(m - 1, 1);
    }
    else return A(m - 1, A(m, n - 1));
}

int funAn = A(m, n);
Console.Write($"A({m}, {n}) = {funAn} ");
```
