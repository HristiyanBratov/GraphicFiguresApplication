using CourseProject_OOP_Stage2.ShapesForXmlSerialization;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject_OOP_Stage2
{
    [Serializable]
    public class Circle : Shape
    {
        private double radius;

        public Circle(string name, Color color, int posX, int posY, double radius) : base(name, color, posX, posY)
        {
            this.Radius = radius;
        }

        // Constructor for serializing/deserializing
        protected Circle(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            Radius = info.GetDouble(nameof(Radius));
        }

        public double Radius
        {
            get { return radius; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Radius must be with positive value!");
                }

                radius = value;
            }
        }

        public override double CalculateArea()
        {
            return Math.Round(Radius * Radius * Math.PI, 2);
        }

        public override void Draw(Graphics graphics)
        {
            graphics.FillEllipse(Brush, PosX, PosY, (float)Radius, (float)Radius);
        }

        public override bool IsPointInside(Point point)
        {
            int distanceSquared = (point.X - PosX) * (point.X - PosX) + (point.Y - PosY) * (point.Y - PosY);
            return distanceSquared <= Radius * Radius;
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue(nameof(Radius), Radius);
        }

        public override ShapeData ToFileData()
        {
            return new CircleData() { Name = Name, Color = Color, PosX = PosX, PosY = PosY, Radius = Radius };
        }       

    }
}