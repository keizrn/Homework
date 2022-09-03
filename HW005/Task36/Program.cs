// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
int[] RandomArray2(int size2, int min2, int max2)
{
    int[] array2 = new int[size2];
    for (int k = 0; k < size2; k++)
    {
        array2[k] = new Random().Next(min2,max2);
    }
    return array2;
}

int SumUneven1(int[] array1)
{
    int sum1 = 0;
    for (int i = 1; i < array1.Length; i+=2)
    {
        sum1 = sum1 + array1[i];
    }
    return sum1;
}

Console.WriteLine("Would you like to continue with a standard random array?");
Console.WriteLine("4 numbers, randomly chosen from [-99, 100)");
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
    size0 = 4;
    min0 = -99;
    max0 = 100;
}

int[] array0 = RandomArray2(size0, min0, max0);
Console.WriteLine(String.Join(" ",array0));
Console.WriteLine($"The sum of numbers with uneven indices is {SumUneven1(array0)}");
}