using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorOverloadExample
{
    class Addition
    {
        int x, y;
        double f;
        float s;

        // 1st constructor
        public Addition(int x, double f)
        {
            this.x = x;
            this.f = f;
        }

        // 2nd constructor
        public Addition(int y, float s)
        {
            this.y = y;
            this.s = s;
        }

        public void DisplayFirstConstructor()
        {
            Console.WriteLine("First Constructor (int + double): " + (x + f));
        }

        public void DisplaySecondConstructor()
        {
            Console.WriteLine("First Constructor (int + float): " + (y + s));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Addition add1 = new Addition(2, 2.0);
            add1.DisplayFirstConstructor();
            Addition add2 = new Addition(5, 5.0f);
            add2.DisplaySecondConstructor();

            Console.ReadLine();
        }
    }
}
