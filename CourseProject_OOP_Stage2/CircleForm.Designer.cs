namespace CourseProject_OOP_Stage2
{
    partial class CircleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CircleForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_crclName = new System.Windows.Forms.TextBox();
            this.txt_crclColor = new System.Windows.Forms.TextBox();
            this.txt_crclPosX = new System.Windows.Forms.TextBox();
            this.txt_crclPosY = new System.Windows.Forms.TextBox();
            this.txt_crclRadius = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCalcArea = new System.Windows.Forms.Button();
            this.areaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(79, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "        Creating a Circle...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.label2.Location = new System.Drawing.Point(39, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.label3.Location = new System.Drawing.Point(39, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Color:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.label4.Location = new System.Drawing.Point(39, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Coordinate X:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.label5.Location = new System.Drawing.Point(39, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Coordinate Y:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.label6.Location = new System.Drawing.Point(39, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Radius:";
            // 
            // txt_crclName
            // 
            this.txt_crclName.BackColor = System.Drawing.Color.Silver;
            this.txt_crclName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_crclName.Location = new System.Drawing.Point(190, 146);
            this.txt_crclName.Name = "txt_crclName";
            this.txt_crclName.Size = new System.Drawing.Size(190, 26);
            this.txt_crclName.TabIndex = 6;
            // 
            // txt_crclColor
            // 
            this.txt_crclColor.BackColor = System.Drawing.Color.Silver;
            this.txt_crclColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_crclColor.Location = new System.Drawing.Point(190, 188);
            this.txt_crclColor.Name = "txt_crclColor";
            this.txt_crclColor.Size = new System.Drawing.Size(190, 26);
            this.txt_crclColor.TabIndex = 7;
            // 
            // txt_crclPosX
            // 
            this.txt_crclPosX.BackColor = System.Drawing.Color.Silver;
            this.txt_crclPosX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_crclPosX.Location = new System.Drawing.Point(190, 229);
            this.txt_crclPosX.Name = "txt_crclPosX";
            this.txt_crclPosX.Size = new System.Drawing.Size(190, 26);
            this.txt_crclPosX.TabIndex = 8;
            // 
            // txt_crclPosY
            // 
            this.txt_crclPosY.BackColor = System.Drawing.Color.Silver;
            this.txt_crclPosY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_crclPosY.Location = new System.Drawing.Point(190, 271);
            this.txt_crclPosY.Name = "txt_crclPosY";
            this.txt_crclPosY.Size = new System.Drawing.Size(190, 26);
            this.txt_crclPosY.TabIndex = 9;
            // 
            // txt_crclRadius
            // 
            this.txt_crclRadius.BackColor = System.Drawing.Color.Silver;
            this.txt_crclRadius.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_crclRadius.Location = new System.Drawing.Point(190, 314);
            this.txt_crclRadius.Name = "txt_crclRadius";
            this.txt_crclRadius.Size = new System.Drawing.Size(190, 26);
            this.txt_crclRadius.TabIndex = 10;
            // 
            // btnCreate
            // 
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.btnCreate.Location = new System.Drawing.Point(271, 415);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(109, 34);
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCalcArea
            // 
            this.btnCalcArea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcArea.ForeColor = System.Drawing.Color.Silver;
            this.btnCalcArea.Location = new System.Drawing.Point(43, 415);
            this.btnCalcArea.Name = "btnCalcArea";
            this.btnCalcArea.Size = new System.Drawing.Size(147, 34);
            this.btnCalcArea.TabIndex = 12;
            this.btnCalcArea.Text = "Calculate Area:";
            this.btnCalcArea.UseVisualStyleBackColor = true;
            this.btnCalcArea.Click += new System.EventHandler(this.btnCalcArea_Click);
            // 
            // areaLabel
            // 
            this.areaLabel.AutoSize = true;
            this.areaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.areaLabel.Location = new System.Drawing.Point(105, 467);
            this.areaLabel.Name = "areaLabel";
            this.areaLabel.Size = new System.Drawing.Size(0, 18);
            this.areaLabel.TabIndex = 13;
            this.areaLabel.Click += new System.EventHandler(this.areaLabel_Click);
            // 
            // CircleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(428, 507);
            this.Controls.Add(this.areaLabel);
            this.Controls.Add(this.btnCalcArea);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txt_crclRadius);
            this.Controls.Add(this.txt_crclPosY);
            this.Controls.Add(this.txt_crclPosX);
            this.Controls.Add(this.txt_crclColor);
            this.Controls.Add(this.txt_crclName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "CircleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creating a Circle";
            this.Load += new System.EventHandler(this.CircleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_crclName;
        private System.Windows.Forms.TextBox txt_crclColor;
        private System.Windows.Forms.TextBox txt_crclPosX;
        private System.Windows.Forms.TextBox txt_crclPosY;
        private System.Windows.Forms.TextBox txt_crclRadius;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCalcArea;
        private System.Windows.Forms.Label areaLabel;
    }
}