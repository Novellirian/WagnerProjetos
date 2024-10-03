using System;

class Square : GeometricFigure{
  public double Size { get; }

  public Square(double size){
    Form = "Square";
    Size = size;
  }
  public override double CalculatePerimeter(){
    return 4 * Size;
  }
  public override double CalculateArea() {
    return Math.Pow(Size, 2);
  }
}