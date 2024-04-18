using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_Class_Hierarrchy_And_Inheritance.infoclass
{
    internal class Rectangle : Shap
    {
        private double height { get; set; }
        private double width { get; set; }
        public Rectangle(double h, double w)
        {
            height = h;
            width = w;
        }
        public override void CalculateArea()
        {
            Console.WriteLine($"Area of rectangle is equal: {height * width} ");
        }
    }
}
