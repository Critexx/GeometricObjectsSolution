using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjects
{
    public class Circle
    {
        // -------- Klasseneigenschaften ----------
        private static int _CountCircles;   // mit "static" erzeugt man eine Klasseneigenschaft (oder Klassen Methode). Sie wird mit dem Klassennamen aufgerufen.
        public static int CountCircles
        {
            get { return _CountCircles; }
        }
   
        // -------- Eigenschaften ----------
        public const int TestInt = 1337;    // aufgerufe wird die Konstante über den Klassennamen: Circle.TestInt;
        public readonly int ZweiterTestInt = 1338;  // readonly Variabeln können im gegensatz zu Konstanten im Konstruktor gesetzt werden.

        public double YCoordinate { get; set; }   // das private Feld wird implizit bereitgestellt. Es macht genau das, was in XCoordinate definiert ist. Man kann es noch priviate machen
        public double XCoordinate { get; set; }

        private int _Radius;
        public int Radius
        {
            get
            {
                return _Radius;
            }
            set
            {
                if (value >= 0)
                    _Radius = value;               
                else
                    Console.WriteLine("Der eingegeben Wert darf nicht negativ sein.");
            }
        }

        // -------- Statischer Konstruktor ------- 
        static Circle() {}             // Erfolgt nur einmal und bevor ein Klassenmember aufgerufen wird oder eine Instanz der Klasse erzeugt wird. Wird verwendet um Daten bereitzustellen

        // -------- Konstruktoren ------- ( mit Konstruktorverkettung auf Überladung )
        public Circle() : this(0, 0, 0) { } // Leitet auf die Überladung mit den meisten Parameter
        public Circle(int aRadius) : this(aRadius, 0, 0) { } // Überladung mit 1 Parameter. Leitet auf die Überladung mit den meisten Parameter

        public Circle(int aRadius, double x, double y) // Überladung mit 3 Parameter
        {
            Radius = aRadius;
            XCoordinate = x;
            YCoordinate = y;
            Circle._CountCircles++;
        }

        // -------- Destruktor -------
        ~Circle()
        { 
            // Mit der Zuweisung von null an die Objektreferenz wird der Destruktor aufgerufen.
        }
        // -------- Klassenmethoden ----------
        // Fläche
        public static double GetArea(int radius)    // mit "static" erzeugt man eine Klassen Methode (oder Klasseneigentschaft). Sie wird mit dem Klassennamen aufgerufen.
        {
            return Math.Pow(radius, 2) * Math.PI;
        }
        // Umfang
        public static double GetCircumference(int radius)
        {
            return 2 * radius * Math.PI;
        }

        public static int Bigger(Circle kreis1, Circle kreis2)
        {
            if (kreis1 == null && kreis2 == null) return 0;
            if (kreis1 == null) return -1;
            if (kreis2 == null) return 1;
            if (kreis1.Radius > kreis2.Radius) return 1;
            if (kreis1.Radius < kreis2.Radius) return -1;
            return 0;
        }

        // -------- Methoden ----------

        // Fläche
        public double GetArea()
        {
            return Math.Pow(Radius, 2) * Math.PI; ;        
        }
        // Umfang
        public double GetCircumference()
        {
            double circumference = 2 * Radius * Math.PI;
            return circumference;
        }

        public void Move(double dx, double dy)
        {
            XCoordinate += dx;
            YCoordinate += dy;
        }

        // overload Method
        public void Move(double dx, double dy, int dRadius)
        {
            Move(dx, dy);
            Radius += dRadius;
        }

        // gibt zurück ob kreis grösser ist als der parametisierte kreis.
        public bool Bigger(Circle kreis)
        {
            return (Radius > kreis.Radius);
        }
    }
}
