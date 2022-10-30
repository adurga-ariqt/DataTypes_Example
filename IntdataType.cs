using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataTypes
{
    internal class IntdataType
    {
        public static void  MyMethod()
        {
            int x, y, z;
            Console.WriteLine("enter x value:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter y value:");
            y = Convert.ToInt32(Console.ReadLine());
            z = x + y;
            Console.WriteLine(z);
           //Console.ReadLine();

        }
        public static void Main()
        {
            MyMethod();
            Console.ReadLine(); 
        }

    }
}
