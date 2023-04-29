using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    //Abstraction is a way hiding unecessary details and showing only relavent information
    //we can achieve it with abstract class and abstract method using abstract keyword
    //we can't create object of abstract class
    // abstract and non-abstract method both are present in abstract class
    public abstract class AbstractionDemo
    {
        //Abstract method
        public abstract void methodAbstract();

        //Normal method
        public void methodNormal()
        {
            Console.WriteLine("Noraml method");
        }
    }
}
