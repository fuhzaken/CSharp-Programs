using System;
namespace Classes1
{
    public class Bird : Animal
    {
        // Practice: Classes, Encapsulation, Polymorphism, and Inheritance
        // Author: @kentzyzxc/fuhzaken

        public Bird() : base()
        {

        }

        public Bird(string name, string breed) : base(name, breed)
        {
            
        }
        public void Tweet()
        {
            Console.WriteLine("Tweet! Tweet!");
        }
    }
}
