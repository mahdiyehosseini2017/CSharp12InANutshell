namespace CSharp12InANutshell.Records;
public class Program
{
    public static void Main()
    {
        // Point p1 = new Point(2, 3);
        // Point p2 = p1 with { X = double.NaN }; // throws an exception

        /////recomputing DistanceFromOrigin every time the property is accessed
        Point1 p1 = new Point1(2, 3);
        Console.WriteLine(p1.DistanceFromOrigin);
        Console.WriteLine(p1.DistanceFromOrigin);
        Console.WriteLine(p1.DistanceFromOrigin);

        Point2 p2 = new Point2(2, 3);
        Console.WriteLine(p2.DistanceFromOrigin);
        Console.WriteLine(p2.DistanceFromOrigin);
        ///Point2 p6 = p2 with {X = 1};  //error

        Point2_1 p3 = new Point2_1(2, 3);
        Console.WriteLine(p3.DistanceFromOrigin);
        Point2_1 p4 = p3 with {X = 1};
        Console.WriteLine(p4.DistanceFromOrigin);

        // Point p1 = new Point(2, 3);
        // Console.WriteLine(p1.DistanceFromOrigin); // 3.605551275463989
        // Point p2 = p1 with { Y = 4 };
        // Console.WriteLine(p2.DistanceFromOrigin); // 4.47213595499958



    }
}
