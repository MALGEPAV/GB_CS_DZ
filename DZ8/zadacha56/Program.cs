Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
FillArray(array);
Console.WriteLine($"\nВаш двумерный массив {rows}x{cols} случайных чисел от {-rows * cols} до {rows * cols}: ");
PrintArray(array);
Console.WriteLine($"\nСтрока с минимальной суммой элементов имеет номер {MinSumRowIndex(array)}");
//------------------------------------------------------------------------------------------------------------
void FillArray(int[,] array)
{
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            array[i, j] = new Random().Next(-m * n, m * n + 1);
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3}\t");
        Console.WriteLine();
    }
}
int MinSumRowIndex(int[,] a)
{
    int minSumIndex = 0;
    int minSum = SumRow(a, 0);
    for (int i = 0; i < a.GetLength(0); i++)
    {
        if (SumRow(a, i) < minSum) minSumIndex = i;
    }
    return minSumIndex;
}
int SumRow(int[,] a, int i)//Функция, возвращающая сумму элементов данного массива в строке с данным номером
{
    int sum = 0;
    for (int j = 0; j < a.GetLength(1); j++)
    {
        sum += a[i, j];
    }
    return sum;
}