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
    public partial class FilterData : Form
    {
        private Form1 _mainForm;
        public FilterData(Form1 mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void FilterData_Load(object sender, EventArgs e)
        {

        }

        private void btn_Continue_Click(object sender, EventArgs e)
        {
            if (_mainForm.ValidateShapesCount())
            {
                if (rbtn_OrderA.Checked == true)
                {
                    _mainForm.OrderByAscending();
                }
                else if (rbtn_OrderD.Checked == true)
                {
                    _mainForm.OrderByDescending();
                }
                else if (rbtn_Reverse.Checked == true)
                {
                    _mainForm.ReversedOrder();
                }
                else if (rbtn_MaxArea.Checked == true)
                {
                    MessageBox.Show($"The biggest area of all shapes is: {_mainForm.GetMaxArea()}", "Max Area", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (rbtn_MinArea.Checked == true)
                {
                    MessageBox.Show($"The smallest area of all shapes is: {_mainForm.GetMinArea()}", "Min Area", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (rbtn_AvgArea.Checked == true)
                {
                    MessageBox.Show($"The average area of all shapes is: {_mainForm.GetAverageArea()}", "Average Area", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No data was provided!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            this.Close();
        }
    }
}