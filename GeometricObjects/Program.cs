using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle kreis = new Circle();
            kreis.Radius = 12;
            kreis.XCoordinate = 100;
            kreis.YCoordinate = 100;

            kreis.Move(20, 60);

            Circle kreis2 = new Circle();
            kreis2.Radius = 100;
           
            if (kreis.Bigger(kreis2))              
               Console.WriteLine("Kreis 1 ist grösser als Kreis 2");
            else
               Console.WriteLine("Kreis 2 ist grösser als Kreis 1");

            // parameter der methode DoSomething referenziert auf die Variable via "ref" und ist nicht lokal.
            int value = 3;
            DoSomethingWithRef(ref value);
            // out macht dasselbe, mit dem unterschied, dass der übergebene parameter nicht initialisiert werden muss. Per Out muss die variable auf jeden fall geändert werden.
            DoSomethingWithOut(out value);

            // Methode mit params
            Console.WriteLine("Add Routine mit params: {0}", Add(5, 5, 4, 4, 3, 2, 3, 3, 4, 5, 5, 5, 5, 5, 5, 5, 3, 5, 5));

            // Methode mit optionalem Parameter
            OptionalParam("Pascal", 5);

            // Ausgabe:
            Console.WriteLine("Der Kreisradius beträgt {0}", kreis.Radius);
            Console.WriteLine("Die Fläche beträgt {0}", kreis.GetArea());
            Console.WriteLine("Der Umfang beträgt {0}", kreis.GetCircumference());
            Console.WriteLine("Der Kreis befindet sich auf X: {0} Y: {1}", kreis.XCoordinate, kreis.YCoordinate);
            Console.WriteLine("{0}", value);
            Console.ReadKey();
        }
        static void DoSomethingWithRef(ref int param)
        {
            param = 500;
        }
        static void DoSomethingWithOut(out int param)
        {
            param = 700;
        }

        static long Add(int value1, int value2, params int[] list) // ein params-Parameter muss an letzter stelle stehen und darf nur einmal vorkommen
        {
            long sum = value1 + value2;
            foreach(int z in list)
            {
                sum += z;
            }
            return sum;
        }
        static void OptionalParam(string name, int value = -1)
        {
            if(value != -1)
                Console.WriteLine("Ein Wert wurde übergeben");
            else
                Console.WriteLine("Parameter wurde nicht mitgegeben");
        }
    }
}
