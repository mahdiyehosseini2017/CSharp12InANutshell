namespace CSharp12InANutshell.Records;

//one problem:
//1. recomputing DistanceFromOrigin every time the property is accessed
// record Point(double X, double Y)
// {
//     //returns the distance from the origin (0, 0):
//     public double DistanceFromOrigin => Math.Sqrt(X * X + Y * Y);
// }


//two problem:
//1. it doesn’t allow for nondestructive mutation (changing X and Y to init-only properties would break the code because DistanceFromOrigin
//would become stale after the init accessors execute).

//2. It’s also suboptimal in that the calculation is always performed, regardless of whether the DistanceFromOrigin property is ever read.
// record Point
// {
//     public Point(double x, double y) => (X, Y, DistanceFromOrigin) = (x, y, Math.Sqrt(x * x + y * y));

//     public double X { get;}
//     public double Y { get;}
//     public double DistanceFromOrigin { get; }
// }

//The optimal solution is to cache its value in a field and populate it lazily (on first use):

record Point(double X, double Y)
{
    double? _distanceFromOrigin;
    // public double DistanceFromOrigin
    // {
    //     get
    //     {
    //         if (_distanceFromOrigin == null)
    //             _distanceFromOrigin = Math.Sqrt(X * X + Y * Y);

    //         return _distanceFromOrigin.Value;
    //     }
    // }
    public double DistanceFromOrigin => _distanceFromOrigin ??= Math.Sqrt(X * X + Y * Y);
}
