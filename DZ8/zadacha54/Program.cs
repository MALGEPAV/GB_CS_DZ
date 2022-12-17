Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, cols];

FillArray(array);

Console.WriteLine($"\nВаш двумерный массив {rows}x{cols} случайных чисел от {-rows * cols} до {rows * cols}: ");
PrintArray(array);

SelectionSortRows(array);
Console.WriteLine($"\nВаш массив с отсортированными по убыванию строками: ");
PrintArray(array);

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



void SelectionSortRows(int[,] a)
{
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    int maxIndex;

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n - 1; j++)
        {
            maxIndex = j;
            for (int k = j + 1; k < n; k++)
            {
                if (a[i, k] > a[i, maxIndex]) maxIndex = k;
            }
            (a[i,maxIndex],a[i,j])=(a[i,j],a[i,maxIndex]);
        }
    }
}