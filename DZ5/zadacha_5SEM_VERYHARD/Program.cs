System.Console.WriteLine("Проверка:");
int[] testArray1 = { 1, 5, 2, 3, 4, 1, 7, 8, 15, 1 };
PrintArray(testArray1);
PrintAnswer(testArray1);

int[] testArray2 = { 1, 5, 2, 3, 4, 6, 1, 7};
PrintArray(testArray2);
PrintAnswer(testArray2);

int[] testArray3 = {1, 5, 3, 4, 1, 7, 8 , 15 , 1};
PrintArray(testArray3);
PrintAnswer(testArray3);

int[] testArray4 = {5, 7, 9};
PrintArray(testArray4);
PrintAnswer(testArray4);

int[] testArray5 = {1, 3, 3, 3};
PrintArray(testArray5);
PrintAnswer(testArray5);

int[] testArray6 = {1, 1, 1, 1};
PrintArray(testArray6);
PrintAnswer(testArray6);

int[] testArray7 = {1};
PrintArray(testArray7);
PrintAnswer(testArray7);
System.Console.WriteLine("---------------------------------------------------------------");

Console.Write("Введите длину случайного массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(n);
Console.WriteLine("Ваш массив cлучайных чисел от 1 до {0}: ", n + n/2);
PrintArray(array);
PrintAnswer(array);

//-----------------------------------------------------------------------------------------
//ФУНКЦИИ: СОЗДАНИЕ МАССИВА И ВЫВОД НА ЭКРАН
int[] CreateRandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(1, size + size/2+1); //от 1 до полторы длины массива
    return array;
}
void PrintArray(int[] array)
{
    foreach (int el in array)
        Console.Write($"{el} ");
    Console.WriteLine();
}
//-------------------------------------------------------------------------------------------
//ФУНКЦИЯ, КОТОРАЯ ПРОВЕРЯЕТ, ЕСТЬ ЛИ В МАССИВЕ ЧИСЛО НА ЕДИНИЦУ БОЛЬШЕ ДАННОГО
bool NextNaturalPresent(int[] array, int value)
{
    bool answer = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == value + 1)
        {
            answer = true;
            break;
        }
    }
    return answer;
}
//-------------------------------------------------------------------------------------------
//ФУНКЦИЯ, КОТОРАЯ ВЫДАЕТ МИНИМАЛЬНЫЙ МАКСИМАЛЬНЫЙ ЭЛЕМЕНТ В ДАННОМ МАССИВЕ
void FindMin(int[] array, out int min, out int max)
{
    min = array[0];
    max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }
}
//-------------------------------------------------------------------------------------------
//ФУНКЦИЯ, КОТОРАЯ НА ВХОД ПРИНИМАЕТ МАССИВ, ИЩЕТ В НЕМ НАИБОЛЬШУЮ ПО ДЛИНЕ ПОСЛЕДОВАТЕЛЬНОСТЬ
//ПОДРЯД ИДУЩИХ ЧИСЕЛ И ВОЗВРАЩАЕТ ПЕРВОЕ И ПОСЛЕДНЕЕ ЧИСЛО ЭТОЙ ПОСЛЕДОВАТЕЛЬНОСТИ
void MaxSubsequenceBoundaries(int[] array, out int leftNumber, out int rightNumber)
{
    FindMin(array, out int min, out int max);
    int currentNumber = min;

    leftNumber = currentNumber; //итоговые левая и
    rightNumber = currentNumber;//правая граница которые будут в ответе

    int currentLeftNumber = currentNumber; //текущая лквая граница

    int maxSequenceLength = 1; // максимальная длина серии в итоге
    int currentSequenceLength = 1; //текущая длина серии

    while (currentNumber < max)
    {
        currentLeftNumber = currentNumber; //возможно станет новой левой границей если серия будет длиннее 
        currentSequenceLength = 1; // новая серия только начинается
        while (NextNaturalPresent(array, currentNumber))//Пока в массиве есть следующее число, 
        {                                               
            currentNumber++;                            //переходим к нему
            currentSequenceLength++;                    //и увеличиваем длину текущей серии
        }
        if (currentSequenceLength > maxSequenceLength) // Проверка стала ли новая серия длиннее прошлой
        {
            leftNumber = currentLeftNumber;  //если да, то обновляем левую границу
            rightNumber = currentNumber;     // и правую
            maxSequenceLength = currentSequenceLength;  // и длину максимальной серии
        }
        while ((!NextNaturalPresent(array, currentNumber)) && (currentNumber <= max)) //ищем начало новой серии
        {                        //если у числа нет в массиве следующего и он не больше максимума
            currentNumber++;  //берем следующее число
        }        
        currentNumber++;
    }
}
//-----------------------------------------------------------------------------------------
//ФУНКЦИЯ, ВЫДАЮЩАЯ ОТВЕТ ДЛЯ ДАННОГО МАССИВА
void PrintAnswer(int[] array)
{
MaxSubsequenceBoundaries(array, out int leftNumber, out int rightNumber);
if (leftNumber == rightNumber)
{
    Console.WriteLine("В массиве нет подряд идущих натуральных чисел.");
}
else
{
    Console.WriteLine("Наибольшая по длине последовательность натуральных чисел в этом массиве: [{0}, {1}]", leftNumber, rightNumber);
}
Console.WriteLine("----------------------------------------------------------");
}

