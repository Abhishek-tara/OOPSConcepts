using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    public class ConstructorDemo
    {
        public int age;
        public string name;
        //Non-Paramter
        public ConstructorDemo()
        {
            Console.WriteLine("This is a dafault Constructor");
        }
        //Parameterized Constructor
        public ConstructorDemo(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void Display()
        {
            Console.WriteLine($"Hi {name}, You are {age} years old");
        }
    }
}
