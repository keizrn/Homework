// Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

int CountPositive2()
{
    bool check1 = true;
    int count1 = 0;
    string text1 = "";

    while (check1)
    {
        int temp1 = 0;
        text1 = Console.ReadLine().ToUpper();
        char ch1 = text1[0];
        if (ch1 == 'Q') check1 = false;
        else
        {
            if (int.TryParse(text1, out temp1)) 
                {
                    if (temp1 > 0) count1++;
                }
        }
    }
    return count1;
}

Console.WriteLine("Input numbers, when done input 'Q'..");
int count0 = CountPositive2();
Console.WriteLine($"You have input {count0} positive numbers");