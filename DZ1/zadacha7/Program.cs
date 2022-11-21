Console.WriteLine("Enter a positive integer:");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 99)
{
    double number_of_digits = Math.Floor(Math.Log10(n)) + 1;
    n = n / Convert.ToInt32(Math.Pow(10, number_of_digits-3));
    int third_digit = n%10;
    Console.WriteLine($"The third digit of your number is: {third_digit}");
}
else
{
    Console.WriteLine("Your number consists of fewer than 3 digits, sorry.");
}