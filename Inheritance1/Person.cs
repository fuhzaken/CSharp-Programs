using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    @author: xMinatwoah
    @date: September 06, 2021
    @description: CSharp practice using Inheritance -> calling the parent constructor, inheritance from other classes.
 */
namespace Inheritance
{
    class Person
    {
        // Private fields
        private string name;
        private int yearOfBirth;

        // Constructor without arguments
        public Person()
        {

        }
        // Constructor with arguments, this constructor will be called within the Constructor initialization in the classes that inherits from this class - Person.cs
        public Person(string personName, int personYob)
        {
            name = personName;
            yearOfBirth = personYob;
        }
        // ToString method
        public override string ToString()
        {
            return $"Hi, I am {name} and I was born in the year {yearOfBirth}";
        }
    }
}
