namespace CourseProject_OOP_Stage2
{
    partial class SavingData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SavingData));
            this.label1 = new System.Windows.Forms.Label();
            this.rbtn_Binary = new System.Windows.Forms.RadioButton();
            this.rbtn_Xml = new System.Windows.Forms.RadioButton();
            this.btn_Save = new System.Windows.Forms.Button();
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
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "      Save as:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbtn_Binary
            // 
            this.rbtn_Binary.AutoSize = true;
            this.rbtn_Binary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtn_Binary.ForeColor = System.Drawing.Color.Silver;
            this.rbtn_Binary.Location = new System.Drawing.Point(83, 56);
            this.rbtn_Binary.Name = "rbtn_Binary";
            this.rbtn_Binary.Size = new System.Drawing.Size(53, 25);
            this.rbtn_Binary.TabIndex = 1;
            this.rbtn_Binary.TabStop = true;
            this.rbtn_Binary.Text = ".bin";
            this.rbtn_Binary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtn_Binary.UseVisualStyleBackColor = true;
            // 
            // rbtn_Xml
            // 
            this.rbtn_Xml.AutoSize = true;
            this.rbtn_Xml.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtn_Xml.ForeColor = System.Drawing.Color.Silver;
            this.rbtn_Xml.Location = new System.Drawing.Point(265, 56);
            this.rbtn_Xml.Name = "rbtn_Xml";
            this.rbtn_Xml.Size = new System.Drawing.Size(56, 25);
            this.rbtn_Xml.TabIndex = 2;
            this.rbtn_Xml.TabStop = true;
            this.rbtn_Xml.Text = ".xml";
            this.rbtn_Xml.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtn_Xml.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.btn_Save.Location = new System.Drawing.Point(164, 83);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 27);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // SavingData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(397, 119);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.rbtn_Xml);
            this.Controls.Add(this.rbtn_Binary);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SavingData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choosing save type";
            this.Load += new System.EventHandler(this.SavingData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtn_Binary;
        private System.Windows.Forms.RadioButton rbtn_Xml;
        private System.Windows.Forms.Button btn_Save;
    }
}