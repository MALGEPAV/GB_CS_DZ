Console.Write("Введите длину случайного массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[] array = CreateRandomArray(n);
Console.WriteLine("Ваш массив cлучайных чисел от ({0}) до {1}: ", -n, n);
PrintArray(array);
double[] data = Info(array);
Console.WriteLine();
Console.WriteLine("Минимальный элемент в этом массиве равен {0} и имеет индекс {1}", data[0], data[1]);
Console.WriteLine();
Console.WriteLine("Максимальный элемент в этом массиве равен {0} и имеет индекс {1}", data[2], data[3]);
Console.WriteLine();
Console.WriteLine("Среднее арифметическое элементов массива равно {0:N2}", data[4]);
Console.WriteLine();
Console.WriteLine("Отсортированный массив:");
PrintArray(array); //отсортировался внутри функции так как передался туда по ссылке
Console.WriteLine();
Console.WriteLine("Медиана равна {0:N2}", data[5]);

//--------------------------------------------
//ФУНКЦИИ: СОЗДАНИЕ МАССИВА И ВЫВОД НА ЭКРАН
int[] CreateRandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(-size, size + 1);
    return array;
}
void PrintArray(int[] array)
{
    foreach (int el in array)
        Console.Write($"{el} ");
    Console.WriteLine();
}
//-------------------------------------------------------------------------------------------
//ФУНКЦИЯ, КОТОРАЯ ВЫДАЕТ МИНИМАЛЬНЫЙ, МАКСИМАЛЬНЫЙ ЭЛЕМЕНТЫ, ИХ ИНДЕКСЫ, СРЕДНЕЕ
//АРИФМЕТИЧЕСКОЕ И МЕДИАНУ
double[] Info(int[] array)
{
    int n = array.Length;
    int min = array[0];
    int max = array[0];
    int minIndex = 0;
    int maxindex = 0;
    double average = 0;
    double median = 0;

    for (int i = 0; i < n; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            minIndex = i;
        }
        if (array[i] > max)
        {
            max = array[i];
            maxindex = i;
        }
        average += array[i];
    }
    average /= n;
    BubbleSort(array);

    median = (double)(array[n / 2 + n % 2 - 1] + array[n / 2]) / 2; // иначе делит целочисленно почему-то
    double[] data = { min, minIndex, max, maxindex, average, median};
    return data;
}
//----------ФУНКЦИЯ-СОРТИРОВКА-ПУЗЫРЬКОМ--------
void BubbleSort(int[] a)
{
    int temp = 0;
    for (int i = a.Length - 1; i > 0; i--)
    {
        for (int j = 0; j < i; j++)
        {
            if (a[j] < a[j + 1])
            {
                temp = a[j];
                a[j] = a[j + 1];
                a[j + 1] = temp;
            }
        }
    }
}