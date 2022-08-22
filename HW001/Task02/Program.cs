// Задача 2: Напишите программу, которая на вход принимает два числа 
//и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("This program will indicate maximum and minumum out of the 2 input numbers.");
Console.WriteLine("Input 1st number: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Input 2nd number: ");
int number2 = int.Parse(Console.ReadLine());
int max = number2;
int min = number1;

if (number1 >number2)
{
    max = number1;
    min = number2;
    }


Console.Write($"Your maximum is: {max}, your minimum is {min}.");