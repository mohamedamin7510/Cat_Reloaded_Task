using System;
using Task3_Class_Hierarrchy_And_Inheritance.infoclass;
namespace Task3_Class_Hierarrchy_And_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rect = new Rectangle(10, 2);
            rect.CalculateArea();
            var circ = new Circle(10);
            circ.CalculateArea();
        }
    }
}
