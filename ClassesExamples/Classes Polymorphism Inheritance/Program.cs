using System;

namespace Classes1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Practice: Classes, Polymorphism, and Inheritance
            // Author: @kentzyzxc/fuhzaken

            // Objects creation
            Cat cat = new Cat("Juju", "Sphinx");
            Dog dog = new Dog("Nelson", "Husky");
            Bird bird = new Bird("Dale", "Parrot");

            Console.WriteLine(cat);
            cat.Meow();
            Console.WriteLine("-------------------------------");
            Console.WriteLine(dog);
            dog.Bark();
            Console.WriteLine("-------------------------------");
            Console.WriteLine(bird);
            bird.Tweet();
        }
    }
}
