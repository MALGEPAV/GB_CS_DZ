Console.Write("Введите натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());
string reply = "";
if (IsPalindrome(n))
{
    reply = "Число является палиндромом.";
}
else
{
    reply  = "Число НЕ является палиндромом";
}
System.Console.WriteLine(reply);
//-----------ФУНКЦИЯ-ПРОВЕРКА--------------------------------------------------
bool IsPalindrome(int number)
{
    bool answer = true;
    //Находим количество цифр
    int length = 1;
    if (n>0)
    {
        length = Convert.ToInt32(Math.Floor(Math.Log10(number))) + 1;
    }
    for (int i = 1; i <= length / 2; i++)
    {
        //Цифра на позиции i считая слева:
        int leftDigit = number / Convert.ToInt32(Math.Pow(10, length - i)) % 10;
        //Цифра на позиции i считая справа:
        int rightDigit = number / Convert.ToInt32(Math.Pow(10, i-1)) % 10;
        if (leftDigit != rightDigit)
        {
            answer = false;
            break;
        }
    }
    return answer;
}


