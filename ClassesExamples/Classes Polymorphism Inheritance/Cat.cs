using System;
namespace Classes1
{
    public class Cat : Animal
    {
        // Practice: Classes, Polymorphism, and Inheritance
        // Author: @kentzyzxc/fuhzaken

        public Cat() : base()
        {

        }

        public Cat(string name, string breed) : base(name, breed)
        {

        }

        public void Meow()
        {
            Console.WriteLine("Meow! Meow!");
        }
    }
}
