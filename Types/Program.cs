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
            int y = x; //Az érték másolódik ezért ha x-et módosítom akkor y értéke nem változik majd
            //Person p = new Person();
            //p.Name = "Józsi";
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
