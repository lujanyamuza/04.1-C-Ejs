// See https://aka.ms/new-console-template for more information
Console.WriteLine("Escribe un número: ");
int num = Convert.ToInt32(Console.ReadLine());

static string GetDigitToEng(int num)
{
    int digit = num % 10;
    switch(digit)
    {
        case 0:
            return "zero";
        case 1:
            return "one";
        case 2:
            return "two";
        case 3:
            return "three";
        case 4:
            return "four";
        case 5:
            return "five";
        case 6:
            return "six";
        case 7:
            return "seven";
        case 8:
            return "eight";
        case 9:
            return "nine";
        default: 
            return "error";

    }

}

Console.WriteLine(GetDigitToEng(num));