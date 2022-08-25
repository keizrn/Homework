// 3-digit number, returns second digit

Console.WriteLine("Please input 3-digit number.. ");
int num = int.Parse(Console.ReadLine());            

if ((num < -999) || ((num > -100) && (num < 100) || (num > 999)))   //range check - 3-digit?
{
    Console.WriteLine($"Your number {num} is out of range.");
}
else
{
    int result = num % 100 / 10;
    Console.WriteLine($"The middle digit of your number {num} is {result}.");
}