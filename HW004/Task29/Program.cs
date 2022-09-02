// Напишите программу, которая задаёт массив из N элементов, 
//заполненных случайнми числами из [a, b) и выводит их на экран.

int[] CreateArray1(int size1, int min1, int max1)
{
    int[] array1 = new int[size1];
    for (int i = 0; i < size1; i++)
    {
        array1[i] = new Random().Next(min1,max1);
    }
    return array1;
}

Console.WriteLine("Input array length, min, max values split with blank_spaces.");
Console.WriteLine("Please note that your max value will NOT be included into the array.");
Console.WriteLine("Your input..");
string[] token1 = Console.ReadLine().Split();
int length0 = int.Parse(token1[0]);
int min0 = int.Parse(token1[1]);
int max0 = int.Parse(token1[2]);
if (min0 > max0)        //if the range is reversed
{
    int temp0 = min0;
    min0 = max0;
    max0 = temp0;
}
Console.WriteLine(string.Join(" ",CreateArray1(length0, min0, max0)));