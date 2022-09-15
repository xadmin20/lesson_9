// Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
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
