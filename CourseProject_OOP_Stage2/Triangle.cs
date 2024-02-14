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
    public class Triangle : Polygon
    {    
        public Triangle(string name, Color color, int posX, int posY, double side) : base(name, color, posX, posY, side)
        {
            
        }

        // Constructor for serializing/deserializing
        protected Triangle(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }

        private PointF[] GetTriangleVertices()
        {
            PointF[] points = new PointF[3];
            points[0].X = PosX;
            points[0].Y = PosY;

            float angle = (float)(Math.PI / 2);

            points[1].X = (float)(PosX + Side * Math.Cos(angle + Math.PI / 6));
            points[1].Y = (float)(PosY + Side * Math.Sin(angle + Math.PI / 6));

            points[2].X = (float)(PosX + Side * Math.Cos(angle - Math.PI / 6));
            points[2].Y = (float)(PosY + Side * Math.Sin(angle - Math.PI / 6));

            return points;
        }

        public override double CalculateArea()
        {
            return Math.Round((Math.Sqrt(3) / 4) * Side * Side, 2);
        }
        
        public override void Draw(Graphics graphics)
        {
            PointF[] points = GetTriangleVertices();

            graphics.FillPolygon(Brush, points);
        }

        public override bool IsPointInside(Point point)
        {
            PointF[] points = GetTriangleVertices();

            float triangleArea = Math.Abs((points[1].X - points[0].X) * (points[2].Y - points[0].Y) - (points[2].X - points[0].X) * (points[1].Y - points[0].Y));

            float area1 = Math.Abs((points[0].X - point.X) * (points[1].Y - point.Y) - (points[1].X - point.X) * (points[0].Y - point.Y));
            float area2 = Math.Abs((points[1].X - point.X) * (points[2].Y - point.Y) - (points[2].X - point.X) * (points[1].Y - point.Y));
            float area3 = Math.Abs((points[2].X - point.X) * (points[0].Y - point.Y) - (points[0].X - point.X) * (points[2].Y - point.Y));

            float sumOfAreas = area1 + area2 + area3;

            return Math.Abs(triangleArea - sumOfAreas) < 0.0001;
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
        }

        public override ShapeData ToFileData()
        {
            return new TriangleData() { Name = Name, Color = Color, PosX = PosX, PosY = PosY, Side = Side };
        }    

    }
}