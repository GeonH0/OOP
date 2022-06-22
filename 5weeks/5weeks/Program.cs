using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5weeks
{
    internal class Program
    {
        class Shpae
        {
            protected int width;
            protected int height;

            public void setWidth(int w)
            {
                width = w;
            }
            public void setHeight(int h)
            {
                height = h;
            }
        }
        class Rectangle : Shpae
        {
            public int getArea()
            {
                return (width * height);
            }
        }
        class Inheritance
        {
            static void Main(string[] args)
            {
                Rectangle rect = new Rectangle();

                rect.setWidth(5);
                rect.setHeight(10);

                Console.WriteLine("AREA : {0}", rect.getArea());
            }
        }
    }
}
