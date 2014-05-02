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

            // Ausgabe:
            Console.WriteLine("Der Kreisradius beträgt {0}", kreis.Radius);
            Console.WriteLine("Die Fläche beträgt {0}", kreis.GetArea());
            Console.WriteLine("Der Umfang beträgt {0}", kreis.GetCircumference());
            Console.WriteLine("Der Kreis befindet sich auf X: {0} Y: {1}", kreis.XCoordinate, kreis.YCoordinate);
            Console.ReadKey();
        }
    }
}
