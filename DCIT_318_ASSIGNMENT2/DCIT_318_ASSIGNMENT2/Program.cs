using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic sound");
    }
}
 public class Dog: Animal
    {
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }

}

public class Cat: Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}



public abstract class Shape
{
    public abstract double GetArea();

}

public class Circle: Shape
{
    public double Radius { get; set; }

    public Circle (double radius)
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}

public class Rectangle: Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle (double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double GetArea()
    {
       return Width * Height;
    }
}



namespace DCIT_318_ASSIGNMENT2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nInheritance and Method Overriding");
            Animal generic = new Animal();
            Animal dog = new Dog();
            Animal cat = new Cat();

            generic.MakeSound();
            dog.MakeSound();
            cat.MakeSound();


            Console.WriteLine("\nAbstract Classes and Methods ");
            Shape circle = new Circle(5);
            Shape rectangle = new Rectangle(4, 6);

            Console.WriteLine($"Circle Area: {circle.GetArea():F2}");
            Console.WriteLine($"Rectangle Area: {rectangle.GetArea():F2}");

        }
    }
}
