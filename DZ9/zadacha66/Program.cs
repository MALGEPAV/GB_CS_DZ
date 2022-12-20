Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число M не превосходящее N: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма натуральных чисел от {M} до {N} равна {Sum(M,N)} ");

int Sum(int M, int N) =>
(N-M) switch
{
    0 => M,
    _ => N+Sum(M,N-1)
};
