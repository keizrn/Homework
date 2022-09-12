// Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.
double[,] CreateRealArray1(int row1, int col1, double min1, double max1)
{
    double[,] array1 = new double[row1,col1];
    double temp1 = 0;
    int temp100 = 0;
    int min100 = Convert.ToInt32(min1*100);
    int max100 = Convert.ToInt32(max1*100);

    for (int i = 0; i < row1; i++)
    {
        for (int j = 0; j < col1; j++)
        {
            temp1 = new Random().NextDouble();
            temp100 = new Random().Next(min100, max100);
            array1[i,j] = (temp100 + temp1) / 100;
            if (array1[i,j] > max1) array1[i,j] = max1;
        }
    }
    return array1;
}

void PrintArray2(double[,] array2)
{
    int col2 = array2.GetLength(1);
    int count2 = 1;
    foreach (double k in array2)
    {
        Console.Write($"{k:f2}\t");
        if (count2 == col2) 
        {
            count2 = 1;
            Console.WriteLine();
        }
        else count2++;
    }
}

Console.WriteLine("This program will generate 2-dimensional array of real numbers.");
Console.WriteLine("Input array dimensions..");
bool check0 = int.TryParse(Console.ReadLine(), out int m);
if ((check0) && (m > 0))
{
    check0 = int.TryParse(Console.ReadLine(), out int n);
    if ((check0) && (n > 0))
    {
        Console.WriteLine("You may input array boundaries now as real numbers, but not more than 2 digits after comma (0.00)");
        Console.WriteLine("Input min & max..");
        check0 = double.TryParse(Console.ReadLine(), out double min0);
        if (check0)
        {
            check0 = double.TryParse(Console.ReadLine(), out double max0);
            if ((check0) && (max0 > min0))
            {
                double[,] array0 = CreateRealArray1(m, n, min0, max0);
                PrintArray2(array0);
                Console.WriteLine($"Array is created of real numbers. E.g., the last element is: {array0[m-1,n-1]}");
            }
            else Console.WriteLine("Your input was incorrect");
        }
        else Console.WriteLine("Your input was incorrect");
    }
    else Console.WriteLine("Your input was incorrect");
}
else Console.WriteLine("Your input was incorrect");