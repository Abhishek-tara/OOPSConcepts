using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    //It is a way of hiding sensitive data from users
    //Fields declared should be private
    // Property get is only Read only
    // Property set is write only
    public class Encapsulation
    {
        private string name = "Bruce Wayne";

        // providing getters and setters method
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //Automatic property
        public int RollNo { get; set; }
    }
}
