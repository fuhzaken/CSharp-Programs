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
    // Student class, inherits from Person.cs
    class Student : Person
    {
        // private fields
        private string major;

        public Student()
        {

        }
        // constructor and calling the parent constructor class from Person.cs -> Person(name, yob), the specified arguments are included in the base.
        public Student(string studentName, int studentYob, string studentMajor): base(studentName, studentYob)
        {
            major = studentMajor;
        }
        // override function ToString()
        public override string ToString()
        {
            return base.ToString() + $" and my major is {major}";
        }
    }
}
