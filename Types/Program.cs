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
            //Érték típus példa
            //int x = 3;
            //int y = x; //Az érték másolódik ezért ha x-et módosítom akkor y értéke nem változik majd
            //Write(x);
            //Console.WriteLine(x);

            //Referencia típus példa
            Person p = new Person();
            p.Name = "Józsi";
            WritePerson(p);
            Console.WriteLine(p.Name);
            Console.ReadKey();
        }

        static void WritePerson(Person x)
        {
            x.Name = "Béla";
            Console.WriteLine(x.Name);
        }

        static void Write(int a)
        {
            a = 4;
            Console.WriteLine(a);
        }
    }
}
