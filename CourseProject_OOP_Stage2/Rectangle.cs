using CourseProject_OOP_Stage2.ShapesForXmlSerialization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CourseProject_OOP_Stage2
{
    [Serializable]
    public class Rectangle : Polygon
    {
        private double secondSide;

        public Rectangle(string name, Color color, int posX, int posY, double side, double secondSide) : base(name, color, posX, posY, side)
        {
            this.SecondSide = secondSide;
        }

        // Constructor for serializing/deserializing
        protected Rectangle(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            SecondSide = info.GetDouble(nameof(SecondSide));
        }

        public double SecondSide
        {
            get { return secondSide; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The side of a rectangle cannot be negative or equal to zero!");
                }

                secondSide = value;
            }
        }

        public override double CalculateArea()
        {
            return Side * SecondSide;
        }

        public override void Draw(Graphics graphics)
        {
            graphics.FillRectangle(Brush, PosX, PosY, (float)Side, (float)SecondSide);
        }

        public override bool IsPointInside(Point point)
        {
            return (point.X >= PosX && point.X <= PosX + Side) && (point.Y >= PosY && point.Y <= PosY + SecondSide);
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue(nameof(SecondSide), SecondSide);
        }        

        public override ShapeData ToFileData()
        {
            return new RectangleData() { Name = Name, Color = Color, PosX = PosX, PosY = PosY, Side = Side, SecondSide = SecondSide };
        }     

    }
}