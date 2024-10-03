using System;

class Program{
  public static void Main(string[] args){
    GeometricFigure[] figures = new GeometricFigure[]{
      new Circle(2),
      new Rectangle(2, 3),
      new Square(2),
      new Triangle(2, 3),
      new Cone(2, 3),
      new Cube(2),
      new Cylinder(2, 3),
      new Sphere(2)
    };

    foreach (GeometricFigure f in figures){
      Console.WriteLine($"Forma da Figura: {f.Form}");
      Console.WriteLine($"Perimetro: {f.CalculatePerimeter()}");
      Console.WriteLine($"Area: {f.CalculateArea()}");
      Console.WriteLine($"Volume: {f.CalculateVolume()}");
    }
  }
}