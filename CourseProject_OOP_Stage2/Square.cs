using CourseProject_OOP_Stage2.ShapesForXmlSerialization;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CourseProject_OOP_Stage2
{
    [Serializable]
    public class Square : Polygon
    {
        public Square(string name, Color color, int posX, int posY, double side) : base(name, color, posX, posY, side)
        {

        }

        // Constructor for serializing/deserializing
        protected Square(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }

        public override double CalculateArea()
        {
            return Side * Side;
        }

        public override void Draw(Graphics graphics)
        {
            graphics.FillRectangle(Brush, PosX, PosY, (float)Side, (float)Side);
        }

        public override bool IsPointInside(Point point)
        {
            return (point.X >= PosX && point.X <= PosX + Side) && (point.Y >= PosY && point.Y <= PosY + Side);
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
        }

        public override ShapeData ToFileData()
        {
            return new SquareData() { Name = Name, Color = Color, PosX = PosX, PosY = PosY, Side = Side };
        }      

    }
}