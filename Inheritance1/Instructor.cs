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
    // Instructor class, inherits from Person.cs
    class Instructor : Person
    {
        // private field
        private double salary;

        // no arguments
        public Instructor()
        {

        }

        // constructor and calling the parent constructor class from Person.cs -> Person(name, yob), the specified arguments are included in the base.
        public Instructor(string instructorName, int instructorYob, double instructorSalary) : base(instructorName, instructorYob)
        {
            salary = instructorSalary;
        }
        // override function ToString()
        public override string ToString()
        {
            return base.ToString() + $" and my salary is ${salary}";
        }
    }
}
