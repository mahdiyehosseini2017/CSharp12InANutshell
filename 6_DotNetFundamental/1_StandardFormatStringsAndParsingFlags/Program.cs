using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {
        UseStandardNumericFormatStrings();
    }

    public static void UseStandardNumericFormatStrings()
    {
        Console.WriteLine("//////////////////////////////////////");
        Console.WriteLine("Currency format specifier (C)");
        Console.WriteLine(" The default is 2");
        double value = 12345.6789;
        Console.WriteLine(value.ToString("C", CultureInfo.CurrentCulture));  //2

        Console.WriteLine(value.ToString("C3", CultureInfo.CurrentCulture));  //3

        Console.WriteLine(value.ToString("C3",
                          CultureInfo.CreateSpecificCulture("fa-IR")));

        Console.WriteLine(1.2.ToString("C"));
        Console.WriteLine(1.2.ToString("C4"));


        Console.WriteLine("//////////////////////////////////////");
        Console.WriteLine("Decimal format specifier (D)");
        int value1;

        value1 = 12345;
        Console.WriteLine(value1.ToString("D"));
        // Displays 12345
        Console.WriteLine(value1.ToString("D8"));
        // Displays 00012345

        value1 = -12345;
        Console.WriteLine(value1.ToString("D"));
        // Displays -12345
        Console.WriteLine(value1.ToString("D8"));
        // Displays -00012345

        Console.WriteLine(123.ToString("D5"));
        Console.WriteLine(123.ToString("D1"));

        //Console.WriteLine(123.6.ToString("D8"));  //This format is supported only for integral types.

        Console.WriteLine("//////////////////////////////////////");
        Console.WriteLine("Exponential format specifier (E)");
        Console.WriteLine("Exactly one digit always precedes the decimal point.");
        Console.WriteLine("The precision specifier indicates the desired number of digits after the decimal point. If the precision specifier is omitted, a default of six digits after the decimal point is used.");
        Console.WriteLine("The exponent always consists of a plus or minus sign and a minimum of three digits");

        double value2 = 12345.6789;
        Console.WriteLine(value2.ToString("E", CultureInfo.InvariantCulture));
        // Displays 1.234568E+004  12345.680000

        Console.WriteLine(value2.ToString("E10", CultureInfo.InvariantCulture));
        // Displays 1.2345678900E+004

        Console.WriteLine(value2.ToString("e4", CultureInfo.InvariantCulture));
        // Displays 1.2346e+004

        Console.WriteLine(value2.ToString("E"));

        Console.WriteLine(12345111111.6789.ToString("E1"));

        Console.WriteLine(12.6789.ToString("E"));


        Console.WriteLine("//////////////////////////////////////");
        Console.WriteLine("Fixed-point format specifier (F)");
        Console.WriteLine("The default is 2");

        int integerNumber;
        integerNumber = 17843;
        Console.WriteLine(integerNumber.ToString("F",
                          CultureInfo.InvariantCulture));
        // Displays 17843.00

        integerNumber = -29541;
        Console.WriteLine(integerNumber.ToString("F3",
                          CultureInfo.InvariantCulture));
        // Displays -29541.000

        double doubleNumber;
        doubleNumber = 18934.1879;
        Console.WriteLine(doubleNumber.ToString("F", CultureInfo.InvariantCulture));
        // Displays 18934.19

        Console.WriteLine(doubleNumber.ToString("F0", CultureInfo.InvariantCulture));
        // Displays 18934

        doubleNumber = -1898300.1987;
        Console.WriteLine(doubleNumber.ToString("F1", CultureInfo.InvariantCulture));
        // Displays -1898300.2

        Console.WriteLine(doubleNumber.ToString("F3",
                          CultureInfo.CreateSpecificCulture("es-ES"))); //Spanish
                                                                        // Displays -1898300,199

        Console.WriteLine("//////////////////////////////////////");
        Console.WriteLine("Numeric format specifier (N)");
        Console.WriteLine("Fixed point with group separator");
        double dblValue = -12445.6789;
        Console.WriteLine(dblValue.ToString("N", CultureInfo.InvariantCulture));
        // Displays -12,445.68
        Console.WriteLine(dblValue.ToString("N1",
                          CultureInfo.CreateSpecificCulture("sv-SE")));
        // Displays -12 445,7

        int intValue = 123456789;
        Console.WriteLine(intValue.ToString("N1", CultureInfo.InvariantCulture));
        // Displays 123,456,789.0

        Console.WriteLine("//////////////////////////////////////");
        Console.WriteLine("Percent format specifier (P)");
        Console.WriteLine("The default is 2");
        double number = .2468013;
        Console.WriteLine(number.ToString("P", CultureInfo.InvariantCulture));
        // Displays 24.68 %
        Console.WriteLine(number.ToString("P",
                          CultureInfo.CreateSpecificCulture("hr-HR")));
        // Displays 24,68%
        Console.WriteLine(number.ToString("P1", CultureInfo.InvariantCulture));
        // Displays 24.7 %



    }
}
