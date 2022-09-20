// Задайте значения M и N. Напишите программу, которая найдёт сумму 
//натуральных элементов в промежутке от M до N.

(bool, int, int) InputData1()
{
    int m1 = 0;
    int n1 = 0;
    Console.WriteLine("This program will calculate sum of natural numbers from M to N.");
    Console.WriteLine("Input M and N..");
    bool check1 = int.TryParse(Console.ReadLine(), out m1);
    if ((check1) && (m1 > 0))
    {
        check1 = int.TryParse(Console.ReadLine(), out n1);
        if ((check1) && (n1 > 0))
        {
        }
        else check1 = false;
    }
    else check1 = false;
    return (check1, m1, n1);
}

int SumNumbers2(int numM2, int numN2)
{
    int sum2 = 0;
    while (numM2 < numN2)
    {
        sum2 += numM2;
        numM2++;
    }
    sum2 += numN2;
    return sum2;
}

(bool check0, int m0, int n0) = InputData1();
if (check0)
{
    if (n0 < m0)
    {
        int temp0 = n0;
        n0 = m0;
        m0 = temp0;
    }

    Console.WriteLine($"Sum of natural numbers from {m0} to {n0} is {SumNumbers2(m0,n0)}.");
    DrawTree2(7);

}
else Console.WriteLine("Your input was not correct. Please note that natural numbers are whole numbers greater than 0.");


void DrawLine1(int N1, int M1)  //каждая линия состоит из N1 пробелов и M1 звездочек
{
    for (int i = 0; i < N1; i++)
    {
        Console.Write("  ");
    }
    for (int j = 0; j < M1; j++)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("* ");
    }
}

void DrawTree2(int N2)          //строим елочку, каждая линия kx+b
{
    Console.WriteLine();
    for (int i = 0; i < 2; i++) DrawLine1(3,(N2-4));
    Console.WriteLine();
    DrawLine1(2,(N2-2));
    DrawLine1(1,(N2-2));
    Console.WriteLine();
    for (int l = 0; l < 3; l++)
    {
        DrawLine1(1,(2*N2-1));
        Console.WriteLine();
    }
    
    for (int k = 2; k < N2+1; k++)
    {
        DrawLine1(k,(2*(N2-k)+1));
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.ResetColor();
    Console.BackgroundColor = ConsoleColor.Blue;
    Console.WriteLine("Спасибо вам, Семён, за прекрасные практические занятия!!");
    Console.ResetColor();
    Console.BackgroundColor = ConsoleColor.Green;
    Console.WriteLine("P.S. Я хотела нарисовать мозг, но не получилось :D");
    Console.ResetColor();
    Console.WriteLine();
}