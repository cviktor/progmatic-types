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
            //�rt�k t�pus p�lda
            //int x = 3;
            //int y = x; //Az �rt�k m�sol�dik ez�rt ha x-et m�dos�tom akkor y �rt�ke nem v�ltozik majd
            //Write(x);
            //Console.WriteLine(x);

            //Referencia t�pus p�lda
            Person p = new Person();
            p.Name = "J�zsi";
            WritePerson(p);
            Console.WriteLine(p.Name);
            Console.ReadKey();
        }

        static void WritePerson(Person x)
        {
            x.Name = "B�la";
            Console.WriteLine(x.Name);
        }

        static void Write(int a)
        {
            a = 4;
            Console.WriteLine(a);
        }
    }
}
