// Gives a line of cubes from 1 up to N
Console.WriteLine("This program will show you a line of cubes from 1 to N.");
Console.WriteLine("Please input number..");
string temp = Console.ReadLine();
if (temp == "")           //реализована проверка на пустую строку
{
    Console.WriteLine("Your input is empty. Please try again.");
}
else
{
    int num = int.Parse(temp);
    if (num < 1)
    {
        Console.WriteLine("Your number is too small.");
    }
    else
    {
        Console.Write("1");                     //Это сделано, чтобы убрать лишнюю запятую в конце
        for (int count=2; count<=num; count++)   
        {
            Console.Write($", {count*count}");
        }
    }
}