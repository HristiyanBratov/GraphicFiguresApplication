using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CourseProject_OOP_Stage2.ShapesForXmlSerialization
{
    public class CircleData : ShapeData
    {
        public double Radius { get; set; }

        public override Shape ToShapeData()
        {
            return new Circle(Name, Color, PosX, PosY, Radius);
        }
    }
}