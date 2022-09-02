// Напишите функцию, которая принимает одно число - 
//высоту елочки и рисует ее в консоли звездочками.

void DrawLine1(int N1, int M1)  //каждая линия состоит из N1 пробелов и M1 звездочек
{
    for (int i = 0; i < N1; i++)
    {
        Console.Write(' ');
    }
    for (int j = 0; j < M1; j++)
    {
        Console.Write('*');
    }
}

void DrawTree2(int N2)          //строим елочку, каждая линия kx+b
{
    for (int k = 0; k < N2; k++)
    {
        DrawLine1((N2-k),(2*k+1));
        Console.WriteLine();
    }
}

Console.WriteLine("Indicate number of lines in a Christmas tree..");
string text0 = Console.ReadLine();
bool check0 = int.TryParse(text0, out int N0);
if ((check0 == false) || (N0 < 0)) Console.WriteLine("Your input is incorrect");
else DrawTree2(N0);

