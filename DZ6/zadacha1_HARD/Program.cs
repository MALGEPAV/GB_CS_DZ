Console.Write("Введите количество чисел правее и левее нуля: ");
int n = Convert.ToInt32(Console.ReadLine());
PrintNiggaFibonacci(n);
Console.WriteLine();
//----------------------------------------------------------------------------------
void PrintNiggaFibonacci(int n)
{
    Console.WriteLine("Ваши числа негафибоначчи:\n");
    if (n == 0) Console.WriteLine("0");
    else if (n == 1) Console.WriteLine("1 0 1");
    else
    {
        int[] fib = new int[2 * n + 1];
        fib[n] = 0;
        fib[n - 1] = 1;
        fib[n + 1] = 1;
        int nextLeftIndex = n-1;
        int nextRightIndex = n+1;
    
        for (int i = 0; i < n-1; i++)
        {
            nextLeftIndex--;
            nextRightIndex++;
            fib[nextLeftIndex] = -fib[nextLeftIndex+1]+fib[nextLeftIndex+2];
            fib[nextRightIndex] = fib[nextRightIndex-1]+fib[nextRightIndex-2];
        }
        PrintArray(fib);
    }
}
void PrintArray(int[] array)
{
    foreach (int el in array)
        Console.Write($"{el} ");
    Console.WriteLine();
}
