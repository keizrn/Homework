// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

int[] RandonNum1(int size1, int min1, int max1)
{
    int[] array1 = new int[size1];
    for (int i = 0; i < size1; i++)
    {
        array1[i] = new Random().Next(min1,max1);
    }
return array1;
}

int CountEven2(int[] array2)
{
    int count2 = 0;
    for (int j = 0; j < array2.Length; j++)
    {
        if (array2[j] % 2 == 0) count2++; 
    }
return count2;
}

Console.WriteLine("Input array length..");
string text0 = Console.ReadLine();
bool check0 = int.TryParse(text0,out int size0);
if ((check0 == false) || (size0 < 1)) Console.WriteLine("Your input is incorrect");
else
{
    int[] array0 = RandonNum1(size0, 100, 1000);
    Console.WriteLine(string.Join(" ",array0));
    Console.WriteLine($"There are {CountEven2(array0)} even numbers in the array.");
}