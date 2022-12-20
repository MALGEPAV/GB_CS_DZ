Console.Write("Введите целое неотрицательное число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое неотрицательное число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"A({m},{n})={Akkerman(m,n)}");

int Akkerman(int m, int n)
{
    if (m==0) return (n+1);
    if (n==0) return Akkerman(m-1, 1);
    return Akkerman(m-1,Akkerman(m,n-1));
}

