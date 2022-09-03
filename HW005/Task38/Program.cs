// Задайте массив вещественных чисел. Найдите разницу между 
//максимальным и минимальным элементов массива.
double[] RandomReal1(int size1, int min1, int max1)
{
    double[] array1 = new double[size1];
    int temp1 =0;
    for (int k = 0; k < size1; k++)
    {
        temp1 = new Random().Next(1,99);
        array1[k] = new Random().Next(min1,max1)+temp1*0.01;
    }
    return array1;
}

double DiffMinMax2(double[] array2)
{
    double min2 = array2[0];
    double max2 = array2[0];
    for (int i = 1; i < array2.Length; i++)
    {
        if (array2[i] < min2) min2 = array2[i];
        else if (array2[i] > max2) max2 = array2[i];
    }
    Console.WriteLine($"max is {max2}");
    Console.WriteLine($"min is {min2}");
    max2 = max2 - min2;
    return max2;
}

Console.WriteLine("Would you like to continue with a standard random array?");
Console.WriteLine("5 REAL numbers, randomly chosen from [-999, 1000)");
Console.WriteLine("If you choose 'No', you will input your own parameters. Y/N?..");
string text0 = Console.ReadLine();
bool check0 = char.TryParse(text0, out char char0);
char0 = char.ToUpper(char0);
int size0 = 0;
int min0 = 0;
int max0 = 0;

if ((check0 == false) || ((char0 != 'Y') && (char0 != 'N')))
{
    Console.WriteLine("Your choice was not correct.");
}
else
{
if (char0 == 'N')
{
    Console.WriteLine("Input array dimension (size)..");
    size0 = int.Parse(Console.ReadLine());
    Console.WriteLine("Input min value (it may appear in an array)..");
    min0 = int.Parse(Console.ReadLine());
    Console.WriteLine("Input max value (it will not be included in the array)..");
    max0 = int.Parse(Console.ReadLine());
}
else
{
    size0 = 5;
    min0 = -999;
    max0 = 1000;
}

double[] array0 = RandomReal1(size0, min0, max0);
Console.WriteLine(String.Join(" ",array0));
Console.WriteLine($"Diff btw max & min is {DiffMinMax2(array0):f2}");
}