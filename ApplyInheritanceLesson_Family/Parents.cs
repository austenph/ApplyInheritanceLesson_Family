using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplyInheritanceLesson_Family
{
    class Parents : Family
    {
        //fields
        private bool married;
        private bool sameSexParents;
        private string nameParent;
        private int ageParent;
        //properties
        //constructors
        public Parents()
        {

        }
        public Parents(bool married, bool sameSexParents, string nameParent, int ageParent, string location): base(4, "Hall", true, false)
        {
            this.married = married;
            this.sameSexParents = sameSexParents;
            this.nameParent = nameParent;
            this.ageParent = ageParent;
            Location = location;
        }
        //methods
        public void ParentInfo()
        {
            Console.WriteLine("I am a parent of the" + FamilyName + " family.");
        }
    }
}
