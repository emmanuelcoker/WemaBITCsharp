using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WemaBITCsharp.Models
{
    public class Triangle
    {
        public double sideA;
        public double sideB;
        public double sideC;
        public double perimeter;
        public double area;
        public double SideA { get { return this.sideA; } set { this.sideA = value; } }
        public double SideB { get { return this.sideB; } set { this.sideB = value; } }
        public double SideC { get { return this.sideC; } set { this.sideC = value; } }

        public double Perimeter { get { return this.CalculatePerimeter(); } }
        
        public double Area { get { return this.CalculateArea(); } }
        public double CalculateArea()
        {
            return Math.Round(Math.Sqrt(Perimeter * (Perimeter - SideA) * (Perimeter - SideB) * (Perimeter - SideC)), 3);
        }

        public double CalculatePerimeter()
        {
            return (SideA + SideB + SideC) / 2;
        }
    }
}
