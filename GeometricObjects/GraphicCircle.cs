using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjects
{
    public sealed class GraphicCircle : Circle      // sealed = versiegelt, die Klasse kann nicht weiter abgeleitet werden
    {
        // -------- Konstruktoren ------- ( mit Konstruktorverkettung auf Überladung )
        public GraphicCircle() : base(0, 0, 0) { } // Leitet auf den overload mit den meisten Parameter in der Basisklasse
        public GraphicCircle(int aRadius) : base(aRadius, 0, 0) { } // Überladung mit 1 Parameter. Leitet auf den Konstruktor mit den meisten Parameter in der Basisklasse

        public GraphicCircle(int aRadius, double x, double y) : base(aRadius, x, y) { } 

        public void Draw()
        {
            Console.WriteLine("Der Kreis wird gezeichnet");
        }
    }
}
