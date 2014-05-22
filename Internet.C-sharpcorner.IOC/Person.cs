using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internet.C_sharpcorner.IOC
{
    class Person
    {
        private int age;
        private string name;
        private IBusinessLogic refKids;

        public Person(int personAge, string personName)
        {
            age = personAge;
            name = personName;
        }

        public IBusinessLogic RefKids
        {
            set
            {
                refKids = value;
            }
            get
            {
                return refKids;
            }
        }

        public override string ToString()
        {
            //return base.ToString();

            string s = age.ToString();
            return String.Format("ParentAge{0} ParentName{1}", s, name);
        }
    }
}
