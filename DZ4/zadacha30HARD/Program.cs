Console.Write("Введите длину массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

RandomUniqArrayFill(ref array);
Console.WriteLine("Ваш массив из уникальных случайных чисел от 1 до {0}:", 2 * n);
PrintArray(ref array);

BubbleSort(ref array);
Console.WriteLine("После сортировки:");
PrintArray(ref array);

for (int i = 0; i < 5; i++)
{
    Shuffle(ref array);
    Console.WriteLine("После {0}-го случайного перемешивания:", i+1);
    PrintArray(ref array);
}
//----------ФУНКЦИЯ-ВЫВОД-МАССИВА-НА-ЭКРАН------------
void PrintArray(ref int[] a) //передаем ссылку чтоб не копировать возможно огромные массивы
{
    foreach (int i in a)
    {
        Console.Write("{0} ", i);
    }
    Console.WriteLine();
}
//----------ФУНКЦИЯ-ЗАПОЛНЕНИЕ-МАССИВА-СЛУЧАЙНЫМИ-УНИКАЛЬНЫМИ-ЧИСЛАМИ--------
void RandomUniqArrayFill(ref int[] a)
{
    a[0] = new Random().Next(1, 2 * a.Length + 1);//Взял диапазон от 1 до удвоенной длины массива
    for (int i = 1; i < a.Length; i++)
    {
        int count = 0; // Счетчик совпадений с предыдущими числами
        do
        {
            a[i] = new Random().Next(1, 2 * a.Length + 1);
            count = 0;
            for (int j = 0; j < i; j++)
            {
                if (a[i] == a[j]) count++;
            }
        }
        while (count > 0); //Генерируем новое число пока счетчик не будет равен 0
    }
}
//----------ФУНКЦИЯ-СОРТИРОВКА-ПУЗЫРЬКОМ--------
void BubbleSort(ref int[] a)
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
//----------ФУНКЦИЯ-СЛУЧАЙНОЕ-ПЕРЕМЕШИВАНИЕ-МАССИВА--------
void Shuffle(ref int[] a)
{
    int j = 0;
    int temp = 0;
    for (int i = 0; i < a.Length - 1; i++)
    {
        j = new Random().Next(i, a.Length); //Выбираем случайный номер j от i до a.Length-1 и 
        temp = a[j];                        //меняем местами элементы a[i] и a[j]
        a[j] = a[i];                        //так сначала случайно определяется что стоит на 
        a[i] = temp;                        //первом месте, что на втором итд
    }
}