void ConvertToDigit(ref double digit)
{
    digit = 0;
    int digit1 = 0;
    int digit2 = 0;
    int digit3 = 0;

    string colorCode = args[0];

    string color1 = colorCode.Substring(0, 2);
    switch (color1)
    {
        case "Bla": digit1 = 0; break;
        case "Bro": digit1 = 1; break;
        case "Red": digit1 = 2; break;
        case "Ora": digit1 = 3; break;
        case "Yel": digit1 = 4; break;
        case "Gre": digit1 = 5; break;
        case "Blu": digit1 = 6; break;
        case "Vio": digit1 = 7; break;
        case "Gra": digit1 = 8; break;
        case "Whi": digit1 = 9; break;
    }
    string color2 = colorCode.Substring(4, 6);
    switch (color2)
    {
        case "Bla": digit2 += 0; break;
        case "Bro": digit2 += 1; break;
        case "Red": digit2 += 2; break;
        case "Ora": digit2 += 3; break;
        case "Yel": digit2 += 4; break;
        case "Gre": digit2 += 5; break;
        case "Blu": digit2 += 6; break;
        case "Vio": digit2 += 7; break;
        case "Gra": digit2 += 8; break;
        case "Whi": digit2 += 9; break;

    }
    if (colorCode.Length == 14)
    {
        digit = digit1 * 10 + digit2;
    }
    else if (colorCode.Length == 18)
    {
        string color3 = colorCode.Substring(8, 10);
        switch (color3)
        {
            case "Bla": digit3 += 0; break;
            case "Bro": digit3 += 1; break;
            case "Red": digit3 += 2; break;
            case "Ora": digit3 += 3; break;
            case "Yel": digit3 += 4; break;
            case "Gre": digit3 += 5; break;
            case "Blu": digit3 += 6; break;
            case "Vio": digit3 += 7; break;
            case "Gra": digit3 += 8; break;
            case "Whi": digit3 += 9; break;

        }
        digit = digit1 * 100 + digit2 * 10 + digit3;
    }

}
void GetMultiplierFromColor(ref double digit)
{
    double multiplier = 1;
    string colorCode = args[0];

    if (colorCode.Length == 14)
    {
        string colorMultiplier = colorCode.Substring(8, 10);
        switch (colorMultiplier)
        {
            case "Bla": multiplier = 1; colorMultiplier = "black(x1)"; break;
            case "Bro": multiplier = 10; colorMultiplier = "brown(x10)"; break;
            case "Red": multiplier = 100; colorMultiplier = "red(x10²)"; break;
            case "Ora": multiplier = 1000; colorMultiplier = "orange(x10³)"; break;
            case "Yel": multiplier = 10000; colorMultiplier = "yellow(x10^4)"; break;
            case "Gre": multiplier = 100000; colorMultiplier = "green(x10^5)"; break;
            case "Blu": multiplier = 1000000; colorMultiplier = "blue(x10^6)"; break;
            case "Vio": multiplier = 10000000; colorMultiplier = "violet(x10^7)"; break;
            case "Gra": multiplier = 100000000; colorMultiplier = "gray(x10^8)"; break;
            case "Whi": multiplier = 1000000000; colorMultiplier = "white(x10^9)"; break;
            case "Gol": multiplier = 0.1; colorMultiplier = "Gold(x0.1)"; break;
            case "Sil": multiplier = 0.01; colorMultiplier = "Silver(x0.01)"; break;
        }
    }
    else if (colorCode.Length == 14)
    {
        string colorMultiplier = colorCode.Substring(12, 14);
        switch (colorMultiplier)
        {
            case "Bla": multiplier = 1; colorMultiplier = "black(x1)"; break;
            case "Bro": multiplier = 10; colorMultiplier = "brown(x10)"; break;
            case "Red": multiplier = 100; colorMultiplier = "red(x10²)"; break;
            case "Ora": multiplier = 1000; colorMultiplier = "orange(x10³)"; break;
            case "Yel": multiplier = 10000; colorMultiplier = "yellow(x10^4)"; break;
            case "Gre": multiplier = 100000; colorMultiplier = "green(x10^5)"; break;
            case "Blu": multiplier = 1000000; colorMultiplier = "blue(x10^6)"; break;
            case "Vio": multiplier = 10000000; colorMultiplier = "violet(x10^7)"; break;
            case "Gra": multiplier = 100000000; colorMultiplier = "gray(x10^8)"; break;
            case "Whi": multiplier = 1000000000; colorMultiplier = "white(x10^9)"; break;
            case "Gol": multiplier = 0.1; colorMultiplier = "Gold(x0.1)"; break;
            case "Sil": multiplier = 0.01; colorMultiplier = "Silver(x0.01)"; break;
        }
    }
    digit = digit * multiplier;

}
void GetTolaranceFromColor(ref double tolerance)
{
    tolerance = 0;
    string colorCode = args[0];
    if (colorCode.Length == 14)
    {
        string colorTolerance = colorCode.Substring(12, 14);
        switch (colorTolerance)
        {

            case "Bro": tolerance = 1; break;
            case "Red": tolerance = 2; break;
            case "Gre": tolerance = 0.5; break;
            case "Blu": tolerance = 0.25; break;
            case "Vio": tolerance = 0.1; break;
            case "Gra": tolerance = 0.05; break;
            case "Gol": tolerance = 5; break;
            case "Yel": tolerance = 1; break;

        }
    }
    else if (colorCode.Length == 18)
    {
        string colorTolerance = colorCode.Substring(16, 18);
        switch (colorTolerance)
        {

            case "Bro": tolerance = 1; break;
            case "Red": tolerance = 2; break;
            case "Gre": tolerance = 0.5; break;
            case "Blu": tolerance = 0.25; break;
            case "Vio": tolerance = 0.1; break;
            case "Gra": tolerance = 0.05; break;
            case "Gol": tolerance = 5; break;
            case "Yel": tolerance = 1; break;

        }
    }

}
void Decode4ColorBands(ref double digit,  ref double tolerance)
{
    System.Console.WriteLine($"Resistance: {digit}Ω");
    System.Console.WriteLine($"tolerance: ±{tolerance}% ");

}

double digit = 0;
double tolerance=0;

ConvertToDigit(ref digit);
GetMultiplierFromColor(ref digit);
GetTolaranceFromColor(ref tolerance);
Decode4ColorBands(ref digit, ref tolerance);