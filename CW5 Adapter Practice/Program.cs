using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPractice
{


    internal class Program
    {
        static void Main(string[] args)
        {
            Grizzly smokey = new Grizzly();
            TeddyBear teddy = new TeddyBear();
            BearAdapter adaptBear = new BearAdapter(smokey);

            //Grizzly Test
            smokey.hibernate();
            smokey.maul();
            //TeddyBear Test;
            teddy.hug();
            //Adapter Test
            adaptBear.hug();
            Console.ReadKey();
        }
    }
}
