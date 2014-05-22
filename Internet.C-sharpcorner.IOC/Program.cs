using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internet.C_sharpcorner.IOC
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person p = new Person(35, "Dev", 6, "Len");
            //Console.WriteLine(p);

            IOCClass obj = new IOCClass();
            obj.FactoryMethod();
            Console.WriteLine(obj);

            Console.Read();
        }
    }
}
