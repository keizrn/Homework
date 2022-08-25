// checks if the # of the day is a weekday or a weekend

Console.WriteLine("Please input number of the day of the week..");
int day = int.Parse(Console.ReadLine());

if ((day < 1) || (day > 7))
{
    Console.WriteLine($"Your number {day} is out of range.");
}
else 
{
    if ((day == 6) || (day == 7))
    {
        Console.WriteLine("Today is a day-off, go back to sleep.");
    }
    else Console.WriteLine("It's a weekday. Get up, go to work.");
}