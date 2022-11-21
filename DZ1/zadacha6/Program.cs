Console.WriteLine("Enter a number:");
int n = Convert.ToInt32(Console.ReadLine());

string answer = "";
if (n % 2 == 1)
{
    answer = "odd";
}
else
{
    answer = "even";
}
Console.WriteLine("Your number is " + answer);
