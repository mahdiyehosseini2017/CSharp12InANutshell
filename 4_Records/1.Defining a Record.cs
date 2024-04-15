namespace CSharp12InANutshell.Records;

/// <summary>
/// Defining a Record
/// </summary>
//record Point {}
//record class Point{}
//record struct Point {}  //C# 10

//note: record with init-only properties, and a constructor:
// record Point
// {
//     //note: Our constructor employs a shortcut that we described in the preceding section.
//     public Point(double x, double y) => (X, Y) = (x, y);


//     // public Point(double x, double y)
//     // {
//     //     X = x;
//     //     Y = y;
//     // }

//     public double X { get; init; }
//     public double Y { get; init; }
// }


// note: put optional parameters out of the constructor, and expose them purely as init-only properties:
// record Foo
// {
//     public Foo(int required1, int required2)
//     {
//         (Required1, Required2) = (required1, required2);
//     }

//     public int Required1 { get; init; }
//     public int Required2 { get; init; }
//     public int Optional1 { get; init; }
//     public int Optional2 { get; init; }
// }
//----------------------------------------------------------------------------------------
/// <summary>
/// parameter lists
/// </summary>
//public record Point(double X, double Y) { }   
// public class Point
// {
//     public Point(double X, double Y)
//     {
//         this.X = X;
//         this.Y = Y;
//     }

//     public double X { get; init; }
//     public double Y { get; init; }
// }


//public record Point3D(double X, double Y, double Z) : Point(X, Y){}  
// public class Point3D : Point
// {
//     public Point3D(double X, double Y, double Z) : base(X, Y)
//     {
//         this.Z = Z;
//     }

//     public double Z { get; init; }
// }

//public record struct Point(double X, double Y) { }

//public readonly record struct Point(double X, double Y) { }

//------------------------------------------------------------------------------------
/// <summary>
/// Nondestructive Mutation
/// </summary>
//record Point(double X, double Y) { }

record Test(int A, int B, int C, int D, int E, int F, int G, int H) { }