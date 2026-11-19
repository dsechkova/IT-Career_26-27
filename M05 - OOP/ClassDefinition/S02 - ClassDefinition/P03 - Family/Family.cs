using System;
using System.Collections.Generic;
using System.Text;

namespace P03___Family
{
    internal class Family
    {
        private List<Person> familyMembers;

        public List<Person> FamilyMembers
        {
            get { return familyMembers; }
            set { familyMembers = value; }
        }

        public Family()
        {
            FamilyMembers = new List<Person>();
        }



    }
}
