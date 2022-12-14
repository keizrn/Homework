// Написать программу для перевода римских чисел в десятичные арабские.

//In the Roman numeral system, the symbols I, V, X, L, C, D, 
//and M stand respectively for 1, 5, 10, 50, 100, 500, and 1,000 
//in the Hindu-Arabic numeral system. A symbol placed after another 
//of equal or greater value adds its value. A symbol placed before 
//one of greater value subtracts its value.

(bool, int) RomantoArabic1(string text1)
{
    char[] tokens1 = text1.ToCharArray();
    int count1 = tokens1.Length;
    int arab1 = 0;
    //    Console.WriteLine(String.Join(" ", tokens1));
    bool check1 = true;
    bool V1 = false;
    bool X1 = false;
    bool XL1 = false;
    bool L1 = false;
    bool C1 = false;
    bool CD1 = false;
    bool D1 = false;
    bool M1 = false;
    bool IV1 = false;
    bool I1 = false;

    int count_I1 = 0;
    int count_X1 = 0;
    int count_C1 = 0;
    int count_M1 = 0;

    for (int i = 1; i < count1 + 1; i++)
    {
        switch (tokens1[count1 - i])
        {
            case ('I') when ((V1 == false) && (X1 == false)):
                {
                    arab1 = arab1 + 1;
                    I1 = true;
                    count_I1++;
                    break;
                }
            case ('I') when (((I1 == true) && (V1 == true)) || ((I1 == true) && (X1 == true)) || (count_I1 == 3) || (IV1 == true) || (L1 == true) || (C1 == true) || (D1 == true) || (M1 == true)):
                {
                    check1 = false;
                    return (check1, 0);
                }
            case ('I'):
                {
                    arab1 = arab1 - 1;
                    IV1 = true;
                    X1 = false;
                    break;
                }
            case ('V') when ((V1 == true) || (X1 == true) || (L1 == true) || (C1 == true) || (D1 == true) || (M1 == true)):
                {
                    check1 = false;
                    return (check1, 0);
                }
            case ('V'):
                {
                    arab1 = arab1 + 5;
                    V1 = true;
                    break;
                }
            case ('X') when ((L1 == false) && (C1 == false)):
                {
                    arab1 = arab1 + 10;
                    X1 = true;
                    count_X1++;
                    break;
                }
            case ('X') when (((X1 == true) && ((L1 == true) || (C1 == true))) || (count_X1 == 3) || (XL1 == true) || (D1 == true) || (M1 == true)):
                {
                    check1 = false;
                    return (check1, 0);
                }
            case ('X'):
                {
                    arab1 = arab1 - 10;
                    XL1 = true;
                    C1 = false;
                    break;
                }
            case ('L') when ((L1 == true) || (C1 == true) || (D1 == true) || (M1 == true)):
                {
                    check1 = false;
                    return (check1, 0);
                }
            case ('L'):
                {
                    arab1 = arab1 + 50;
                    L1 = true;
                    break;
                }
            case ('C') when ((D1 == false) && (M1 == false)):
                {
                    arab1 = arab1 + 100;
                    C1 = true;
                    count_C1++;
                    break;
                }
            case ('C') when (((C1 == true) && ((D1 == true) || (M1 == true))) || (count_C1 == 3) || (CD1 == true)):
                {
                    check1 = false;
                    return (check1, 0);
                }
            case ('C'):
                {
                    arab1 = arab1 - 100;
                    CD1 = true;
                    M1 = false;
                    break;
                }
            case ('D') when ((D1 == true) || (M1 == true)):
                {
                    check1 = false;
                    return (check1, 0);
                }
            case ('D'):
                {
                    arab1 = arab1 + 500;
                    D1 = true;
                    break;
                }
            case ('M') when (count_M1 == 3):
                {
                    check1 = false;
                    return (check1, 0);
                }
            case ('M'):
                {
                    arab1 = arab1 + 1000;
                    M1 = true;
                    count_M1++;
                    break;
                }

            default:
                {
                    check1 = false;
                    return (check1, 0);

                }


        }
        //Console.WriteLine(arab1); 
    }
    return (check1, arab1);
}

Console.WriteLine("Input any Roman number..");
string roman0 = Console.ReadLine();
roman0 = roman0.ToUpper();
(bool check0, int arabic0) = RomantoArabic1(roman0);
if (check0 == false) Console.WriteLine("Your input was NOT correct.");
else Console.WriteLine($"Arabic number is: {arabic0}");