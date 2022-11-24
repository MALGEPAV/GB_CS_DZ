Console.Write("Enter a three-digit integer: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number>99 && number<1000)
{
    int secondDigit = (number/10)%10;
    Console.WriteLine($"The second digit is {secondDigit}");
}
else
{
    Console.WriteLine("This is not a three-digit integer.");
}
