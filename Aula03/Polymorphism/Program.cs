using System;
using PolymorphismSample;

class Program{
  static void Main(string[] args){

    Animal test = new Animal();
    
    Animal[] animals = new Animal[]{ 
      new Dog(), 
      new Cat(), 
      new Wolf(),
      new Student()
    };

    foreach (Animal animal in animals){
      Console.WriteLine(animal.MakeSound());
    }
  }
}