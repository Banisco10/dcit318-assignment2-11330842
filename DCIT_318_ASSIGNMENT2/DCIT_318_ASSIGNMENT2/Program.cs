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

namespace DCIT_318_ASSIGNMENT2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inheritance and Method Overriding");
            Animal generic = new Animal();
            Animal dog = new Dog();
            Animal cat = new Cat();

            generic.MakeSound();
            dog.MakeSound();
            cat.MakeSound();
        }
    }
}
