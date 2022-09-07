// Rolling out 2-dimensional array into a one-dimension line

void FillMatrix1(int[,] matrix1)
{
    for (int k = 0; k < matrix1.GetLength(0); k++)
    {
        for (int l = 0; l < matrix1.GetLength(1); l++)
        {
            matrix1[k,l] = new Random().Next(1,100);
        }
    }
}

void PrintMatrix2(int[,] matrix2)
{
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            Console.Write($"{matrix2[i,j]} ");
        }
        Console.WriteLine();    
    }
}

string RolloutArray4(int[,] matrix4, bool row_b, bool direct_b, int count4, int row_c2, int col_c2, int row_gl2, int col_gl2)
{
    string text4 = "";
    if (row_b == true)      //идем по ряду
    {
        if (direct_b == true) //идем вперед
            {
                for (int i4 = col_c2; i4 < (col_gl2 + col_c2);i4++)
                {
                    text4 = text4 + matrix4[row_c2,i4] + " ";
                }
                row_c2--;
                col_c2 = col_gl2 + col_c2 - 1;
            }
            else        //идем обратно
            {
                for (int j4 = col_c2; j4 > (col_c2 - col_gl2);j4--)
                {
                    text4 = text4 + matrix4[row_c2,j4] + " ";
                }
                col_c2 = col_c2 - col_gl2 + 1; 
                row_c2++;
            }
        row_gl2--;       //уменьшаем счетчик рядов
    }

    else            //идем по колонке
    {
        if (direct_b == true)   //идем вперед
            {
                for (int k4 = row_c2; k4 < (row_gl2 + row_c2);k4++)
                {
                    text4 = text4 + matrix4[k4,col_c2] + " ";
                }
                row_c2 = row_gl2 + row_c2 - 1;
                col_c2++;
            }
        else                //идем обратно
            {
                for (int l4 = row_c2; l4 > (row_c2 - row_gl2);l4--)
                {
                    text4 = text4 + matrix4[l4,col_c2] + " ";
                }
                row_c2 = row_c2 - row_gl2 + 1;
                col_c2--;
            }
        col_gl2--;           // уменьшаем счетчик колонок
    }
    if (count4 == 1) 
    {
        direct_b = !direct_b;   //переключаем направление       
        count4 = 0;
    }
    else count4++;
row_b = !row_b;
//Console.WriteLine($"{text4} - check {count4} - row_bool {row_b} - col_c: {col_c2} - row_c: {row_c2} - col_gl: {col_gl2} - row_gl: {row_gl2}");
if ((row_gl2 != 0) && (col_gl2 != 0)) text4 = text4 + RolloutArray4(matrix4,row_b,direct_b,count4,row_c2,col_c2,row_gl2,col_gl2);
return text4;
}

Console.WriteLine("Input number of lines in an array..");
int row_gl = int.Parse(Console.ReadLine());
Console.WriteLine("Input number of columns in an array..");
int col_gl = int.Parse(Console.ReadLine());

int [,] matrix0 = new int[row_gl,col_gl];
FillMatrix1(matrix0);
int row_c = matrix0.GetLength(0)-1;
int col_c = 0;
string text0 = RolloutArray4(matrix0,true, true,1,row_c,col_c,row_gl,col_gl);
PrintMatrix2(matrix0);
Console.WriteLine();
Console.WriteLine(text0);