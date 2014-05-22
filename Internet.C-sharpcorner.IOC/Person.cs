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
        IBusinessLogic refKids;

        public Person(int personAge, string personName, IBusinessLogic obj)
        {
            refKids = obj;
            age = personAge;
            name = personName;
        }

        public override string ToString()
        {
            //return base.ToString();

            string s = age.ToString();
            Console.WriteLine(refKids);
            return String.Format("ParentAge{0} ParentName{1}", s, name);
        }
    }
}
