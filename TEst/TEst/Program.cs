using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Parent
    {

        public int num = 99;

        public Parent()
        {
            Console.WriteLine(num);
        }
    }
    class Child : Parent
    {

        public void Display()
        {
            Console.WriteLine(num + 1);
        }
    }
    delegate int DelegateFunc(int a);
    public class Program1
    {
        static int Add(int a)
        {
            return a + a;
        }
        class Progrma
        {
            static void Main(string[] args)
            {
                Child cd = new Child();
                cd.Display();
                DelegateFunc dl = Add;
                Console.WriteLine(dl(10));
            }
        }
    }

    public delegate void EventHandler(object sender, EventArgs e);  
    public partial class form2 : form2
    {

    }
    
}
