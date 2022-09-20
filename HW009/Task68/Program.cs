// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

(bool, double, double) InputData1()
{
    double m1 = 0;
    double n1 = 0;
    Console.WriteLine("Lets's calculate Ackermann function.");
    Console.WriteLine("Input M and N..");
    bool check1 = double.TryParse(Console.ReadLine(), out m1);
    if ((check1) && (m1 >= 0))
    {
        check1 = double.TryParse(Console.ReadLine(), out n1);
        if ((check1) && (n1 >= 0))
        {
        }
        else check1 = false;
    }
    else check1 = false;
    return (check1, m1, n1);
}

double AckermannFunction2(double m2, double n2)
{
    double ackermann2 = 0;
    if (m2 == 0)
    {
        ackermann2 = n2 + 1;
    }
    else if ((m2 > 0) && (n2 == 0))
    {
        ackermann2 = AckermannFunction2(m2-1, 1);
    }
    else if ((m2 > 0) && (n2 > 0))
    {
        double temp2 = AckermannFunction2(m2, n2 - 1);
        ackermann2 = AckermannFunction2(m2 - 1, temp2);
        
    }
    return ackermann2;
}

(bool check0, double m0, double n0) = InputData1();
if (check0)
{
    double result0 = AckermannFunction2(m0, n0);
    Console.WriteLine($"Result of Ackermann function is: {result0}.");
}
else Console.WriteLine("Your input was incorrect.");