using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    @author: xMinatwoah
    @date: September 05, 2021
    @description: Classes -> private fields, properties,
    constructor, methods, ToString example.
 */
namespace CSharpUsingClass
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Object creation:
                Dog name: Bella
                Constructor used: Dog(dogName, dogBreed) - Constructor with two parameters/arguments"
            */
            Dog bella = new Dog("Bella", "Corgi");
            bella.SetOwner = "xMinatwoah";
            Console.WriteLine(bella);
            Console.WriteLine(Dog.DogBark());
            
            /*  Object creation:
                Dog name: Browny
                Constructor used: Dog() - Constructor with no parameters/arguments
            */
            Dog dog = new Dog();
            dog.SetDogName = "Browny";
            dog.SetBreed = "Husky";
            dog.SetOwner = "Nelson";
            Console.WriteLine(dog);
            Console.WriteLine(Dog.DogBark());
            Console.ReadKey();
        }
    }
}
