// Задайте две матрицы. 
//Напишите программу, которая будет находить произведение двух матриц.

//Произведением двух матриц А и В называется матрица С, элемент которой, 
//находящийся на пересечении i-й строки и j-го столбца, равен сумме 
//произведений элементов i-й строки матрицы А на соответствующие 
//(по порядку) элементы j-го столбца матрицы В.

(bool, int, int, int, int) InputData1()
{
    int m1 = 0;
    int n1 = 0;
    int min1 = 0;
    int max1 = 0;
    Console.WriteLine("Multiplication of matrices.");
    Console.WriteLine("Input array dimensions (# of rows, then # of columns)..");
    bool check1 = int.TryParse(Console.ReadLine(), out m1);
    if ((check1) && (m1 > 0))
    {
        check1 = int.TryParse(Console.ReadLine(), out n1);
        if ((check1) && (n1 > 0))
        {
            Console.WriteLine("Input min & max values..");
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

int[,] MultiplyArrays2(int[,] arrayA, int[,] arrayB)
{
    int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    int rows2 = arrayA.GetLength(0);
    int cols2 = arrayB.GetLength(1);
    int items2 = arrayA.GetLength(1);
    int temp2 = 0;
    for (int i2 = 0; i2 < rows2; i2++)
    {
        for (int i2a = 0; i2a < cols2; i2a++)
        {
            for (int j2 = 0; j2 < items2; j2++)
            {
                temp2 += arrayA[i2, j2] * arrayB[j2, i2a];
            }
            arrayC[i2, i2a] = temp2;
            temp2 = 0;
        }
    }
    return arrayC;
}

void PrintArray4(int[,] array4)
{
    int rows4 = array4.GetLength(0);
    int cols4 = array4.GetLength(1);
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
    int[,] arrayA0 = CreateArray1(m0, n0, min0, max0);
    Console.WriteLine();
    Console.WriteLine("Matrix1:");
    PrintArray4(arrayA0);
    int[,] arrayB0 = CreateArray1(n0, m0, min0, max0);
    Console.WriteLine("Matrix2:");
    PrintArray4(arrayB0);
    int[,] arrayC0 = MultiplyArrays2(arrayA0, arrayB0);
    Console.WriteLine("Resulting Matrix:");
    PrintArray4(arrayC0);
}
else Console.WriteLine("Your Input is incorrect.");