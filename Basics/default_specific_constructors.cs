using System;

namespace Scratch2name
{
    class Scratch2
    {
        class Coords // This allows Coords objects to be created with default or specific initial values
        {
            public int x, y;

            public Coords() // parameterless constructor
            {
                x = 0;
                y = 0;
            }
            
            public Coords(int x, int y)  // constructor with two arguments
            {
                this.x = x;
                this.y = y;
            }
        }


        static void Main(string[] args)
        {
            Coords coordinates = new Coords();
            Coords coordinates2 = new Coords(31,13);

            Console.WriteLine("{0} {1}", coordinates.x, coordinates.y);
            Console.WriteLine("{0} {1}", coordinates2.x, coordinates2.y);
        }
    }
}
