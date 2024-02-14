using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject_OOP_Stage2.ShapesForXmlSerialization
{
    public class TrapezoidData : PolygonData
    {
        public double UpperSide { get; set; }

        public double Height { get; set; }

        public override Shape ToShapeData()
        {
            return new Trapezoid(Name, Color, PosX, PosY, Side, UpperSide, Height);
        }
    }
}