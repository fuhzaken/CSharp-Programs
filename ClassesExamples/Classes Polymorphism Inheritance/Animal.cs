using System;
namespace Classes1
{
    public class Animal
    {
        // Practice: Classes, Encapsulation, Polymorphism, and Inheritance
        // Author: @kentzyzxc/fuhzaken
        
        private string name;
        private string breed;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                value = name;
            }
        }

        public string Breed
        {
            get
            {
                return name;
            }
            set
            {
                value = breed;
            }
        }

        public Animal()
        {

        }

        public Animal(string aName, string aBreed)
        {
            this.name = aName;
            this.breed = aBreed;
        }

        public override string ToString()
        {
            return $"Name: {name} \nBreed: {breed}";
        }
    }
}
