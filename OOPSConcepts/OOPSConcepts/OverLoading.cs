using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    //Polymorphism means many form and there are two types of polymorphism
    //1.Run time Polymorphism --> Method OverRiding
    //2.Compile Type PolyMorphism --> Method OverLoading
    public class OverLoading
    {
        //Compile Time => It Contains many functions or methods with different parameters
        public void MethodOne() {
            Console.WriteLine("without parameter"); 
        }
        public void MethodOne(int num)
        {
            Console.WriteLine("With one parameter");
        }
        public void MethodOne(int num,string str)
        {
            Console.WriteLine("With two parameter");
        }
        public void MethodOne(string str, int num)
        {
            Console.WriteLine("With two parameter");
        }
    }
}
