// Checks if the 5-digit number is a palindrome number
Console.WriteLine("We will now check if your 5-digit number is a palindrome.");
Console.WriteLine("Please input 5-digit number.. ");
int num = int.Parse(Console.ReadLine());
if ((num < -99999) || ((num > -10000) && (num < 10000) || (num > 99999)))   //check if it's 5-digit
{
    Console.WriteLine($"Your number {num} is not a 5-digit number.");
}
else
{
    int dig5 = num / 10000;
    int dig4 = num % 10000 / 1000;
    int dig2 = num % 100 / 10;
    int dig1 = num % 10;
    if ((dig5 == dig1) && (dig4 == dig2))
    {
        Console.WriteLine($"Your number {num} is a palindrome number.");
    }
    else Console.WriteLine($"Number {num} is just a 5-digit number. Try another one.");   
}