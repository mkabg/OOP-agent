using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Calclate
    {
        // This is a simple calculator class that performs basic arithmetic operations.
        int Num1, Num2;
        
        // Constructor to initialize the two numbers.
        public Calclate(int num1, int num2)
        {
            this.Num1 = num1;
            this.Num2 = num2;
        }


        public int add(int num1, int num2)
        {
            return num1 + num2;
        }
        public int sub(int num1, int num2)
        {
            return num1 - num2;
        }
        public int mul(int num1, int num2)
        {
            return num1 * num2;
        }
        public int div(int num1, int num2)
        {
            return num1 / num2;
        }

        public void print()
        {
            Console.WriteLine("Addition: " + add(Num1, Num2));
            Console.WriteLine("Subtraction: " + sub(Num1, Num2));
            Console.WriteLine("Multiplication: " + mul(Num1, Num2));
            Console.WriteLine("Division: " + div(Num1, Num2));
        }
    }
}
