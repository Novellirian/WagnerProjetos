using System;

abstract class GeometricFigure{
  public string Form {get;set;}

  public abstract double CalculateArea();
  
  public virtual double CalculatePerimeter(){
    return 0;
  }
  public virtual double CalculateVolume(){
    return 0;
  }
}