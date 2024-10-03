using System;

class Triangle : GeometricFigure{
  public double Height { get; }
  public double Width { get; }

  public Triangle(double height, double width){
    Form = "Triangle";
    Height = height;
    Width = width;
  }
  public override double CalculatePerimeter(){
    return Width + 2 * Math.Sqrt(Math.Pow((Width/2), 2) + Math.Pow(Height, 2));
  }
  public override double CalculateArea() {
    return (Width * Height)/2;
  }
}