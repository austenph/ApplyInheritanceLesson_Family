using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplyInheritanceLesson_Family
{
    class Family
    {
        //fields
        private int numberofMembers;
        private string familyName;
        private bool children;
        private bool grandchildren;
        protected string location;

        //properties
        public int NumberOfMembers
        {
            get { return this.numberofMembers; }
            set { this.numberofMembers = value; }
        }
        public string FamilyName
        {
            get { return this.familyName; }
            set { this.familyName = value; }
        }
        public string Location
        {
            get { return this.location; }
            set { this.location = value; }
        }
        //constructors
        public Family()
        {

        }
        public Family(int numberofMembers)
        {
            this.numberofMembers = numberofMembers;
        }
        public Family(int numberofMembers, string familyName)
        {
            this.numberofMembers = numberofMembers;
            this.familyName = familyName;
        }
        public Family(int numberofMembers, string familyName, bool children)
        {
            this.numberofMembers = numberofMembers;
            this.familyName = familyName;
            this.children = children;
        }
        public Family(int numberofMembers, string familyName, bool children, bool grandchildren)
        {
            this.numberofMembers = numberofMembers;
            this.familyName = familyName;
            this.children = children;
            this.grandchildren = grandchildren;
        }

    }
}
