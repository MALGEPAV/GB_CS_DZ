string F = "";
string B = "";
string j = "";
for (int i=1; i<101; i++)
{
    F = "";
    B = "";
    j=i.ToString();
    if (i%3 == 0) {F="Fizz"; j = "";}
    if (i%5 == 0) {B="Buzz"; j = "";}
    Console.Write(j+F+B+" ");
}
Console.WriteLine();
