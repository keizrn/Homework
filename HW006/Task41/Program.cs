// Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
int[] CleanArray2(string[] token2)      //cleaning from null, text
{
    int size2 = token2.Length;
    int count2 = 0;
    for (int k = 0; k < size2; k++)
    {
        if (int.TryParse(token2[k], out int temp0)) count2++;
    }
    
    int[] array2 = new int[count2];
    count2 = 0;
    for (int l = 0; l < size2; l++)
    {
        if (int.TryParse(token2[l], out int temp0))
        {
            int.TryParse(token2[l], out array2[count2]);
            count2++; 
        }
    }
return array2;
}

int CountPositive1(int[] array1)
{
    int size1 = array1.Length;
    int count1 = 0;
    for (int i = 0; i < size1; i++)
    {
        if (array1[i] > 0) count1++;
    }
    return count1;
}

Console.WriteLine("Input string of numbers (integers) separated with blank_spaces..");
string[] token0 = Console.ReadLine().Split();
//Console.WriteLine($"Your string length is {token0.Length}");
int[] array0 = CleanArray2(token0);
Console.WriteLine($"Clean array: {String.Join(" ",array0)}");
Console.WriteLine($"You have input {CountPositive1(array0)} positive numbers");