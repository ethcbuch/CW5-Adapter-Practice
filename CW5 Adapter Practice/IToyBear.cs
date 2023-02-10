//Ethan Buchanan
//2-10-23
//ToyBear interface and the classes that implement it

using System;

namespace AdapterPractice
{
    interface IToyBear
    {
        void hug();
    }

    class TeddyBear : IToyBear
    {
        public void hug()
        {
            Console.WriteLine("The teddy bear hugs you.");
        }
    }

    class BearAdapter : IToyBear
    {
        IBear bear;

        public BearAdapter(IBear aBear)
        {
            bear= aBear;


        }
        public void hug()
        {
            Console.WriteLine("The bear hugs you.");
            bear.maul();
        }
    }
}
