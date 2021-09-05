using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    @description: Program that does the following
    @author: xMinatwoah
 */
namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            //   Write an app which contains the following two overloaded functions:
            //a) private static int Maximum(int, int) which returns the largest of two numbers
            //b) private static int Maximum(int, int, int) which returns the largest of three numbers
            //c) private static int Square(int) which returns square of an integer value
            //d) private static double Square(double) which returns square of a double value

            Console.WriteLine($"A: {Maximum(15, 6)}");
            Console.WriteLine($"B: {Maximum(8, 6, 19)}");
            Console.WriteLine($"C: {Square(5)}");
            Console.WriteLine($"D: {Square(5.4)}");
            Console.ReadKey();
        }
        
        private static int Maximum(int firstNum, int secondNum)
        {
            int max = 0;
            if(firstNum > secondNum)
            {
                // set the first number as the max number
                max = firstNum;
            }
            else
            {
                // set the second number as the max number
                max = secondNum;
            }
            
            return max;
        }
        private static int Maximum(int firstNum, int secondNum, int thirdNum)
        {
            int max = 0;
            if (firstNum > secondNum && firstNum > thirdNum)
            {
                // set the first number as the max number
                max = firstNum;
            }
            else if(secondNum > firstNum && secondNum > thirdNum)
            {
                // set the second number as the max number
                max = secondNum;
            }
            else if(thirdNum > firstNum && thirdNum > secondNum)
            {
                // set the third number as the max number
                max = thirdNum;            
            }
            return max;
        }
        private static int Square(int number)
        {
            int area;
            area = (int)Math.Pow(number, 2);
            return area;
        }
        private static double Square(double number)
        {
            double area = Math.Pow(number, 2);
        
            return area;
        }
    }
}
