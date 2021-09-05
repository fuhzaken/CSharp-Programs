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
    class Dog
    {
        // private  fields of the Dog class
        private string dogOwner; // the name of the owner
        private string dogName; // the name of the dog
        private string dogBreed; // the breed of the dog

        // constructor with no parameters
        public Dog()
        {
            // nothing to set
            // we will set the values in our main class/Program.cs
        }

        // constructor to set the dog's name and breed - 2 parameteres
        public Dog(string dog, string breed)
        {
            dogName = dog;
            dogBreed = breed;
        }
        // Reurns the dog's name
        public string SetDogName
        {
            get
            {
                return dogName;
            }
            set
            {
                dogName = value;
            }
        }

        // Returns the owner
        public string SetOwner
        {
            get
            {
                return dogOwner;
            }
            set
            {
                dogOwner = value;
            }
        }
        // Returns the dog breed
        public string SetBreed
        {
            get
            {
                return dogBreed;
            }
            set
            {
                dogBreed = value;
            }
        }
        // returns the string as a sentence
        public override string ToString()
        {
            return $"My name is: {dogName} and I am a {dogBreed} type of dog, and {dogOwner} owns me.";
        }
        // returns the dog's bark
        public static string DogBark()
        {
            return "Arf arf!";
        }
    }
}
