/*using System;

namespace Abstraction{
  abstract class Animal{
    protected string name;
    public abstract void makeSound();
    public abstract string Name{get;set;}

  }

  class Dog : Animal{
    public override void makeSound() => Console.WriteLine("Bark Bark !!");
    public override string Name{
      get{ return name; }
      set{ name = value; }
    }

  }

  class Program{
    static void Main(string[] args){
      Dog dog = new Dog();
      dog.Name = "Max";
      Console.WriteLine("Name : " + dog.Name);
      dog.makeSound();
      Console.ReadLine();
  }
 }
}
*/
