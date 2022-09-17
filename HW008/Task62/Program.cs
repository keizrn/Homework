// Напишите программу, которая заполнит спирально массив 4 на 4.
//Реализован произвольный массив

(bool, int, int) InputData1()
{
    int m1 = 0;
    int n1 = 0;
    Console.WriteLine("Spiral filling in of ANY array.");
    Console.WriteLine("Input 2 array dimensions..");
    bool check1 = int.TryParse(Console.ReadLine(), out m1);
    if ((check1) && (m1 > 0))
    {
        check1 = int.TryParse(Console.ReadLine(), out n1);
        if ((check1) && (n1 > 0))
        { }
        else check1 = false;
    }
    else check1 = false;
    return (check1, m1, n1);
}

void PrintMatrix2(int[,] matrix2)
{
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            Console.Write($"{matrix2[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] RolloutArray4(int[,] matrix4, int rowsTotal4, int colsTotal4, int rowCurrent4 = 0, int colCurrent4 = 0, int countDirections = 0, bool row_b = true, bool direct_b = true, int temp4 = 1)
{
    if (row_b)      //идем по ряду
    {
        if (direct_b) //идем вперед
        {
            for (int i4 = colCurrent4; i4 < (colsTotal4 + colCurrent4); i4++)
            {
                matrix4[rowCurrent4, i4] = temp4;
                temp4++;
            }
            rowCurrent4++;
            colCurrent4 = colsTotal4 + colCurrent4 - 1;

        }
        else        //идем обратно
        {
            for (int j4 = colCurrent4; j4 > (colCurrent4 - colsTotal4); j4--)
            {
                matrix4[rowCurrent4, j4] = temp4;
                temp4++;
            }
            colCurrent4 = colCurrent4 - colsTotal4 + 1;
            rowCurrent4--;
        }
        rowsTotal4--;       //уменьшаем счетчик рядов
    }

    else            //идем по колонке
    {
        if (direct_b)   //идем вперед
        {
            for (int k4 = rowCurrent4; k4 < (rowsTotal4 + rowCurrent4); k4++)
            {
                matrix4[k4, colCurrent4] = temp4;
                temp4++;
            }
            rowCurrent4 = rowsTotal4 + rowCurrent4 - 1;
            colCurrent4--;
        }
        else                //идем обратно
        {
            for (int l4 = rowCurrent4; l4 > (rowCurrent4 - rowsTotal4); l4--)
            {
                matrix4[l4, colCurrent4] = temp4;
                temp4++;
            }
            rowCurrent4 = rowCurrent4 - rowsTotal4 + 1;
            colCurrent4++;
        }
        colsTotal4--;           // уменьшаем счетчик колонок
    }
    if (countDirections == 1)
    {
        direct_b = !direct_b;   //переключаем направление       
        countDirections = 0;
    }
    else countDirections++;
    row_b = !row_b;
    //Console.WriteLine($"{temp4} - check {countDirections} - row_bool {row_b} - direct_b {direct_b} - col_c: {colCurrent4} - row_c: {rowCurrent4} - col_gl: {colsTotal4} - row_gl: {rowsTotal4}");
    if ((rowsTotal4 != 0) && (colsTotal4 != 0)) matrix4 = RolloutArray4(matrix4, rowsTotal4, colsTotal4, rowCurrent4, colCurrent4, countDirections, row_b, direct_b, temp4);
    return matrix4;
}

(bool check0, int rows, int columns) = InputData1();
int[,] matrix0 = new int[rows, columns];
int[,] matrix1 = RolloutArray4(matrix0, rows, columns);
PrintMatrix2(matrix0);
Console.WriteLine();