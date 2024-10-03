using System;

class Circle : GeometricFigure{
  public double Radius { get; }

  public Circle(double radius){
    Form = "Circle";
    Radius = radius;
  }
  public override double CalculatePerimeter(){
    return 2 * Math.PI * Radius;
  }
  public override double CalculateArea() {
    return Math.PI * Math.Pow(Radius, 2);
  }
}