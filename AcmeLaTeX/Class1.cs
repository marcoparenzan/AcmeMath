using CSharpMath.SkiaSharp;
var painter = new MathPainter { LaTeX = @"\frac23" }; // or TextPainter
using var png = painter.DrawAsStream();

Console.ReadLine();