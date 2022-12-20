Console.Write("Введите натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(PrintNumbers(n));

string PrintNumbers(int n) =>
n switch
{
1 => "1",
_ => n.ToString()+", "+PrintNumbers(n-1)
};
