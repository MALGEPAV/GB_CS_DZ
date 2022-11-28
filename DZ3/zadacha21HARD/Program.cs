Console.Write("Введите размерность пространства: ");
int dim = Convert.ToInt32(Console.ReadLine());
int[] x = new int[dim];
int[] y = new int[dim];
Console.WriteLine("Введите координаты первой точки:");
for (int i = 0; i < dim; i++)
{
    Console.Write("x{0} = ", i + 1);
    x[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Введите координаты второй точки:");
for (int i = 0; i < dim; i++)
{
    Console.Write("y{0} = ", i + 1);
    y[i] = Convert.ToInt32(Console.ReadLine());
}
double r = Distance(x, y);
Console.WriteLine("Расстояние между точками {0} и {1} равно {2}", 
CoordinatesDisplay(x),CoordinatesDisplay(y),r);
//----------------фУНКЦИЯ-РАССТОЯНИЕ---------------------
double Distance(int[] x, int[] y)
{
    double r = 0;
    for (int j = 0; j < x.Length; j++)
    {
        r += (y[j] - x[j]) * (y[j] - x[j]);
    }
    r = Math.Sqrt(r);
    return r;
}
//----------------фУНКЦИЯ-ВЫВОД-КООРДИНАТ-ТОЧКИ---------------------
string CoordinatesDisplay(int[] x)
{
    string coordinates = "(";
    for (int k = 0; k < x.Length-1; k++)
    {
        coordinates +=  x[k].ToString()+",";
    }
    coordinates +=  x[^1].ToString()+")";
    return coordinates;
}