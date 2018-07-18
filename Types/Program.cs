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
            //Person p = new Person();
            //p.Name = "Józsi";
            //WritePerson(p);
            //Console.WriteLine(p.Name);

            //int x = 2;
            //int y = 3;
            //Swap(ref x, ref y);

            //Person p = new Person();
            //p.Name = "Józsi";
            //Person p2 = new Person();
            //p2.Name = "Béla";
            //Person p3 = p; //Mindig józsira mutat mert nem változtatjuk
            //Swap(ref p, ref p2);
            //Console.WriteLine(p.Name);

            //Person newPerson;
            //bool created = CreatePerson(out newPerson);

            //int number;

            //if (int.TryParse("0", out number))
            //{
            //    Console.WriteLine("Sikerült számmá alakítani: " + number);
            //}
            //else
            //{
            //    Console.WriteLine("Nem sikerült számmá alakítani: " + number);
            //}

            //Person p;
            //Distance d = new Distance();
            //Increase(d);
            //Console.WriteLine(d.cm);

            //Freezer f = new Freezer();
            //Person p = new Person();
            //p.Name = "Gazsi";
            //f.person = p;
            //f.x = 3;
            //ChangeName(f);
            //Console.WriteLine(f.x);
            //Console.WriteLine(f.person.Name);
            //Console.WriteLine(p.Name);


            //var p = new Person();
            //p.Name = "Józsi";
            //Property initializer
            var p = new Person()
            {
                Name = "Józsi"
            };

            WritePerson(new Person { Name = "Józsi" });

            var list = new List<Person>() { p };
            var x = 4;
            //var line = Console.ReadLine();
            string line = Console.ReadLine();


            Console.ReadKey();
        }
        
        static void ChangeName(Freezer freezer)
        {
            freezer.person.Name = "Józsi";
            freezer.x = 10;
        }

        static void Increase(Distance dist)
        {
            dist.cm = 100;
        }

        static bool CreatePerson(out Person p)
        {
            p = new Person(); //p-nek értéket kell adni return elõtt
            p.Name = "Géza";
            return true;
        }

        static void Swap(ref Person a, ref Person b)
        {
            Person c = a;
            a = b;
            b = c;
        }

        static void Swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
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
