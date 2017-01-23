using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplyInheritanceLesson_Family
{
    class Children : Family
    {
        //fields
        private bool married;
        private string childName;
        private int childAge;
 
        //properties
        //constructors
        public Children ()
        {

        }
        public Children (bool married, string childName, int childAge, string location): base(4, "Hall", false, false)
        {
            this.married = married;
            this.childName = childName;
            this.childAge = childAge;
            Location = location;
        }
        //methods
        public void ChildrenIntro()
        {
            Console.WriteLine("I am a child of the" + FamilyName + " family.");
        }
    }
}
