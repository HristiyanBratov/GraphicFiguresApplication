using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.AccessControl;
using CourseProject_OOP_Stage2.ShapesForXmlSerialization;

namespace CourseProject_OOP_Stage2
{
    public partial class Form1 : Form
    {   
        private readonly List<Shape> _shapes;

        // Path to the file
        private readonly string filePath = "data.bin";
        //private readonly string filePathXml = "dataXml.txt"; -> Xml

        // Data used in mouse events
        private bool isDragging = false;  
        private Point _offSet;
        private Shape currentShape;  
        
        public Form1()
        {
            InitializeComponent();
            _shapes = new List<Shape>();

            // Reflection used for removing flickering
            typeof(Panel).InvokeMember("DoubleBuffered",
            BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
            null, drawPanel, new object[] { true });    
        }    

        private void Form1_Load(object sender, EventArgs e)
        {
                                
        }

        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            Form2 rectangleForm = new Form2(this);
            rectangleForm.Show();
        }

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            SquareForm squareForm = new SquareForm(this);
            squareForm.Show();
        }

        private void buttonTriangle_Click(object sender, EventArgs e)
        {
            TriangleForm triangleForm = new TriangleForm(this);
            triangleForm.Show();
        }

        private void buttonCircle_Click(object sender, EventArgs e)
        {
            CircleForm circleForm = new CircleForm(this);
            circleForm.Show();
        }

        public bool ValidateInputs(string name, string color, string posX, string posY)
        {
            Color shapeColor = Color.FromName(color);

            if (name == "")
            {
                MessageBox.Show("You must enter a name!", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            else if (!shapeColor.IsKnownColor)
            {
                MessageBox.Show("Invalid color!", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            else if ((!int.TryParse(posX, out int x) || x < 0) || (!int.TryParse(posY, out int y) || y < 0))
            {
                MessageBox.Show("Coordinates must be positive integers!", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            else if(x >= drawPanel.Width || y >= drawPanel.Height)
            {
                MessageBox.Show("Invalid coordinates!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                return true;
            }

            return false;
        }

        public bool TestSizeCompatibility(double shapeWidth, double shapeHeight)
        {
            if(shapeWidth >= drawPanel.Width || shapeHeight >= drawPanel.Height)
            {
                MessageBox.Show("The shape is too large!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }         
            else
            {
                return true;
            }

            return false;
        }

        public bool ValidateShapesCount()
        {
            if(_shapes.Count > 0)
            {
                return true;
            }

            return false;
        }

        public void AddShape(Shape shape)
        {
            shape.TimeAddedInList = DateTime.Now;
            _shapes.Add(shape);
        }

        public void AddItemToListBox(string shape)
        {
            shapeList.Items.Add(shape);
        }

        public void RefreshPanel()
        {
            drawPanel.Refresh();
        }

        // For Xml Serialization...
        //public void SaveXmlFile()
        //{
        //    var data = _shapes.Select(s => s.ToFileData()).ToArray();
        //    IDataSerializable dataSerializable = new MyXmlSerializer();
        //    dataSerializable.Serialize(data, filePathXml);
        //}

        // For Xml Deserialization...
        //public void LoadXmlFile()
        //{
        //    IDataSerializable dataSerializable = new MyXmlSerializer();

        //    List<Shape> loadedShapes = null;

        //    loadedShapes = dataSerializable.Deserialize(filePath) as List<Shape>;

        //    _shapes.Clear();
        //    _shapes.AddRange(loadedShapes);                    
        //}

        public void SaveBinaryFile()
        {
            IDataSerializable dataSerializable = new MyBinarySerializer();
            dataSerializable.Serialize(_shapes, filePath);
        }

        public void LoadBinaryFile()
        {
            IDataSerializable dataSerializable = new MyBinarySerializer();

            List<Shape> loadedShapes = null;         

            loadedShapes = dataSerializable.Deserialize(filePath) as List<Shape>;

            _shapes.Clear();
            shapeList.Items.Clear();
            _shapes.AddRange(loadedShapes);
            _shapes.ForEach(s => AddItemToListBox(s.Name));                      
        }
        
        public void OrderByAscending()
        {
            var orderedNamesAscending = shapeList.Items.Cast<string>()
                .OrderBy(x => x)
                .ToList();

            shapeList.Items.Clear();
            shapeList.Items.AddRange(orderedNamesAscending.ToArray());
        }

        public void OrderByDescending()
        {
            var orderedNamesDescending = shapeList.Items.Cast<string>()
                .OrderByDescending(x => x)
                .ToList();

            shapeList.Items.Clear();
            shapeList.Items.AddRange(orderedNamesDescending.ToArray());
        }

        public void ReversedOrder()
        {
            var reversedOrder = shapeList.Items.Cast<string>()
                .Reverse()
                .ToList();

            shapeList.Items.Clear();
            shapeList.Items.AddRange(reversedOrder.ToArray());
        }      

        public double GetMaxArea()
        {
            var maxArea = _shapes.Max(x => x.CalculateArea());

            return maxArea;
        }

        public double GetMinArea()
        {
            var minArea = _shapes.Min(x => x.CalculateArea());

            return minArea;
        }

        public double GetAverageArea()
        {
            var avgArea = _shapes.Average(x => x.CalculateArea());

            return avgArea;
        }

        private void drawPanel_Paint(object sender, PaintEventArgs e)
        {
            foreach (var shape in _shapes)
            {
                if(shape.IsDeleted == false)
                    shape.Draw(e.Graphics);
            }
        }
                 
        private void drawPanel_MouseDown(object sender, MouseEventArgs e)
        {
            // Reverse loop shapes in order to get the last/top element
            for (int i = _shapes.Count - 1; i >= 0; i--)
            {
                if (_shapes[i].IsPointInside(e.Location))
                {
                    currentShape = _shapes[i];
                    if (e.Button == MouseButtons.Left)
                    {                               
                    
                        isDragging = true;                     
                        _offSet = new Point(e.Location.X - currentShape.PosX, e.Location.Y - currentShape.PosY);
                        _shapes.Remove(_shapes[i]);
                        _shapes.Add(currentShape);

                        break;
                    }
                    else if(e.Button == MouseButtons.Right)
                    {
                        Random random = new Random();
                        currentShape.Color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                        drawPanel.Refresh();
                    }
                    else if(e.Button == MouseButtons.Middle)
                    {
                        _shapes.Remove(currentShape);
                        drawPanel.Refresh();
                        
                        shapeList.Items.Remove(currentShape.Name);
                        shapeList.Refresh();
                    }
                }
            }
                 
        }  

        private void drawPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                double updatedX = e.Location.X - _offSet.X;
                double updatedY = e.Location.Y - _offSet.Y;

                if (currentShape is Rectangle rectangle)
                {
                    updatedX = Math.Min(Math.Max(updatedX, 0), drawPanel.Width - rectangle.Side);
                    updatedY = Math.Min(Math.Max(updatedY, 0), drawPanel.Height - rectangle.SecondSide);
                }
                else if(currentShape is Square square)
                {
                    updatedX = Math.Min(Math.Max(updatedX, 0), drawPanel.Width - square.Side);
                    updatedY = Math.Min(Math.Max(updatedY, 0), drawPanel.Height - square.Side);
                }
                else if (currentShape is Circle circle)
                {
                    updatedX = Math.Min(Math.Max(updatedX, 0), drawPanel.Width - circle.Radius);
                    updatedY = Math.Min(Math.Max(updatedY, 0), drawPanel.Height - circle.Radius);
                }
                else if (currentShape is Triangle triangle)
                {                   
                    updatedX = Math.Min(Math.Max(updatedX, 0), drawPanel.Width - triangle.Side);
                    updatedY = Math.Min(Math.Max(updatedY, 0), drawPanel.Height - triangle.Side);
                }

                currentShape.PosX = int.Parse(updatedX.ToString());
                currentShape.PosY = int.Parse(updatedY.ToString());

                drawPanel.Refresh();
            }           
        }

        private void drawPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void shapeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
       
        private void button3_MouseHover(object sender, EventArgs e)
        {
            /*
            button3.BackColor = Color.FromArgb(255, 217, 78, 78);
            button3.ForeColor = Color.Black;
            */
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            /*
            button3.BackColor = Color.FromArgb(255, 35, 40, 45);
            button3.ForeColor = Color.FromArgb(255, 217, 78, 78);
            */
        }

        private void btn_SaveDataToFile_Click(object sender, EventArgs e)
        {
            // Saving data dialog window for more than one choice for serialization...
            /*SavingData saveData = new SavingData(this);
            saveData.Show();*/

            if (ValidateShapesCount())
            {
                SaveBinaryFile();
            }
            else
            {
                MessageBox.Show("No data was provided!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_LoadDataFromFile_Click(object sender, EventArgs e)
        {          
            if(new FileInfo(filePath).Length > 0)
            {
                LoadBinaryFile();
                drawPanel.Invalidate();
            }
            else
            {
                MessageBox.Show("The file does not contain data for any shape!", "No Data Provided", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            _shapes.Clear();
            shapeList.Items.Clear();
            drawPanel.Refresh();

            File.WriteAllText(filePath, string.Empty);
        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            FilterData filterData = new FilterData(this);
            filterData.Show();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {            
            if (shapeList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select a shape to edit.", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                for (int i = 0; i < _shapes.Count; i++)
                {
                    string selectedShapeName = shapeList.SelectedItem.ToString();
                    if (_shapes[i].Name == selectedShapeName)
                    {
                        if (_shapes[i] is Rectangle)
                        {
                            buttonRectangle_Click(sender, e);
                        }
                        if (_shapes[i] is Square)
                        {
                            buttonSquare_Click(sender, e);
                        }
                        if (_shapes[i] is Triangle)
                        {
                            buttonTriangle_Click(sender, e);
                        }
                        if (_shapes[i] is Circle)
                        {
                            buttonCircle_Click(sender, e);
                        }

                        _shapes.RemoveAt(i);
                        shapeList.Items.Remove(selectedShapeName);
                        RefreshPanel();
                        break;
                    }

                }

            }
        }

        private void btn_Guide_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Guide for working with drawn shapes: \n\n" +
                "1. Click left button of the mouse to move the shape. \n\n" +
                "2. Click right button of the mouse to change the color of the shape. \n\n" +
                "3. Click middle button of the mouse to delete the shape.",
                "Guide",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btn_Undo_Click(object sender, EventArgs e)
        {
            var lastAddedShape = _shapes.OrderByDescending(s => s.TimeAddedInList)
                .FirstOrDefault(s => s.IsDeleted == false);

            if (lastAddedShape != null)
            {
                lastAddedShape.IsDeleted = true;
                shapeList.Items.Remove(lastAddedShape.Name);
                RefreshPanel();
            }
        }

        private void btn_Redo_Click(object sender, EventArgs e)
        {

            var redrawShape = _shapes.OrderBy(s => s.TimeAddedInList)
                .FirstOrDefault(s => s.IsDeleted == true);

            if (redrawShape != null)
            {
                redrawShape.IsDeleted = false;
                shapeList.Items.Add(redrawShape.Name);
                RefreshPanel();
            }
        }
     
    }
}