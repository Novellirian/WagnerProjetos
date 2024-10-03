using System;

class Car{
  public double Position { get ; set ;}

  //Deslocamento em MRU
  public void Move(double v, double t){
    Position = Position + v * t;
  }

  //Deslocamento em MRUV
  public void Move(double v, double t, double a){
    Position = Position + v * t + (a * t * t)/2;
  }
}

class Program{
  static void Main(string[] args){
    Car c = new Car();
    c.Position = 10;

    Console.WriteLine("A posicao atual é: " + c.Position);
    c.Move(5, 5);
    Console.WriteLine("A posicao atual é: " + c.Position);
    c.Move(5, 5, 2);
    Console.WriteLine("A posicao atual é: " + c.Position);
  }
}