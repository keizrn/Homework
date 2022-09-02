// Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе.

int CountDigits1(int num1)      //A function to count digits
{
    int count1 = 0;
    while (num1/10 != 0)
    {
        count1++;
        num1 = num1/10;
    }
    count1++;
    return count1;
}

int SumDigits2(int num2, int count2)    //A function to sum digits
{
    if (num2 < 0) num2 = -num2;         //eliminate negative sign
    int sum2 = 0;
    for (int i=0; i < count2; i++)
    {
        sum2 = sum2 + (num2 % 10);
        num2 = num2 / 10;
    }
    return sum2;
}

Console.WriteLine("Input number..");
string text0 = Console.ReadLine();
bool check0 = int.TryParse(text0, out int num0);    //checks if there is text or empty string
if (check0) Console.WriteLine($"Sum of digits is {SumDigits2(num0,CountDigits1(num0))}");
else Console.WriteLine("Your input is incorrect");