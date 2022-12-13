void ShuffleArray(int[,] array)
{
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    dynamic linearIndexes = new int[m * n]; //создаем одномерный массив "линейных" индексов 
    for (int i = 0; i < m * n; i++) //элементов двумерного массива, в нем будут случайно выбираться индексы переставляемых
    {                              //элементоа, и удаляться из него, то есть массив будет укорачиваться
        linearIndexes[i] = i;      //поэтому тип dynamic - разные длины массивов - разные типы
    }
    int randomIndex;
    int swappedK1; //линейные индексы переставляемых элементов
    int swappedK2;
    
    int swappedI1; //двойные индексы переставляемых элементов
    int swappedJ1;
    int swappedI2;
    int swappedJ2;

    int swapsCounter = 0; //счетчик перестановок элементов - должен в итоге оказаться равен m*n/2;

    for (int i = 1; i <= m * n / 2; i++)
    {
        randomIndex = new Random().Next(0, linearIndexes.Length);
        swappedK1 = linearIndexes[randomIndex];                //случайно выбираем первый переставляемый индекс
        linearIndexes = RemoveElement(linearIndexes, randomIndex); //удаляем его их списка

        randomIndex = new Random().Next(0, linearIndexes.Length);
        swappedK2 = linearIndexes[randomIndex];                //случайно выбираем второй переставляемый индекс
        linearIndexes = RemoveElement(linearIndexes, randomIndex); //удаляем его их списка

        swappedI1 = swappedK1 / n; //перевод линейных индексов в двумерные
        swappedJ1 = swappedK1 % n;

        swappedI2 = swappedK2 / n;
        swappedJ2 = swappedK2 % n;

        Console.WriteLine($"Переставляем элементы с индексами [{swappedI1}, {swappedJ1}] и [{swappedI2}, {swappedJ2}]:");
        (array[swappedI1, swappedJ1], array[swappedI2, swappedJ2]) = (array[swappedI2, swappedJ2], array[swappedI1, swappedJ1]);
        swapsCounter++; 
        PrintArray(array);
        System.Console.WriteLine($"Всего перестановок: {swapsCounter}\n");
    }
}
//Функция, которая удаляет из массива элемент c заданным индексом, и возвращает массив короче на один элемент
int[] RemoveElement(int[] array, int index)
{
    int[] newArray = new int[array.Length - 1];
    for (int i = 0; i < index; i++)
    {
        newArray[i] = array[i];
    }
    for (int i = index; i < newArray.Length; i++)
    {
        newArray[i] = array[i + 1];
    }
    return newArray;
}
//------------------------------------------------------------------------------
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = array.GetLength(1) * i + j; // Изначально заполняем массив числами по возрастанию
}
//-----------------------------------------------------------------------
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
//---------------------------------------------------------------
Console.Write("Введите количество строк двумерного массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива: ");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
FillArray(array);
Console.WriteLine($"\nИсходный массив:");
PrintArray(array);
ShuffleArray(array);