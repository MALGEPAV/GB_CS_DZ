Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
int range = rows*cols;
FillArray(array);
Console.WriteLine($"Ваш массив случайных целых чисел от {-rows*cols} до {rows*cols}:");
PrintArray(array);
SelectionSort(array);
Console.WriteLine($"Отсортированный массив:");
PrintArray(array);
//-----------------------------------------------------------------------------------
void FillArray(int[,] array)
{
    int range = array.GetLength(0) * array.GetLength(1);
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(-range, range + 1);
}

void PrintArray(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3}\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}





void SelectionSort(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    int MinIndexI;
    int MinIndexJ;
    for (int m = 0; m < rows; m++)
        for (int n = 0; n < cols; n++)
        {
            MinIndexI = m;
            MinIndexJ = n;
            for (int i = m; i < rows; i++)
                for (int j = 0; j < cols; j++)
                {
                    if ( (cols*i+j > cols*m+n) && (array[i,j]<array[MinIndexI,MinIndexJ]))
                    {
                        MinIndexI = i;
                        MinIndexJ = j;
                    }
                }
            (array[m,n],array[MinIndexI,MinIndexJ])=(array[MinIndexI,MinIndexJ], array[m,n]);
        }
}


