using System;
namespace Classes1
{
    public class Dog : Animal
    {
        // Practice: Classes, Polymorphism, and Inheritance
        // Author: @kentzyzxc/fuhzaken

        public Dog() : base()
        {

        }
        public Dog(string name, string breed) : base(name, breed)
        {

        }

        public void Bark()
        {
            Console.WriteLine("Arf! Arf!");
        }
    }
}
