// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, 
//добавляя индексы каждого элемента.

(bool, int, int, int) InputData1()
{
    int l1 = 0;
    int m1 = 0;
    int n1 = 0;
    Console.WriteLine("This program will create 3D array and fill it in with unique numbers.");
    Console.WriteLine("Input 3(!) array dimensions..");
    bool check1 = int.TryParse(Console.ReadLine(), out l1);
    if ((check1) && (l1 > 0))
    {
        check1 = int.TryParse(Console.ReadLine(), out m1);
        if ((check1) && (m1 > 0))
        {
            check1 = int.TryParse(Console.ReadLine(), out n1);
            if ((check1) && (n1 > 0))
            {
            }
            else check1 = false;
        }
        else check1 = false;
    }
    else check1 = false;
    if (l1 * m1 * n1 > 90) check1 = false;          //проверим, что хватит уникальных двухзначных значений
    return (check1, l1, m1, n1);
}

int[,,] CreateArray1(int rows1, int cols1, int block1)
{
    int[,,] array1 = new int[rows1, cols1, block1];
    int arrayLen1 = rows1 * cols1 * block1;
    bool[] valuesCheck = new bool[100];         //создаем массив для проверки уникальности по индексам
    int temp1 = 0;
    for (int i1 = 0; i1 < rows1; i1++)
    {
        for (int j1 = 0; j1 < cols1; j1++)
        {
            for (int k1 = 0; k1 < block1; k1++)
            {
                do temp1 = new Random().Next(10, 100);      //искать случайное число пока в проверочном массиве не будет Ложь. Если Истина - значение индекса уже занято
                while (valuesCheck[temp1] == true);
                array1[i1, j1, k1] = temp1;
                valuesCheck[temp1] = true;
            }
        }
    }
    temp1 = 0;
    for (int i2 = 0; i2 < 100; i2++)
    {
        if (valuesCheck[i2]) temp1++;
    }
    Console.WriteLine($"Number of unique items in an array: {temp1}");
    return array1;
}

void PrintArray4(int[,,] array4)
{
    int rows4 = array4.GetLength(0);
    int cols4 = array4.GetLength(1);
    int block4 = array4.GetLength(2);
    Console.WriteLine();
    for (int r = 0; r < block4; r++)
    {
        Console.WriteLine($"Block {r}");
        for (int p = 0; p < rows4; p++)
        {
            for (int q = 0; q < cols4; q++)
            {
                Console.Write($"[{p},{q},{r}]: {array4[p, q, r]}\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

(bool check0, int l0, int m0, int n0) = InputData1();
if (check0)
{
    Console.WriteLine();
    int[,,] array0 = CreateArray1(l0, m0, n0);
    PrintArray4(array0);
}
else Console.WriteLine("Your input was incorrect.");