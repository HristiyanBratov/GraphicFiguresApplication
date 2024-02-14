using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject_OOP_Stage2.ShapesForXmlSerialization
{
    public class TriangleData : PolygonData
    {
        public override Shape ToShapeData()
        {
            return new Triangle(Name, Color, PosX, PosY, Side);
        }
    }
}