using CourseProject_OOP_Stage2.ShapesForXmlSerialization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject_OOP_Stage2
{
    public partial class CircleForm : Form
    {
        private Form1 _mainform;
        public CircleForm(Form1 mainform)
        {
            InitializeComponent();
            this._mainform = mainform;
        }

        private void CircleForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(!_mainform.ValidateInputs(txt_crclName.Text, txt_crclColor.Text, txt_crclPosX.Text, txt_crclPosY.Text))
            {

            }
            else if(!double.TryParse(txt_crclRadius.Text, out double radius) || radius <= 0)
            {
                MessageBox.Show("Radius must be positive double value!", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            else if(!_mainform.TestSizeCompatibility(radius, radius))
            {

            }
            else
            {
                Circle circle = new Circle(txt_crclName.Text,
                    Color.FromName(txt_crclColor.Text),
                    int.Parse(txt_crclPosX.Text),
                    int.Parse(txt_crclPosY.Text),
                    radius);

                _mainform.AddShape(circle);
                _mainform.AddItemToListBox(circle.Name);
                _mainform.RefreshPanel();                 

                this.Close();
            }

        }

        private void btnCalcArea_Click(object sender, EventArgs e)
        {
            if (!_mainform.ValidateInputs(txt_crclName.Text, txt_crclColor.Text, txt_crclPosX.Text, txt_crclPosY.Text))
            {

            }
            else if (!double.TryParse(txt_crclRadius.Text, out double radius) || radius <= 0)
            {
                MessageBox.Show("Radius must be positive double value!", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            else if (!_mainform.TestSizeCompatibility(radius, radius))
            {

            }
            else
            {
                Shape circle = new Circle(txt_crclName.Text,
                    Color.FromName(txt_crclColor.Text),
                    int.Parse(txt_crclPosX.Text),
                    int.Parse(txt_crclPosY.Text),
                    radius);
            
                areaLabel.Text = $"Area of the circle is: {circle.CalculateArea()}";
            }

        }

        private void areaLabel_Click(object sender, EventArgs e) // Not needed for now
        {

        }

    }
}