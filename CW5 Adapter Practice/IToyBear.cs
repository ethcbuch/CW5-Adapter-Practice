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
