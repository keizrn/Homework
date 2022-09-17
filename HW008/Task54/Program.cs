// Задайте двумерный массив. Напишите программу, которая упорядочит 
//по убыванию элементы каждой строки двумерного массива.

(bool, int, int, int, int) InputData1()
{
    int m1 = 0;
    int n1 = 0;
    int min1 = 0;
    int max1 = 0;
    Console.WriteLine("This Program will sort each row of your array in descending order.");
    Console.WriteLine("Input array dimensions..");
    bool check1 = int.TryParse(Console.ReadLine(), out m1);
    if ((check1) && (m1 > 0))
    {
        check1 = int.TryParse(Console.ReadLine(), out n1);
        if ((check1) && (n1 > 0))
        {
            Console.WriteLine("Input min & max..");
            check1 = int.TryParse(Console.ReadLine(), out min1);
            if (check1)
            {
                check1 = int.TryParse(Console.ReadLine(), out max1);
                if (max1 < min1) check1 = false;
            }
        }
        else check1 = false;
    }
    else check1 = false;
    return (check1, m1, n1, min1, max1);
}

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

int[,] SortArray5(int[,] array5)
{
    int rows5 = array5.GetLength(0);
    int cols5 = array5.GetLength(1);
    int[] arrayTemp5 = new int[cols5];
    for (int i5 = 0; i5 < rows5; i5++)
    {
        for (int j5 = 0; j5 < cols5; j5++)
        {
            arrayTemp5[j5] = array5[i5, j5];
        }
        arrayTemp5 = SortRow6(arrayTemp5);
        for (int j5a = 0; j5a < cols5; j5a++)
        {
            array5[i5, j5a] = arrayTemp5[j5a];
        }
    }
    return array5;
}

int[] SortRow6(int[] array6)
{
    int items6 = array6.Length;
    int temp6 = 0;
    bool switch6 = false;
    for (int times6 = 0; times6 < items6; times6++)
    {
        for (int i6 = 0; i6 < items6 - 1; i6++)
        {
            if (array6[i6] < array6[i6 + 1])
            {
                switch6 = true;
                temp6 = array6[i6];
                array6[i6] = array6[i6 + 1];
                array6[i6 + 1] = temp6;
            }
        }
        if (switch6) switch6 = !switch6;
        else return array6;
    }
    return array6;
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

(bool check0, int m0, int n0, int min0, int max0) = InputData1();
if (check0)
{
    Console.WriteLine();
    int[,] array0 = CreateArray1(m0, n0, min0, max0);
    Console.WriteLine("Initial array:");
    PrintArray4(array0);

    int[,] arraySorted0 = SortArray5(array0);
    Console.WriteLine("Sorted array:");
    PrintArray4(arraySorted0);
}
else Console.WriteLine("Your input was incorrect.");