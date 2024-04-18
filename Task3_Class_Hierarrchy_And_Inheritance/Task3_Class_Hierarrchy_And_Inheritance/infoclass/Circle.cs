using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_Class_Hierarrchy_And_Inheritance.infoclass
{
    internal class Circle : Shap
    {
        private double R { get; set; }
        public Circle(double r)
        {
            R = r;
        }
        public override void CalculateArea()
        {
            Console.WriteLine($"Area of circle is equal: {Math.PI * Math.Pow(R, 2)}");
        }
    }
}
