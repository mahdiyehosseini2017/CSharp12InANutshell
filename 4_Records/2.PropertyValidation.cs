namespace CSharp12InANutshell.Records;

// record Point
// {
//     // Notice that we assign x to the X property (and not the _x field):
//     public Point(double x, double y) => (X, Y) = (x, y);
//     double _x;
//     public double X
//     {
//         get => _x;
//         init
//         {
//             if (double.IsNaN(value))
//                 throw new ArgumentException("X Cannot be NaN");
//             _x = value;
//         }
//     }
//     public double Y { get; init; }
// }
