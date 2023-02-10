//Ethan Buchanan
//2-10-23
//Bear interface and the classes that implement it
using System;

namespace AdapterPractice
{
    interface IBear
    {
        void maul();
        void hibernate();
    }

    class Grizzly : IBear
    {
        public void maul()
        {
            Console.WriteLine("The bear mauls you.");
        }
        public void hibernate()
        {
            Console.WriteLine("The bear goes to sleep for the winter");
        }
    }
}
