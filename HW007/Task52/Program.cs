// Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
int row_gl = 0;
int col_gl = 0;
int min_gl = 0;
int max_gl = 0;


bool InputData1()
{
    bool check1 = false;
    Console.WriteLine("Input number of rows in an array..");
    check1 = int.TryParse(Console.ReadLine(), out row_gl);
    if (check1 && (row_gl > 0))
    {
        Console.WriteLine("Input number of columns in the array..");
        check1 = int.TryParse(Console.ReadLine(), out col_gl);
        if (check1 && (col_gl > 0))
        {
            Console.WriteLine("Input min value (included)");
            check1 = int.TryParse(Console.ReadLine(), out min_gl);
            if (check1)
            {
                Console.WriteLine("Input max value (included)");
                check1 = int.TryParse(Console.ReadLine(),out max_gl);
            }
        }
    }
    if (max_gl < min_gl) check1 = false;
    return check1;
}

int[,] GenerateArray2()
{
    int[,] array2 = new int[row_gl, col_gl];
    for (int i = 0; i < row_gl; i++)
    {
        for (int j = 0; j < col_gl; j++)
        {
            array2[i,j] = new Random().Next(min_gl,max_gl+1);
        }
        
    }
    return array2;
}

double[,] CalcAverage4(int[,] array4)
{
    int temp4 = 0;
    int row4 = array4.GetLength(0);
    int col4 = array4.GetLength(1);
    double[,] array4av = new double[2,col4];
    for (int p = 0; p < col4; p++)
    {
        for (int q = 0; q < row4; q++)
        {
            temp4 = temp4 + array4[q,p];
        }
        array4av[0,p] = (double)temp4;
        array4av[1,p] = (double)temp4 / row4;
        //Console.WriteLine($"{temp4} {p} in {col4} = {array4av[p]}");
        temp4 = 0;
    }
    return array4av;
}


void PrintArray3(int[,] array3)
{
    Console.Write($"\t");
    for (int k2 = 0; k2 < col_gl; k2++)
    {
        Console.Write($"Col{k2+1}\t");
    }
    Console.WriteLine();
    for (int k = 0; k < row_gl; k++)
    {
        Console.Write($"Row{k+1}\t");
        for (int l = 0; l < col_gl; l++)
        {
            Console.Write($"{array3[k,l]}\t");
        }
        Console.WriteLine();
    }
}

void PrintArray5(double[,] array5)
{
        Console.Write($"Sum:\t");
        for (int r = 0; r < array5.GetLength(1); r++)
        {
            Console.Write($"{array5[0,r]:f2}\t");
        }
        Console.WriteLine();
        Console.Write($"WAv:\t");
        for (int r2 = 0; r2 < array5.GetLength(1); r2++)
        {
            Console.Write($"{array5[1,r2]:f2}\t");
        }
        Console.WriteLine();
        Console.WriteLine();
}

if (InputData1())
{
    int[,] array0 = GenerateArray2();
    PrintArray3(array0);
    Console.WriteLine();
    double[,] array0av = CalcAverage4(array0);
    PrintArray5(array0av);
}
else Console.WriteLine("Your input was not correct");


//Console.WriteLine($"{row_gl}, {col_gl}, {min_gl}, {max_gl}");