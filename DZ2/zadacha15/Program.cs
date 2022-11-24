Console.Write("Enter the number of any day of the week: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
if (dayNumber>0 && dayNumber<8)
{
    if (dayNumber > 5)
    {
        Console.WriteLine("This IS a day off");
    }
    else 
    {
        Console.WriteLine("This is NOT a day off");
    }
}
else 
{
    Console.WriteLine("This is not a number of any day of the week.");
}