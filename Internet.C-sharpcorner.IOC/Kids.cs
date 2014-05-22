using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internet.C_sharpcorner.IOC
{
    class Kids : IBusinessLogic
    {
        private int age;
        private string name;

        public Kids(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

        public override string ToString()
        {
            //return base.ToString();

            string m = this.age.ToString();
            return String.Format("KIDs Age {0} KIDs Name {1}", m, name);
        }
    }
}
