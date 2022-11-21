Console.WriteLine("Enter two numbers (press ENTER after each number):");
int n1 = Convert.ToInt32(Console.ReadLine());
int n2 = Convert.ToInt32(Console.ReadLine());

if (n1 > n2)
{
    Console.WriteLine($"max = {n1}");
}
else
{
    Console.WriteLine($"max = {n2}");
}