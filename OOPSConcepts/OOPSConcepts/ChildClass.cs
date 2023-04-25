using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    public class ChildClass : ParentClass
    {
        public ChildClass()
        {
            Console.WriteLine("This is a child Class");
        }

        public void childMethod()
        {
            Console.WriteLine("This is a childs play");
        }
    }

    public class ParentClass
    {
        public string Nationality;
        public void methodOne()
        {
            Console.WriteLine("This is a Parent Class");
        }
    }
}
