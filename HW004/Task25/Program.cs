// Напишите цикл, который принимает на вход два числа (A и B) и 
//возводит число A в натуральную степень B.
double PowerFunction0(int number0, int power0)
{
    double result0 = 1;
    for (int i=1; i < power0 + 1; i++)
    {
        result0 = result0 * number0;
    }
    return result0;
}

Console.WriteLine("Input number..");
string string1 = Console.ReadLine();
bool check1 = int.TryParse(string1, out int number1);

Console.WriteLine("Input power..");
string string2 = Console.ReadLine();
bool check2 = int.TryParse(string2, out int power1);

if ((check1 == false) || (check2 == false)) Console.WriteLine("Your numbers are incorrect");  //check if the input is integer numbers
else
if (power1 < 0) Console.WriteLine("This program does not work with negative power");            //check if the power is negative
else
if ((power1 == 0) && (number1 == 0)) Console.WriteLine("0 taken to the power of 0 is undefined");  //check if it is 0 to the power of 0
else{
    Console.WriteLine($"Number {number1} taken to the power of {power1} equals {PowerFunction0(number1, power1)}");
}