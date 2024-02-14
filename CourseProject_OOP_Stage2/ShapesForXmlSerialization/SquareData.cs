using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CourseProject_OOP_Stage2.ShapesForXmlSerialization
{ 
    public class SquareData : PolygonData
    {
        public override Shape ToShapeData()
        {
            return new Square(Name, Color, PosX, PosY, Side);
        }
    }
}