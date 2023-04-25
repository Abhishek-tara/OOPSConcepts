using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    // Interface is a class that has only abstract method.
    // We can't create object from interface class.
    // Private members are not allowed.
    //By default interface members are abstract and public
    public interface InterfaceDemo
    {
        void methodOne(); //Method doesn't have implementation
    }
}
