namespace CSharp12InANutshell.Records;

////one problem:
////1. recomputing DistanceFromOrigin every time the property is accessed
record Point1(double X, double Y)
{
    //returns the distance from the origin (0, 0):
    public double DistanceFromOrigin => Math.Sqrt(X * X + Y * Y);
}


////two problem:
////1. it doesn’t allow for nondestructive mutation (changing X and Y to init-only properties would break the code because DistanceFromOrigin
////would become stale after the init accessors execute).

////2. It’s also suboptimal in that the calculation is always performed, regardless of whether the DistanceFromOrigin property is ever read.
record Point2
{
    public Point2(double x, double y) => (X, Y, DistanceFromOrigin) = (x, y, Math.Sqrt(x * x + y * y));

    public double X { get; }
    public double Y { get; }
    public double DistanceFromOrigin { get; }
}

record Point2_1
{
    public Point2_1(double x, double y) => (X, Y, DistanceFromOrigin) = (x, y, Math.Sqrt(x * x + y * y));

    public double X { get; init; }
    public double Y { get; init; }
    public double DistanceFromOrigin { get; }
}



//The optimal solution is to cache its value in a field and populate it lazily (on first use):
record Point3
{
    public Point3(double x, double y) => (X, Y) = (x, y);
    double _x, _y;
    public double X
    {
        get => _x; init { _x = value; _distance = null; }
    }
    public double Y
    {
        get => _y; init { _y = value; _distance = null; }
    }
    double? _distance;
    public double DistanceFromOrigin => _distance ??= Math.Sqrt(X * X +
    Y * Y);
}


