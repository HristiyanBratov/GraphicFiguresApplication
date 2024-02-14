namespace CourseProject_OOP_Stage2
{
    partial class LoadingData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingData));
            this.label1 = new System.Windows.Forms.Label();
            this.rbtn_BinaryL = new System.Windows.Forms.RadioButton();
            this.rbtn_XmlL = new System.Windows.Forms.RadioButton();
            this.btn_Load = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(144, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "      Load as:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbtn_BinaryL
            // 
            this.rbtn_BinaryL.AutoSize = true;
            this.rbtn_BinaryL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtn_BinaryL.ForeColor = System.Drawing.Color.Silver;
            this.rbtn_BinaryL.Location = new System.Drawing.Point(83, 56);
            this.rbtn_BinaryL.Name = "rbtn_BinaryL";
            this.rbtn_BinaryL.Size = new System.Drawing.Size(53, 25);
            this.rbtn_BinaryL.TabIndex = 1;
            this.rbtn_BinaryL.TabStop = true;
            this.rbtn_BinaryL.Text = ".bin";
            this.rbtn_BinaryL.UseVisualStyleBackColor = true;
            // 
            // rbtn_XmlL
            // 
            this.rbtn_XmlL.AutoSize = true;
            this.rbtn_XmlL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtn_XmlL.ForeColor = System.Drawing.Color.Silver;
            this.rbtn_XmlL.Location = new System.Drawing.Point(265, 56);
            this.rbtn_XmlL.Name = "rbtn_XmlL";
            this.rbtn_XmlL.Size = new System.Drawing.Size(56, 25);
            this.rbtn_XmlL.TabIndex = 2;
            this.rbtn_XmlL.TabStop = true;
            this.rbtn_XmlL.Text = ".xml";
            this.rbtn_XmlL.UseVisualStyleBackColor = true;
            // 
            // btn_Load
            // 
            this.btn_Load.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Load.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.btn_Load.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.btn_Load.Location = new System.Drawing.Point(164, 83);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(75, 27);
            this.btn_Load.TabIndex = 3;
            this.btn_Load.Text = "Load";
            this.btn_Load.UseVisualStyleBackColor = true;
            // 
            // LoadingData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(397, 119);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.rbtn_XmlL);
            this.Controls.Add(this.rbtn_BinaryL);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoadingData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choosing load type";
            this.Load += new System.EventHandler(this.LoadingData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtn_BinaryL;
        private System.Windows.Forms.RadioButton rbtn_XmlL;
        private System.Windows.Forms.Button btn_Load;
    }
}