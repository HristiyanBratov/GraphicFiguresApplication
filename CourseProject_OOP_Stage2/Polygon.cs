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
    public abstract class Polygon : Shape
    {
        private double side;

        protected Polygon(string name, Color color, int posX, int posY, double side) : base(name, color, posX, posY)
        {
            this.Side = side;          
        }

        // Constructor for serializing/deserializing
        protected Polygon(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            this.Side = info.GetDouble(nameof(Side));          
        }

        public double Side
        {
            get { return side; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The side of a polygon cannot be negative or equal to zero!");
                }

                side = value;
            }
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue(nameof(Side), Side);
        }

    }
}