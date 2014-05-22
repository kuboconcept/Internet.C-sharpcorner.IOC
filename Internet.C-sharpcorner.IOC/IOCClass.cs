using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internet.C_sharpcorner.IOC
{
    class IOCClass
    {
        IBusinessLogic objKid = null;
        Person p;

        public void FactoryMethod()
        {
            objKid = new Kids(12, "Ren");
            p = new Person(42, "David");
            p.RefKids = objKid;
        }

        public override string ToString()
        {
            //return base.ToString();

            Console.WriteLine(p);
            Console.WriteLine(objKid);
            return "Displaying using Setter Injection";
        }
    }
}
