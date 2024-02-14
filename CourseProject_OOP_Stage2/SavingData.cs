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
    public partial class SavingData : Form
    {
        private Form1 _mainForm;
        public SavingData(Form1 mainForm)
        {
            InitializeComponent();
            this._mainForm = mainForm;
        }

        private void SavingData_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //if (_mainForm.ValidateShapesCount())
            //{
            //    if (rbtn_Binary.Checked == true)
            //    {
            //        _mainForm.SaveBinaryFile();
            //    }
            //    else if (rbtn_Xml.Checked == true)
            //    {
            //        _mainForm.SaveXmlFile();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Choose file format");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("No data was provided!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

            //this.Close();
        }
    }
}