using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4weeks
{
    class Program
    {
        static void SumAvh(int[] obj)
        {
            int sum = 0;
            for(int i = 0; i < obj.Length; i++)
            {
                sum=+obj[i];
            }
            Console.WriteLine(sum);
            Console.WriteLine(sum / obj.Length);

            
        }
        static void Main(string[] args)
        {
            int[] abc = { 10, 20, 30, 40, 50 };
            SumAvh(abc);
        }
    }
  
}
