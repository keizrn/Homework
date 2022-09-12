// Напишите программу, которая на вход принимает число и генерирует случайный двумерный массив, 
//и возвращает индексы этого элемента или же указание, что такого элемента нет.

int count_gl = 0;
string text_gl = "";
bool check_gl = false;

int[] InputData0()
{
    int[] arrayA = new int[5];
    Console.WriteLine("Please input array dimensions..");
    check_gl = int.TryParse(Console.ReadLine(), out arrayA[0]);
    if (check_gl == true)
    {
        check_gl = int.TryParse(Console.ReadLine(), out arrayA[1]);
        if (check_gl == true)
        {
            Console.WriteLine("Please input min & max values of the array..");
            check_gl = int.TryParse(Console.ReadLine(), out arrayA[2]);
            if (check_gl == true)
            {
                check_gl = int.TryParse(Console.ReadLine(), out arrayA[3]);
                if (check_gl == true)
                {
                    Console.WriteLine("Now input target value to search..");
                    check_gl = int.TryParse(Console.ReadLine(), out arrayA[4]);
                }
            }
        }
    }
    if ((arrayA[0] < 1) || (arrayA[1] < 1) || (arrayA[2] > arrayA[3])) check_gl = false;
    return arrayA;
}

int[,] GenerateArray1(int row1, int col1, int min1, int max1, int target1)
{
    int[,] array1 = new int[row1, col1];
    bool check1 = false;
    for (int i = 0; i < row1; i++)
    {
        for (int j = 0; j < col1; j++)
        {
            array1[i, j] = new Random().Next(min1, max1 + 1);
            if (array1[i, j] == target1)  //eliminate check
            {
                count_gl++;
                if (check1 == false)
                {
                    if (count_gl != 1) text_gl = text_gl + ", ";
                    text_gl = text_gl + "(" + i + "," + j + ")";
                    check1 = true;
                }
            }
        }
    }
    return array1;
}

void PrintArray2(int[,] array2, int target2)
{
    int row2 = array2.GetLength(0);
    int col2 = array2.GetLength(1);
    for (int k = 0; k < row2; k++)
    {
        for (int l = 0; l < col2; l++)
        {
            if (array2[k, l] == target2) Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{array2[k, l]}\t");
            Console.ForegroundColor = ConsoleColor.White;
        }
        Console.WriteLine();
    }
}

int[] arrayI = InputData0();
if (check_gl == true)
{
    int[,] array0 = GenerateArray1(arrayI[0], arrayI[1], arrayI[2], arrayI[3], arrayI[4]);
    Console.WriteLine("Random array is:");
    PrintArray2(array0, arrayI[4]);
    Console.WriteLine();
    if (count_gl == 0) Console.WriteLine("Your target number did not appear.");
    else

        Console.WriteLine($"Your target number {arrayI[4]} appears {count_gl} time(s), for the 1st time in cell: {text_gl}");
}
else Console.WriteLine("Your input was incorrect");