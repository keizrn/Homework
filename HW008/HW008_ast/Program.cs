// Написать функцию Sqrt(x) - квадратного корня, которая принимает на вход 
//целочисленное значение x и возвращает целую часть квадратного корня от 
//введенного числа.

(bool, int) InputData1()
{
    int m1 = 0;
    Console.WriteLine("This Program will find closest integer to sqrt from your number.");
    Console.WriteLine("Please note that this algorithm works better with larger numbers.");
    Console.WriteLine("Input any non-negative number..");
    bool check1 = int.TryParse(Console.ReadLine(), out m1);
    if ((check1) && (m1 > 0))
    { }
    else check1 = false;
    return (check1, m1);
}

double GoldenSection4(double num4)    // ищем через Золотое сечение
{
    double newPoint4 = 0;
    double randMax4 = num4;
    double randMin4 = 1;
    while ((randMax4 - randMin4) > 1)
    {
        newPoint4 = Convert.ToInt64(randMax4 - (0.6180339887) * (randMax4 - randMin4));
        if ((newPoint4 * newPoint4) > num4) randMax4 = newPoint4;
        else randMin4 = newPoint4;
        //Console.WriteLine($"{randMin4}, {randMax4}");         // для отладки
    }
    return randMin4;
}

(bool check0, int number0) = InputData1();
if (check0)
{
    Console.WriteLine(GoldenSection4(number0));
}
else Console.WriteLine("Your input was not correct.");