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
    public partial class TriangleForm : Form
    {
        private Form1 _mainForm;
        public TriangleForm(Form1 mainForm)
        {
            InitializeComponent();
            this._mainForm = mainForm;
        }

        private void TriangleForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(!_mainForm.ValidateInputs(txt_TrnglName.Text, txt_TrnglColor.Text, txt_TrnglPosX.Text, txt_TrnglPosY.Text))
            {

            }
            else if(!double.TryParse(txt_TrnglSide.Text, out double side) || side <= 0)
            {
                MessageBox.Show("Side must be positive double value!", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            else if(!_mainForm.TestSizeCompatibility(side, side))
            {

            }
            else
            {
                Triangle triangle = new Triangle(txt_TrnglName.Text, 
                    Color.FromName(txt_TrnglColor.Text), 
                    int.Parse(txt_TrnglPosX.Text), 
                    int.Parse(txt_TrnglPosY.Text), 
                    side);

                _mainForm.AddShape(triangle);
                _mainForm.AddItemToListBox(triangle.Name);
                _mainForm.RefreshPanel();
              
                this.Close();
            }

        }

        private void btnCalcArea_Click(object sender, EventArgs e)
        {
            if(!_mainForm.ValidateInputs(txt_TrnglName.Text, txt_TrnglColor.Text, txt_TrnglPosX.Text, txt_TrnglPosY.Text))
            {

            }
            else if (!double.TryParse(txt_TrnglSide.Text, out double side) || side <= 0)
            {
                MessageBox.Show("Side must be positive double value!", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            else if (!_mainForm.TestSizeCompatibility(side, side))
            {

            }
            else
            {
                Shape triangle = new Triangle(txt_TrnglName.Text,
                    Color.FromName(txt_TrnglColor.Text),
                    int.Parse(txt_TrnglPosX.Text),
                    int.Parse(txt_TrnglPosY.Text),
                    side);

                areaLabel.Text = $"Area of the triangle is: {triangle.CalculateArea()}";
            }

        }
      
    }
}