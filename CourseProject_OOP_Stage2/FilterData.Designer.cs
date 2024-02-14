namespace CourseProject_OOP_Stage2
{
    partial class FilterData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterData));
            this.label1 = new System.Windows.Forms.Label();
            this.rbtn_OrderA = new System.Windows.Forms.RadioButton();
            this.rbtn_OrderD = new System.Windows.Forms.RadioButton();
            this.rbtn_Reverse = new System.Windows.Forms.RadioButton();
            this.rbtn_MaxArea = new System.Windows.Forms.RadioButton();
            this.rbtn_MinArea = new System.Windows.Forms.RadioButton();
            this.rbtn_AvgArea = new System.Windows.Forms.RadioButton();
            this.btn_Continue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(77, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "      Filter by:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbtn_OrderA
            // 
            this.rbtn_OrderA.AutoSize = true;
            this.rbtn_OrderA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtn_OrderA.ForeColor = System.Drawing.Color.Silver;
            this.rbtn_OrderA.Location = new System.Drawing.Point(43, 86);
            this.rbtn_OrderA.Name = "rbtn_OrderA";
            this.rbtn_OrderA.Size = new System.Drawing.Size(166, 25);
            this.rbtn_OrderA.TabIndex = 1;
            this.rbtn_OrderA.TabStop = true;
            this.rbtn_OrderA.Text = "Order By Ascending";
            this.rbtn_OrderA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtn_OrderA.UseVisualStyleBackColor = true;
            // 
            // rbtn_OrderD
            // 
            this.rbtn_OrderD.AutoSize = true;
            this.rbtn_OrderD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtn_OrderD.ForeColor = System.Drawing.Color.Silver;
            this.rbtn_OrderD.Location = new System.Drawing.Point(43, 122);
            this.rbtn_OrderD.Name = "rbtn_OrderD";
            this.rbtn_OrderD.Size = new System.Drawing.Size(175, 25);
            this.rbtn_OrderD.TabIndex = 2;
            this.rbtn_OrderD.TabStop = true;
            this.rbtn_OrderD.Text = "Order By Descending";
            this.rbtn_OrderD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtn_OrderD.UseVisualStyleBackColor = true;
            // 
            // rbtn_Reverse
            // 
            this.rbtn_Reverse.AutoSize = true;
            this.rbtn_Reverse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtn_Reverse.ForeColor = System.Drawing.Color.Silver;
            this.rbtn_Reverse.Location = new System.Drawing.Point(43, 158);
            this.rbtn_Reverse.Name = "rbtn_Reverse";
            this.rbtn_Reverse.Size = new System.Drawing.Size(137, 25);
            this.rbtn_Reverse.TabIndex = 3;
            this.rbtn_Reverse.TabStop = true;
            this.rbtn_Reverse.Text = "Reversed Order";
            this.rbtn_Reverse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtn_Reverse.UseVisualStyleBackColor = true;
            // 
            // rbtn_MaxArea
            // 
            this.rbtn_MaxArea.AutoSize = true;
            this.rbtn_MaxArea.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtn_MaxArea.ForeColor = System.Drawing.Color.Silver;
            this.rbtn_MaxArea.Location = new System.Drawing.Point(43, 194);
            this.rbtn_MaxArea.Name = "rbtn_MaxArea";
            this.rbtn_MaxArea.Size = new System.Drawing.Size(168, 25);
            this.rbtn_MaxArea.TabIndex = 4;
            this.rbtn_MaxArea.TabStop = true;
            this.rbtn_MaxArea.Text = "Get Max Shape Area";
            this.rbtn_MaxArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtn_MaxArea.UseVisualStyleBackColor = true;
            // 
            // rbtn_MinArea
            // 
            this.rbtn_MinArea.AutoSize = true;
            this.rbtn_MinArea.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtn_MinArea.ForeColor = System.Drawing.Color.Silver;
            this.rbtn_MinArea.Location = new System.Drawing.Point(43, 230);
            this.rbtn_MinArea.Name = "rbtn_MinArea";
            this.rbtn_MinArea.Size = new System.Drawing.Size(166, 25);
            this.rbtn_MinArea.TabIndex = 5;
            this.rbtn_MinArea.TabStop = true;
            this.rbtn_MinArea.Text = "Get Min Shape Area";
            this.rbtn_MinArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtn_MinArea.UseVisualStyleBackColor = true;
            // 
            // rbtn_AvgArea
            // 
            this.rbtn_AvgArea.AutoSize = true;
            this.rbtn_AvgArea.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtn_AvgArea.ForeColor = System.Drawing.Color.Silver;
            this.rbtn_AvgArea.Location = new System.Drawing.Point(43, 266);
            this.rbtn_AvgArea.Name = "rbtn_AvgArea";
            this.rbtn_AvgArea.Size = new System.Drawing.Size(196, 25);
            this.rbtn_AvgArea.TabIndex = 6;
            this.rbtn_AvgArea.TabStop = true;
            this.rbtn_AvgArea.Text = "Get Average Shape Area";
            this.rbtn_AvgArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtn_AvgArea.UseVisualStyleBackColor = true;
            // 
            // btn_Continue
            // 
            this.btn_Continue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Continue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Continue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Continue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.btn_Continue.Location = new System.Drawing.Point(90, 313);
            this.btn_Continue.Name = "btn_Continue";
            this.btn_Continue.Size = new System.Drawing.Size(83, 37);
            this.btn_Continue.TabIndex = 7;
            this.btn_Continue.Text = "Continue";
            this.btn_Continue.UseVisualStyleBackColor = true;
            this.btn_Continue.Click += new System.EventHandler(this.btn_Continue_Click);
            // 
            // FilterData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(265, 371);
            this.Controls.Add(this.btn_Continue);
            this.Controls.Add(this.rbtn_AvgArea);
            this.Controls.Add(this.rbtn_MinArea);
            this.Controls.Add(this.rbtn_MaxArea);
            this.Controls.Add(this.rbtn_Reverse);
            this.Controls.Add(this.rbtn_OrderD);
            this.Controls.Add(this.rbtn_OrderA);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FilterData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filter by:";
            this.Load += new System.EventHandler(this.FilterData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtn_OrderA;
        private System.Windows.Forms.RadioButton rbtn_OrderD;
        private System.Windows.Forms.RadioButton rbtn_Reverse;
        private System.Windows.Forms.RadioButton rbtn_MaxArea;
        private System.Windows.Forms.RadioButton rbtn_MinArea;
        private System.Windows.Forms.RadioButton rbtn_AvgArea;
        private System.Windows.Forms.Button btn_Continue;
    }
}