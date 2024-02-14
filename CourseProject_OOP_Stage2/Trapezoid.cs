using CourseProject_OOP_Stage2.ShapesForXmlSerialization;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject_OOP_Stage2
{
    [Serializable]
    public class Trapezoid : Polygon
    {
        private double upperSide;
        private double height;

        public Trapezoid(string name, Color color, int posX, int posY, double side, double upperSide, double height) : base(name, color, posX, posY, side)
        {
            this.UpperSide = upperSide;
            this.Height = height;
        }

        // Constructor for serializing/deserializing
        protected Trapezoid(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            UpperSide = info.GetDouble(nameof(UpperSide));
            Height = info.GetDouble(nameof(Height));
        }

        public double UpperSide
        {
            get { return upperSide; }
            private set
            {
                if (value <= 0 || upperSide == Side)
                {
                    throw new ArgumentException("Side of a trapezoid cannot be negative or small side is equal to bottom side!");
                }

                upperSide = value;
            }
        }
        public double Height
        {
            get { return height; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height of a trapezoid cannot be negative!");
                }

                height = value;
            }
        }

        public override double CalculateArea()
        {
            return ((Side + UpperSide) * Height) / 2;
        }

        public override void Draw(Graphics graphics) // Thinking for a way to draw a trapezoid...
        {
            
        }

        public override bool IsPointInside(Point point)
        {
            throw new NotImplementedException();
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue(nameof(UpperSide), UpperSide);
            info.AddValue(nameof(Height), Height);
        }

        public override ShapeData ToFileData()
        {
            return new TrapezoidData() { Name = Name, Color = Color, PosX = PosX, PosY = PosY, Side = Side, UpperSide = UpperSide, Height = Height };
        }   

    }
}