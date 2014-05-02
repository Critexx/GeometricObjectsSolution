using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjects
{
    public class Circle
    {
        // -------- Eigenschaftsmethoden ----------

        public double YCoordinate {get; set;}
        public double XCoordinate {get; set;}

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

        // -------- Methoden ----------

        // Fläche
        public double GetArea()
        {
            double area = Math.Pow(Radius, 2);
            return area;
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
        public Boolean Bigger(Circle kreis)
        {
            return (Radius > kreis.Radius);
        }
    }
}
