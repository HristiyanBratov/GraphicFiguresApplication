namespace CourseProject_OOP_Stage2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SideBar = new System.Windows.Forms.Panel();
            this.btn_Guide = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonRectangle = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonSquare = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonTriangle = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.buttonCircle = new System.Windows.Forms.Button();
            this.shapeList = new System.Windows.Forms.ListBox();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Filter = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_SaveDataToFile = new System.Windows.Forms.Button();
            this.btn_LoadDataFromFile = new System.Windows.Forms.Button();
            this.btn_Undo = new System.Windows.Forms.Button();
            this.btn_Redo = new System.Windows.Forms.Button();
            this.drawPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.flowLayoutPanel1.Controls.Add(this.SideBar);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel6);
            this.flowLayoutPanel1.Controls.Add(this.shapeList);
            this.flowLayoutPanel1.Controls.Add(this.btn_Edit);
            this.flowLayoutPanel1.Controls.Add(this.btn_Filter);
            this.flowLayoutPanel1.Controls.Add(this.btn_Clear);
            this.flowLayoutPanel1.Controls.Add(this.btn_SaveDataToFile);
            this.flowLayoutPanel1.Controls.Add(this.btn_LoadDataFromFile);
            this.flowLayoutPanel1.Controls.Add(this.btn_Undo);
            this.flowLayoutPanel1.Controls.Add(this.btn_Redo);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(235, 634);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(235, 634);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(235, 634);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // SideBar
            // 
            this.SideBar.Controls.Add(this.btn_Guide);
            this.SideBar.Controls.Add(this.label1);
            this.SideBar.Controls.Add(this.pictureBox1);
            this.SideBar.Location = new System.Drawing.Point(3, 3);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(240, 75);
            this.SideBar.TabIndex = 0;
            // 
            // btn_Guide
            // 
            this.btn_Guide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Guide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Guide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Guide.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Guide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.btn_Guide.Image = ((System.Drawing.Image)(resources.GetObject("btn_Guide.Image")));
            this.btn_Guide.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Guide.Location = new System.Drawing.Point(159, -3);
            this.btn_Guide.Name = "btn_Guide";
            this.btn_Guide.Size = new System.Drawing.Size(75, 24);
            this.btn_Guide.TabIndex = 2;
            this.btn_Guide.Text = "     Guide";
            this.btn_Guide.UseVisualStyleBackColor = true;
            this.btn_Guide.Click += new System.EventHandler(this.btn_Guide_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(56, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonRectangle);
            this.panel2.Location = new System.Drawing.Point(3, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 59);
            this.panel2.TabIndex = 1;
            // 
            // buttonRectangle
            // 
            this.buttonRectangle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.buttonRectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRectangle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRectangle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonRectangle.Image = ((System.Drawing.Image)(resources.GetObject("buttonRectangle.Image")));
            this.buttonRectangle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRectangle.Location = new System.Drawing.Point(-24, -9);
            this.buttonRectangle.Name = "buttonRectangle";
            this.buttonRectangle.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.buttonRectangle.Size = new System.Drawing.Size(293, 75);
            this.buttonRectangle.TabIndex = 1;
            this.buttonRectangle.Text = "                 Rectangle";
            this.buttonRectangle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRectangle.UseVisualStyleBackColor = false;
            this.buttonRectangle.Click += new System.EventHandler(this.buttonRectangle_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonSquare);
            this.panel3.Location = new System.Drawing.Point(3, 149);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 59);
            this.panel3.TabIndex = 1;
            // 
            // buttonSquare
            // 
            this.buttonSquare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSquare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSquare.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSquare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonSquare.Image = ((System.Drawing.Image)(resources.GetObject("buttonSquare.Image")));
            this.buttonSquare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSquare.Location = new System.Drawing.Point(-26, -8);
            this.buttonSquare.Name = "buttonSquare";
            this.buttonSquare.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.buttonSquare.Size = new System.Drawing.Size(292, 74);
            this.buttonSquare.TabIndex = 5;
            this.buttonSquare.Text = "                  Square";
            this.buttonSquare.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSquare.UseVisualStyleBackColor = true;
            this.buttonSquare.Click += new System.EventHandler(this.buttonSquare_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.buttonTriangle);
            this.panel4.Location = new System.Drawing.Point(3, 214);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(240, 59);
            this.panel4.TabIndex = 2;
            // 
            // buttonTriangle
            // 
            this.buttonTriangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTriangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTriangle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTriangle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonTriangle.Image = ((System.Drawing.Image)(resources.GetObject("buttonTriangle.Image")));
            this.buttonTriangle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTriangle.Location = new System.Drawing.Point(-28, -7);
            this.buttonTriangle.Name = "buttonTriangle";
            this.buttonTriangle.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.buttonTriangle.Size = new System.Drawing.Size(292, 74);
            this.buttonTriangle.TabIndex = 6;
            this.buttonTriangle.Text = "                  Triangle";
            this.buttonTriangle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTriangle.UseVisualStyleBackColor = true;
            this.buttonTriangle.Click += new System.EventHandler(this.buttonTriangle_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.buttonCircle);
            this.panel6.Location = new System.Drawing.Point(3, 279);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(240, 59);
            this.panel6.TabIndex = 4;
            // 
            // buttonCircle
            // 
            this.buttonCircle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCircle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCircle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCircle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonCircle.Image = ((System.Drawing.Image)(resources.GetObject("buttonCircle.Image")));
            this.buttonCircle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCircle.Location = new System.Drawing.Point(-25, -9);
            this.buttonCircle.Name = "buttonCircle";
            this.buttonCircle.Padding = new System.Windows.Forms.Padding(36, 0, 0, 0);
            this.buttonCircle.Size = new System.Drawing.Size(292, 74);
            this.buttonCircle.TabIndex = 8;
            this.buttonCircle.Text = "                 Circle";
            this.buttonCircle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCircle.UseVisualStyleBackColor = true;
            this.buttonCircle.Click += new System.EventHandler(this.buttonCircle_Click);
            // 
            // shapeList
            // 
            this.shapeList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.shapeList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.shapeList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.shapeList.FormattingEnabled = true;
            this.shapeList.ItemHeight = 17;
            this.shapeList.Location = new System.Drawing.Point(3, 344);
            this.shapeList.Name = "shapeList";
            this.shapeList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.shapeList.Size = new System.Drawing.Size(229, 153);
            this.shapeList.TabIndex = 1;
            this.shapeList.SelectedIndexChanged += new System.EventHandler(this.shapeList_SelectedIndexChanged);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Edit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Edit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.btn_Edit.Location = new System.Drawing.Point(6, 515);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(6, 15, 3, 3);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(68, 27);
            this.btn_Edit.TabIndex = 5;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Filter
            // 
            this.btn_Filter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Filter.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btn_Filter.ForeColor = System.Drawing.Color.Silver;
            this.btn_Filter.Location = new System.Drawing.Point(82, 515);
            this.btn_Filter.Margin = new System.Windows.Forms.Padding(5, 15, 5, 3);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(68, 27);
            this.btn_Filter.TabIndex = 9;
            this.btn_Filter.Text = "Filter";
            this.btn_Filter.UseVisualStyleBackColor = true;
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.btn_Clear.Location = new System.Drawing.Point(160, 515);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(5, 15, 3, 3);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(68, 27);
            this.btn_Clear.TabIndex = 6;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            this.btn_Clear.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            this.btn_Clear.MouseHover += new System.EventHandler(this.button3_MouseHover);
            // 
            // btn_SaveDataToFile
            // 
            this.btn_SaveDataToFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SaveDataToFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SaveDataToFile.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btn_SaveDataToFile.ForeColor = System.Drawing.Color.Silver;
            this.btn_SaveDataToFile.Location = new System.Drawing.Point(15, 557);
            this.btn_SaveDataToFile.Margin = new System.Windows.Forms.Padding(15, 12, 3, 3);
            this.btn_SaveDataToFile.Name = "btn_SaveDataToFile";
            this.btn_SaveDataToFile.Size = new System.Drawing.Size(85, 27);
            this.btn_SaveDataToFile.TabIndex = 7;
            this.btn_SaveDataToFile.Text = "Save Data";
            this.btn_SaveDataToFile.UseVisualStyleBackColor = true;
            this.btn_SaveDataToFile.Click += new System.EventHandler(this.btn_SaveDataToFile_Click);
            // 
            // btn_LoadDataFromFile
            // 
            this.btn_LoadDataFromFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LoadDataFromFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadDataFromFile.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btn_LoadDataFromFile.ForeColor = System.Drawing.Color.Silver;
            this.btn_LoadDataFromFile.Location = new System.Drawing.Point(131, 557);
            this.btn_LoadDataFromFile.Margin = new System.Windows.Forms.Padding(28, 12, 3, 3);
            this.btn_LoadDataFromFile.Name = "btn_LoadDataFromFile";
            this.btn_LoadDataFromFile.Size = new System.Drawing.Size(85, 27);
            this.btn_LoadDataFromFile.TabIndex = 8;
            this.btn_LoadDataFromFile.Text = "Load Data";
            this.btn_LoadDataFromFile.UseVisualStyleBackColor = true;
            this.btn_LoadDataFromFile.Click += new System.EventHandler(this.btn_LoadDataFromFile_Click);
            // 
            // btn_Undo
            // 
            this.btn_Undo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Undo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Undo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btn_Undo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.btn_Undo.Image = ((System.Drawing.Image)(resources.GetObject("btn_Undo.Image")));
            this.btn_Undo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Undo.Location = new System.Drawing.Point(25, 597);
            this.btn_Undo.Margin = new System.Windows.Forms.Padding(25, 10, 3, 3);
            this.btn_Undo.Name = "btn_Undo";
            this.btn_Undo.Size = new System.Drawing.Size(79, 27);
            this.btn_Undo.TabIndex = 10;
            this.btn_Undo.Text = "   Undo";
            this.btn_Undo.UseVisualStyleBackColor = true;
            this.btn_Undo.Click += new System.EventHandler(this.btn_Undo_Click);
            // 
            // btn_Redo
            // 
            this.btn_Redo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Redo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Redo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btn_Redo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.btn_Redo.Image = ((System.Drawing.Image)(resources.GetObject("btn_Redo.Image")));
            this.btn_Redo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Redo.Location = new System.Drawing.Point(127, 597);
            this.btn_Redo.Margin = new System.Windows.Forms.Padding(20, 10, 3, 3);
            this.btn_Redo.Name = "btn_Redo";
            this.btn_Redo.Size = new System.Drawing.Size(79, 27);
            this.btn_Redo.TabIndex = 3;
            this.btn_Redo.Text = "   Redo";
            this.btn_Redo.UseVisualStyleBackColor = true;
            this.btn_Redo.Click += new System.EventHandler(this.btn_Redo_Click);
            // 
            // drawPanel
            // 
            this.drawPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawPanel.Location = new System.Drawing.Point(235, 0);
            this.drawPanel.MaximumSize = new System.Drawing.Size(962, 634);
            this.drawPanel.MinimumSize = new System.Drawing.Size(962, 634);
            this.drawPanel.Name = "drawPanel";
            this.drawPanel.Size = new System.Drawing.Size(962, 634);
            this.drawPanel.TabIndex = 1;
            this.drawPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.drawPanel_Paint);
            this.drawPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawPanel_MouseDown);
            this.drawPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawPanel_MouseMove);
            this.drawPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawPanel_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1197, 634);
            this.Controls.Add(this.drawPanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shapes Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.SideBar.ResumeLayout(false);
            this.SideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel SideBar;
        private System.Windows.Forms.Button buttonRectangle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonSquare;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonTriangle;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button buttonCircle;
        private System.Windows.Forms.ListBox shapeList;
        private System.Windows.Forms.Panel drawPanel;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_SaveDataToFile;
        private System.Windows.Forms.Button btn_LoadDataFromFile;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.Button btn_Guide;
        private System.Windows.Forms.Button btn_Redo;
        private System.Windows.Forms.Button btn_Undo;
    }
}

