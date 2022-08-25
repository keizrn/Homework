// shows third digit in any number, or informs that there is no such digit
// Not for self: BEWARE that 0 hundreds is not the same as No Hundreds!!

Console.WriteLine("This program will show the amount of hundreds in your number. Please input number.. ");
int num = int.Parse(Console.ReadLine());

if ((num > -100) && (num < 100))        //check if it's 3-digit or higher
{
    Console.WriteLine($"Your number {num} is less than 3-digit, so there is no 3rd digit.");
}
else
{   if (num < 0)        //check if it's negative to eliminate minus
    {   
        num = - num;
    }
    int result = num % 1000 / 100;
    Console.WriteLine($"The 3rd digit of your number {num} is {result}.");
}