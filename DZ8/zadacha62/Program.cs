Console.Write("Введите размерность матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());
SpiralNumbers(n);
void SpiralNumbers(int n)
{
    int[,] a = new int[n, n];
    int num = 1;
    int numberOfSteps;
    int i_step;
    int j_step;
    int i = 0;
    int j = -1;
    for (int counter = 1; counter < 2 * n; counter++)
    {
        numberOfSteps = n - counter / 2;
        i_step = Stepen((counter - 1) / 2) * (1 + Stepen(counter)) / 2;
        j_step = Stepen(counter / 2) * (1 + Stepen(counter - 1)) / 2;
        for (int k = 1; k <= numberOfSteps; k++)
        {
            i += i_step;
            j += j_step;
            a[i, j] = num;
            num++;
        }
    }
    PrintArray(ref a);
}
void PrintArray(ref int[,] a)
{
    Console.WriteLine();
    int n = a.GetLength(0);
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write("{0,3:D2}", a[i, j]);
        }
        Console.WriteLine();
    }
}
int Stepen(int k)// -1 в степени k
{
    if (k % 2 == 0) return 1;
    else return -1;
}