Console.WriteLine("Введите дробное число в двоичной системе счисления:");
string input = Console.ReadLine();

double result = ConvertBinaryToDecimal(input);

Console.WriteLine("Число в десятичной системе счисления: {0}", result);


static double ConvertBinaryToDecimal(string binaryNumber)
{
    string[] parts = binaryNumber.Split('.');
    string wholePart = parts[0];
    string fractionalPart = parts[1];

    double wholeDecimal = 0;
    double fractionalDecimal = 0;
    
    for (int i = wholePart.Length - 1; i >= 0; i--)
    {
        int digit = int.Parse(wholePart[i].ToString());
        wholeDecimal += digit * Math.Pow(2, wholePart.Length - 1 - i);
    }
    
    for (int i = 0; i < fractionalPart.Length; i++)
    {
        int digit = int.Parse(fractionalPart[i].ToString());
        fractionalDecimal += digit * Math.Pow(2, -(i + 1));
    }

    return wholeDecimal + fractionalDecimal;
}
