// Задача 4: Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел.
Console.WriteLine("This program will indicate maximum out of the 3 input numbers.");
Console.WriteLine("Input 1st number: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Input 2nd number: ");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine("Input 3rd number: ");
int number3 = int.Parse(Console.ReadLine());
int max = number1;

if (number1 >number2)
{
    if (number3 >number1)
    {
        max = number3;
    }
}
else if (number2 >number3)
{
    max = number2;
}
else 
    {
        max = number3;
    }

Console.Write($"Your maximum is: {max}.");