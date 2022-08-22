// Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("This program gives you a line of even numbers from 2 till input number.");
Console.WriteLine("Please input number: ");
int N = int.Parse(Console.ReadLine());
int count = 2;
while (count < N+1)
{
    Console.Write($"{count}, ");
    count++;
    count++;
}

