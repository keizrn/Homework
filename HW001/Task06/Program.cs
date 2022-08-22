// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("This Program tests if the input number is even.");
Console.WriteLine("Input your number: ");
int number = int.Parse(Console.ReadLine());
if (number % 2 != 0)
{
    Console.WriteLine($"Your number({number}) is uneven");
}
else 
{
    Console.WriteLine($"Your number({number}) is even");
}