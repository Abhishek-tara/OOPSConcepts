using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    //
    public class ReferenceType
    {
        public void ReferenceMethod(ref int num)
        {
            num = num * num;
            Console.WriteLine(num);

        }
    }
}
