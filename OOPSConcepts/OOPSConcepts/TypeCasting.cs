using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    // Type casting is used to assign a value of one data type to another data type
    // There are two types 1.Implicit Casting 2. Explicit Casting
    //1. Implicit means automatically converting a small type to a large type
    // char -> int -> long -> float -> double
    //2. Explicit means manually converting a small type to a large type
    //double -> int
    public class TypeCasting
    {
        public void Method()
        {
            //Implicit
            int num = 12;
            double numTwo = num;
            Console.WriteLine(numTwo);
            Console.WriteLine(num);

            //Explicit
            double val = 10.5;
            int valTwo = (int)val;
            Console.WriteLine(valTwo);
        }
    }
}
