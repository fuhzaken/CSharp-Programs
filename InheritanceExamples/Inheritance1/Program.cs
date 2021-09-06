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
    class Program
    {
        static void Main(string[] args)
        {
            /* Testing class */

            // Person object
            Person person = new Person("Nelson Tea", 1983);
            Console.WriteLine(person);

            // Instructor object
            Instructor instructor = new Instructor("Marsu Charlzu", 1990, 1600);
            Console.WriteLine(instructor);

            // Student object
            Student student = new Student("Minatwoah Namikaze", 1990,"SET");
            Console.WriteLine(student);
            Console.ReadKey();
        }
    }
}
