// Пользователь вводит скобочные последовательности. 
//В последовательности могут встретиться скобки вида: {}, (), [].
//Правильная скобочная последовательность - символьная последовательность,
// составленная в алфавите, состоящем из символов, сгруппированных 
//в упорядоченные пары.



(bool, char) FindParentheses(string string1)
{
    bool check1 = true;
    char c1 = string1[0];
    Console.WriteLine(string1);
    switch (c1)
        {
            case ('('):
            {
                
            }



    if ((c1 == '(') || (c1 == '[') || (c1 == '{'))
    {
        for (int i = 1; i < string1.Length + 1; i++)
        {
        (bool check2, char c2) = FindParentheses(string1.Substring(i,string1.Length - i));
        Console.WriteLine($"c1: {c1} , c2: {c2}");
        if ((c2 != (char)(((int)c1) + 1)) && (c2 != (char)(((int)c1) + 2))) return (false, '\0');
        else return (true, c2);
        }
    }
    else if ((c1 == ')') || (c1 == ']') || (c1 == '}'))
    {
        return (true, c1);
    }
    return (true, '\0');
}

Console.WriteLine("Input string");
string string0 = Console.ReadLine();
(bool check0, char p0) = FindParentheses(string0);
if (!check0) Console.WriteLine("Error");
else Console.WriteLine("OK");