using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = x; //Az �rt�k m�sol�dik ez�rt ha x-et m�dos�tom akkor y �rt�ke nem v�ltozik majd
            //Person p = new Person();
            //p.Name = "J�zsi";
            Write(x);
            Console.WriteLine(x);
            Console.ReadKey();
        }

        static void Write(int a)
        {
            a = 4;
            Console.WriteLine(a);
        }
    }
}
