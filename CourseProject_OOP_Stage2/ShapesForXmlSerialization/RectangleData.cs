using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CourseProject_OOP_Stage2.ShapesForXmlSerialization
{
    public class RectangleData : PolygonData
    {
        public double SecondSide { get; set; }
        public override Shape ToShapeData()
        {
            return new Rectangle(Name, Color, PosX, PosY, Side, SecondSide);
        }
    }
}