// Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

bool check0;
double k01 = -1, b01 = 1, k02 = 1, b02 = 2;

bool DataInput1()
{
Console.WriteLine($"Input k1..");
check0 = double.TryParse(Console.ReadLine(), out k01);
if (check0 == false) Console.WriteLine("Your input was incorrect.");
else
{
    Console.WriteLine($"Input b1..");
    check0 = double.TryParse(Console.ReadLine(), out b01);
    if (check0 == false) Console.WriteLine("Your input was incorrect.");
    else
    {
        Console.WriteLine($"Input k2..");
        check0 = double.TryParse(Console.ReadLine(), out k02);
        if (check0 == false) Console.WriteLine("Your input was incorrect.");
        else
        {
            Console.WriteLine($"Input b2..");
            check0 = double.TryParse(Console.ReadLine(), out b02);
            if (check0 == false) Console.WriteLine("Your input was incorrect.");
            else check0 = true;
        }
    }
}
return check0;
}

double[] FindIntersection2(double m01, double n01, double m02, double n02)
{
    double[] array2 = new double[2];
//    Console.WriteLine(n01 - n02);
    array2[0] = (n01 - n02)/(m02 - m01);
    array2[1] = m01 * array2[0] + n01;
    for (int h = 0; h < array2.Length; h++)
    {
        array2[h] = Math.Round(array2[h],2);
    } 
    return array2;
}


string CheckInput3(double num_m01, double num_n01)
{
    string text3 = "y = ";
    if (num_m01 == 1) text3 = text3 + "x ";
    else if (num_m01 == (-1)) text3 = text3 + "-x ";
    else if ((num_m01 < 0) || (num_m01 > 0)) text3 = text3 + $"{num_m01}x ";
    if (num_n01 > 0) 
    {
        if (num_m01 != 0) text3 = text3 + "+";
        text3 = text3 + $"{num_n01}";
    }
    else if (num_n01 < 0) text3 = text3 + num_n01;
    else if ((num_n01 == 0) && (num_m01 == 0)) text3 = text3 + "0";
    return text3;
}

bool CheckIntersection4(double num_i01, double num_j01, double num_i02, double num_j02)
{
    bool check4 = false;
    if (num_i01 == num_i02)
    {
        if (num_j01 == num_j02) Console.WriteLine("These two lines are identic.");
        else Console.WriteLine("These two lines are parallel (no intersetion).");
    }
    else check4 = true;
    return check4;
}


DataInput1();
if (check0)
{
    Console.WriteLine("Please check your functions:");
    Console.WriteLine(CheckInput3(k01, b01));
    Console.WriteLine(CheckInput3(k02, b02));
    Console.Write("y/n?..");
    char char0 = Console.ReadLine().ToUpper()[0];
    if (char0 == 'Y') 
    {
        double[] array0 = new double[2];
        if (CheckIntersection4(k01, b01, k02, b02))
        {
            array0 = FindIntersection2(k01, b01, k02, b02);
            Console.WriteLine($"Intersection point is ({String.Join("; ",array0)})");
        }
    }   
}