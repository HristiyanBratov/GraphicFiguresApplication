using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CourseProject_OOP_Stage2.ShapesForXmlSerialization
{
    [XmlInclude(typeof(RectangleData))]  
    [XmlInclude(typeof(SquareData))]  
    [XmlInclude(typeof(TriangleData))]  
    [XmlInclude(typeof(TrapezoidData))]  
    [XmlInclude(typeof(CircleData))]
    public abstract class ShapeData
    {
        public string Name { get; set; }

        // Color is not saveable
        public Color Color { get; set; }

        public int PosX { get; set; }

        public int PosY { get; set; }

        public abstract Shape ToShapeData();
    }
}