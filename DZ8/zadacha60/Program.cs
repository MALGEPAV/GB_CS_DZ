void FillRandomUnique(int[,,] a)
{
    int l = a.GetLength(0);
    int w = a.GetLength(1);
    int h = a.GetLength(2);
    int[] alreadyGeneratedNumbers = new int[l * w * h];
    int counterOfAlreadyGenerated = 1;
    bool alreadyGenerated;
    a[0, 0, 0] = new Random().Next(-l * w * h, l * w * h + 1);
    alreadyGeneratedNumbers[0] = a[0, 0, 0];
    for (int k = 0; k < h; k++)
        for (int i = 0; i < l; i++)
            for (int j = 0; j < w; j++)
            {
                if (i + j + k != 0)
                {
                    do
                    {
                        a[i, j, k] = new Random().Next(-l * w * h, l * w * h + 1);
                        alreadyGenerated = false;
                        for (int s = 0; s < counterOfAlreadyGenerated; s++)
                        {
                            if (a[i, j, k] == alreadyGeneratedNumbers[s])
                            {
                                alreadyGenerated = true;
                                break;
                            }
                        }
                    }
                    while (alreadyGenerated);
                    alreadyGeneratedNumbers[counterOfAlreadyGenerated] = a[i, j, k];
                    counterOfAlreadyGenerated++;
                }
            }
}


void PrintArray(int[,,] a)
{
    int l = a.GetLength(0);
    int w = a.GetLength(1);
    int h = a.GetLength(2);
    for (int k = 0; k < h; k++)
    {
        for (int i = 0; i < l; i++)
        {
            for (int j = 0; j < w; j++)
                Console.Write($"{a[i, j, k],3}({i},{j},{k})\t");
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

Console.Write("Введите длину: ");
int l = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите ширину: ");
int w = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите высоту: ");
int h = Convert.ToInt32(Console.ReadLine());
int[,,] array = new int[l, w, h];
FillRandomUnique(array);
System.Console.WriteLine($"Ваш трехмерный массив {l}x{w}x{h} уникальных случайных чисел:");
PrintArray(array);