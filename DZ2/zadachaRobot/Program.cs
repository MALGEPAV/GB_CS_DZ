Console.Write("Введите количество: ");
int number = Convert.ToInt32(Console.ReadLine());

string ending = "";

int numberOfTens = (number / 10) % 10;
int lastDigit = number % 10;

if ((numberOfTens == 1) || (lastDigit == 0) || (lastDigit > 4)) ending = "ов";
else if (lastDigit == 1) ending = "";
else ending = "a";

Console.WriteLine($"{number} программист{ending}");