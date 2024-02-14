using CourseProject_OOP_Stage2.ShapesForXmlSerialization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject_OOP_Stage2
{
    public partial class Form2 : Form
    {
        private Form1 _mainForm;
        public Form2(Form1 mainForm)
        {
            InitializeComponent();
            this._mainForm = mainForm;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(!_mainForm.ValidateInputs(txt_RectName.Text, txt_RectColor.Text, txt_RectPosX.Text, txt_RectPosY.Text))
            {

            }else if(!WidthHeightValidation(txt_RectWidth.Text, txt_RectHeight.Text))
            {

            }         
            else
            {
                Rectangle rectangle = new Rectangle(txt_RectName.Text,
                    Color.FromName(txt_RectColor.Text),
                    int.Parse(txt_RectPosX.Text),
                    int.Parse(txt_RectPosY.Text),
                    double.Parse(txt_RectWidth.Text),
                    double.Parse(txt_RectHeight.Text));
                
                _mainForm.AddShape(rectangle);
                _mainForm.AddItemToListBox(rectangle.Name);
                _mainForm.RefreshPanel();                

                this.Close();
            }   

        }

        private void btnCalcArea_Click(object sender, EventArgs e)
        {
                if(!_mainForm.ValidateInputs(txt_RectName.Text, txt_RectColor.Text, txt_RectPosX.Text, txt_RectPosY.Text))
                {

                }
                else if(!WidthHeightValidation(txt_RectWidth.Text, txt_RectHeight.Text))
                {

                }
                else
                {
                    Shape rectangle = new Rectangle(txt_RectName.Text,
                        Color.FromName(txt_RectColor.Text), 
                        int.Parse(txt_RectPosX.Text), 
                        int.Parse(txt_RectPosY.Text), 
                        double.Parse(txt_RectWidth.Text),
                        double.Parse(txt_RectHeight.Text));

                    areaLabel.Text = $"Area of the rectangle is: {rectangle.CalculateArea()}";
                    
                }
        }
      
        public bool WidthHeightValidation(string rectWidth, string rectHeight)
        {
            if(!double.TryParse(txt_RectWidth.Text, out double width) || width <= 0)
            {
                MessageBox.Show("Width must be positive double value!", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            else if(!double.TryParse(txt_RectHeight.Text, out double height) || height <= 0)
            {
                MessageBox.Show("Height must be positive double value!", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            else if(!_mainForm.TestSizeCompatibility(width, height))
            {
                
            }           
            else
            {
                return true;
            }

            return false;
        }

    }
}