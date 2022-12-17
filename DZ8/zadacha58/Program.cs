Console.Write("Введите число строк матрицы А: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов матрицы А: ");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] A = new int[rows, cols];
rows = cols;
Console.Write("Введите количество столбцов матрицы В: ");
cols = Convert.ToInt32(Console.ReadLine());
int[,] B = new int[rows, cols];
Console.WriteLine("Введите матрицу А:");
for (int i = 0; i < A.GetLength(0); i++)
{
    for (int j = 0; j < A.GetLength(1); j++)
    {
        Console.Write($"a{i+1}{j+1} = ");
        A[i,j] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
    }
}
Console.WriteLine("Введите матрицу В:");
for (int i = 0; i < B.GetLength(0); i++)
{
    for (int j = 0; j < B.GetLength(1); j++)
    {
        Console.Write($"b{i+1}{j+1} = ");
        B[i,j] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
    }
}
Console.WriteLine($"A:");
PrintArray(A);
Console.WriteLine($"B:");
PrintArray(B);
System.Console.WriteLine("AxB:");
PrintArray(MatrixProduct(A,B));


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3}\t");
        Console.WriteLine();
    }
}
int[,] MatrixProduct(int[,] A,int[,] B)
{
    int m = A.GetLength(0);
    int n = A.GetLength(1);
    int k = B.GetLength(1);
    int[,] C = new int[m,k];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < k; j++)
        {
            C[i,j]=0;
            for (int s = 0; s < n; s++)
            {
                C[i,j] += A[i,s]*B[s,j];
            }
        }
    }
    return C;
}