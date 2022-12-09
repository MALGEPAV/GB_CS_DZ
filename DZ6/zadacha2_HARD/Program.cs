Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] Matrix = new int[m, n];
FillMatrix(Matrix);
PrintMatrix(Matrix);
Console.WriteLine();
(int min, int minI, int minJ, int max, int maxI, int maxJ) = FindMinMax(Matrix);
Console.WriteLine($"Минимальный элемент матрицы равен {min} и находится на позиции ({++minI}, {++minJ}).");
Console.WriteLine();
Console.WriteLine($"Максимальный элемент матрицы равен {max} и находится на позиции ({++maxI}, {++maxJ}).");
Console.WriteLine();
void PrintMatrix(int[,] M)
{
    for (int i = 0; i < M.GetLength(0); i++)
    {
        for (int j = 0; j < M.GetLength(1); j++)
        {
            Console.Write($"{M[i, j],3}\t");
        }
        Console.WriteLine();
    }
}
void FillMatrix(int[,] M)
{
    for (int i = 0; i < M.GetLength(0); i++)
    {
        for (int j = 0; j < M.GetLength(1); j++)
        {
            M[i, j] = new Random().Next(-99, 100);
        }
    }
}
(int min, int minI, int minJ, int max, int maxI, int maxJ) FindMinMax(int[,] M)
{
    int minI = 0;
    int minJ = 0;
    int maxI = 0;
    int maxJ = 0;
    int min = M[0,0];
    int max = M[0,0];
    for (int i = 0; i < M.GetLength(0); i++)
    {
        for (int j = 0; j < M.GetLength(1); j++)
        {
            if (M[i,j]<min)
            {
                min = M[i,j];
                (minI, minJ)= (i,j);  
            }
            if (M[i,j]>max)
            {
                max = M[i,j];
                (maxI, maxJ)= (i,j);  
            }
        }
    }

return (min, minI, minJ, max, maxI,maxJ);
}