Console.Write("Введите число: ");
decimal n = Convert.ToDecimal(Console.ReadLine());

System.Console.WriteLine("Количество цифр в данном числе равно {0}.", 
DigitsAfterComma(n)+DigitsBeforeComma(n));

//----------ФУНКЦИЯ-КОЛИЧЕСТВО-ЦИФР-ПОСЛЕ-ЗАПЯТОЙ-----------
int DigitsAfterComma(decimal n)
{
    int count = 0;
    while (n > Math.Floor(n))  //умножаем на 10 пока число не сравняется со свой целой частью
    {
        n *= 10;
        count++;
    }
    return count;
}
//----------ФУНКЦИЯ-КОЛИЧЕСТВО-ЦИФР-ДО-ЗАПЯТОЙ-----------
int DigitsBeforeComma(decimal n)
{
    n = Convert.ToInt32(Math.Floor(n));
    int count = 1;
    while (n > 9)
    {
        n /= 10;
        count++;
    }
    return count;
}
