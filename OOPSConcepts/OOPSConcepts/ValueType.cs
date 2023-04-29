using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    //Value type is of two types
    //1.Built in type: It will store in the stack memory --> int,long float ,double , byte , char , bool
    //2.User Defined type --> struct , enum
    public class ValueType
    {
        public void ValueTypeMethod()
        {
            //Value type
            int numOne = 12;
            int numTwo = numOne;
            numTwo++;
            Console.WriteLine(numOne);
            Console.WriteLine(numTwo);
        }
    }
}
