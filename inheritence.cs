/*using System;

namespace Inheritence{
  // Base Class
  class Animal{
  // property
  public string animalName;
  // method
  public void display() => Console.WriteLine("I am animal");
  // overridden by the derived class
  public virtual void eat() => Console.WriteLine("i eat food");
  }
  // Dog inherits Animal
  // Derived Class
  class Dog : Animal {
    public void getDogName() => Console.WriteLine("My namw is " + animalName );
    //  overriding the eat method from the base clas
    public override void eat() {
      // calling the base method
      base.eat();
      Console.WriteLine("I eat Dog food");}

  }

  class Program {
     static void Main(string[] args){
        Dog labrador = new Dog();
        labrador.animalName = "Maxy";
        labrador.display();
        labrador.getDogName();
        labrador.eat();
        Console.WriteLine();

        Console.ReadLine();
      }
  }
}
*/
