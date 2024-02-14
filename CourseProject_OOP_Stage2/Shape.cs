using CourseProject_OOP_Stage2.ShapesForXmlSerialization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CourseProject_OOP_Stage2
{
    [Serializable]
    public abstract class Shape : IDrawable, ISerializable
    {
        protected Shape(string name, Color color, int posX, int posY)
        {
            this.Name = name; 
            this.Brush = new SolidBrush(color);         
            this.PosX = posX;
            this.PosY = posY;
        }

        // Constructor for serializing/deserializing
        protected Shape(SerializationInfo info, StreamingContext context) : this(
            info.GetString(nameof(Name)),
            (Color)info.GetValue(nameof(Color), typeof(Color)),
            info.GetInt32(nameof(PosX)),
            info.GetInt32(nameof(PosY)))
        { }        

        public string Name { get; }

        public Color Color
        {
            get => Brush.Color;
            set => Brush.Color = value;
        }

        public int PosX { get; set; }

        public int PosY { get; set; }

        protected SolidBrush Brush { get; }

        public bool IsDeleted { get; set; } = false;

        public DateTime TimeAddedInList { get; set; }

        public abstract double CalculateArea();

        public abstract void Draw(Graphics graphics);

        public abstract bool IsPointInside(Point point);

        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {             
            info.AddValue(nameof(Name), Name);
            info.AddValue(nameof(Color), Color);
            info.AddValue(nameof(PosX), PosX);
            info.AddValue(nameof(PosY), PosY);
        }

        public abstract ShapeData ToFileData();

    }
}