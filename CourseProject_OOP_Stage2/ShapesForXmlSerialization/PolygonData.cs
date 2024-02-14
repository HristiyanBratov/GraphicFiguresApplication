using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CourseProject_OOP_Stage2.ShapesForXmlSerialization
{
    public abstract class PolygonData : ShapeData
    {
        public double Side { get; set; }
    }
}