Console.WriteLine("Enter a positive integer number greater than 1:");
int n = Convert.ToInt32(Console.ReadLine());

int i = 2;
while (i <= n)
{
    Console.Write($"{i} ");
    i += 2;
}
Console.WriteLine();

