// Пользователь вводит скобочные последовательности. 
//В последовательности могут встретиться скобки вида: {}, (), [].
//Правильная скобочная последовательность - символьная последовательность,
// составленная в алфавите, состоящем из символов, сгруппированных 
//в упорядоченные пары.



(bool, char, string) FindParentheses(string string1)
{
    if (string1 == "") return (true, '\0', "");
    else
    {
        char c1 = string1[0];
        //Console.WriteLine(string1);
        switch (c1)
        {
            case ('('):
                {
                    (bool check2, char c2, string string2) = FindParentheses(string1.Substring(1, string1.Length - 1));
                    //Console.WriteLine($"c1: {c1} , c2: {c2}");
                    if ((c2 != (char)(((int)c1) + 1))) return (false, '\0', "");
                    else return FindParentheses(string2);
                }
            case ('['):
                {
                    (bool check2, char c2, string string2) = FindParentheses(string1.Substring(1, string1.Length - 1));
                    //Console.WriteLine($"c1: {c1} , c2: {c2}");
                    if ((c2 != (char)(((int)c1) + 2))) return (false, '\0', "");
                    else return FindParentheses(string2);
                }
            case ('{'):
                {
                    (bool check2, char c2, string string2) = FindParentheses(string1.Substring(1, string1.Length - 1));
                    //Console.WriteLine($"c1: {c1} , c2: {c2}");
                    if ((c2 != (char)(((int)c1) + 2))) return (false, '\0', "");
                    else return FindParentheses(string2);
                }
            case (')'):
                {
                    return (true, c1, string1.Substring(1, string1.Length - 1));
                }
            case (']'):
                {
                    return (true, c1, string1.Substring(1, string1.Length - 1));

                }
            case ('}'):
                {
                    return (true, c1, string1.Substring(1, string1.Length - 1));
                }
            default:
                return FindParentheses(string1.Substring(1, string1.Length - 1));
        }
    }
}

Console.WriteLine("Input string with different types of brackets for check..");
string string0 = Console.ReadLine()!;
(bool check0, char p0, string S1) = FindParentheses(string0);
if (!check0) Console.WriteLine("Error");
else Console.WriteLine("OK");