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
    public partial class SquareForm : Form
    {
        private Form1 _mainForm;
        public SquareForm(Form1 mainform)
        {
            InitializeComponent();
            this._mainForm = mainform;
        }

        private void SquareForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(!_mainForm.ValidateInputs(txt_SqrName.Text, txt_SqrColor.Text, txt_SqrPosX.Text, txt_SqrPosY.Text))
            {
                
            } 
            else if(!double.TryParse(txt_SqrSide.Text, out double side) || side <= 0)
            {
                MessageBox.Show("Side must be positive double value!", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            else if(!_mainForm.TestSizeCompatibility(side, side))
            {

            }
            else
            {
                Square square = new Square(txt_SqrName.Text, 
                    Color.FromName(txt_SqrColor.Text), 
                    int.Parse(txt_SqrPosX.Text), 
                    int.Parse(txt_SqrPosY.Text), 
                    side);

                _mainForm.AddShape(square);
                _mainForm.AddItemToListBox(square.Name);
                _mainForm.RefreshPanel();              

                this.Close();
            }

        }

        private void btnCalcArea_Click(object sender, EventArgs e)
        {
            if (!_mainForm.ValidateInputs(txt_SqrName.Text, txt_SqrColor.Text, txt_SqrPosX.Text, txt_SqrPosY.Text))
            {

            }
            else if (!double.TryParse(txt_SqrSide.Text, out double side) || side <= 0)
            {
                MessageBox.Show("Side must be positive double value!", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            else if (!_mainForm.TestSizeCompatibility(side, side))
            {

            }
            else
            {
                Shape square = new Square(txt_SqrName.Text,
                    Color.FromName(txt_SqrColor.Text),
                    int.Parse(txt_SqrPosX.Text),
                    int.Parse(txt_SqrPosY.Text),
                    side);

                areaLabel.Text = $"Area of the square is: {square.CalculateArea()}";
            }

        }

    }
}