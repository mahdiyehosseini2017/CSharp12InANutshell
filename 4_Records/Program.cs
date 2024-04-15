namespace CSharp12InANutshell.Records;
public class Program
{
    public static void Main()
    {
        // Point p1 = new Point(2, 3);
        // Point p2 = p1 with { X = double.NaN }; // throws an exception

        //recomputing DistanceFromOrigin every time the property is accessed
        // Point p1 = new Point(2, 3);
        // Console.WriteLine(p1.DistanceFromOrigin);
        // Console.WriteLine(p1.DistanceFromOrigin);
        // Console.WriteLine(p1.DistanceFromOrigin);

        // Point p1 = new Point(2, 3);
        // Console.WriteLine(p1.DistanceFromOrigin);
        // Point p2 = p1 with {X = double.NaN};

        // Point p1 = new Point(2, 3);
        // Console.WriteLine(p1.DistanceFromOrigin);
        // Point p2 = p1 with {X = 1};
        // Console.WriteLine(p2.DistanceFromOrigin);

    }
}
