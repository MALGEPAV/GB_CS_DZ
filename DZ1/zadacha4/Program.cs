Console.WriteLine("Enter three numbers (press ENTER after each number):");
int n1 = Convert.ToInt32(Console.ReadLine());
int n2 = Convert.ToInt32(Console.ReadLine());
int n3 = Convert.ToInt32(Console.ReadLine());  

int max = n1;
if (n2>max)
{
    max=n2;
}
if (n3>max)
{
    max=n3;
}
Console.WriteLine($"max = {max}");