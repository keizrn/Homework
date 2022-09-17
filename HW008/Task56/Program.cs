// Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.

int[,] CreateArray1(int rows1, int cols1, int min1a, int max1a)
{
    int[,] array1 = new int[rows1, cols1];
    for (int i1 = 0; i1 < rows1; i1++)
    {
        for (int j1 = 0; j1 < cols1; j1++)
        {
            array1[i1, j1] = new Random().Next(min1a, max1a + 1);
        }
    }
    return array1;
}

int FindMaxRow2(int[,] array2)
{
    int rows2 = array2.GetLength(0);
    int cols2 = array2.GetLength(1);
    int temp2 = 0;
    int minSum2 = 0;
    int minIndex2 = 0;
    Console.WriteLine("Control Sums:");

    for (int i2 = 0; i2 < rows2; i2++)
    {
        for (int j2 = 0; j2 < cols2; j2++)
        {
            temp2 += array2[i2, j2];
        }
        if ((i2 == 0) || (temp2 < minSum2))
        {
            minSum2 = temp2;
            minIndex2 = i2;
        }
        Console.WriteLine(temp2);
        temp2 = 0;
    }
    return minIndex2;
}

void PrintArray4(int[,] array4)
{
    int rows4 = array4.GetLength(0);
    int cols4 = array4.GetLength(1);
    Console.WriteLine();
    for (int p = 0; p < rows4; p++)
    {
        for (int q = 0; q < cols4; q++)
        {
            Console.Write($"{array4[p, q]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine("This Program will create array and find a row with lowest sum.");
int[,] array0 = CreateArray1(5, 10, 0, 20);
Console.WriteLine("Initial array:");
PrintArray4(array0);

int minRow0 = FindMaxRow2(array0);
Console.WriteLine("A row with a minimum sum is:");
Console.WriteLine($"{minRow0}");