namespace OOP_shapes
{
    partial class MainScreen
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
            this.addCircleBtn = new System.Windows.Forms.Button();
            this.colourGroupBox = new System.Windows.Forms.GroupBox();
            this.yellowSelected = new System.Windows.Forms.RadioButton();
            this.blueSelected = new System.Windows.Forms.RadioButton();
            this.redSelected = new System.Windows.Forms.RadioButton();
            this.shapenamesCombo = new System.Windows.Forms.ComboBox();
            this.addRectangleBtn = new System.Windows.Forms.Button();
            this.addTriangleBtn = new System.Windows.Forms.Button();
            this.moveUpBtn = new System.Windows.Forms.Button();
            this.moveDownBtn = new System.Windows.Forms.Button();
            this.moveLeftBtn = new System.Windows.Forms.Button();
            this.moveRightBtn = new System.Windows.Forms.Button();
            this.visibleCheck = new System.Windows.Forms.CheckBox();
            this.moveHorzBtn = new System.Windows.Forms.Button();
            this.moveVertBtn = new System.Windows.Forms.Button();
            this.resizeBtn = new System.Windows.Forms.Button();
            this.colourGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addCircleBtn
            // 
            this.addCircleBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addCircleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCircleBtn.Location = new System.Drawing.Point(785, 181);
            this.addCircleBtn.Name = "addCircleBtn";
            this.addCircleBtn.Size = new System.Drawing.Size(132, 33);
            this.addCircleBtn.TabIndex = 0;
            this.addCircleBtn.Text = "Add circle";
            this.addCircleBtn.UseVisualStyleBackColor = true;
            this.addCircleBtn.Click += new System.EventHandler(this.addCircleBtn_Click);
            // 
            // colourGroupBox
            // 
            this.colourGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colourGroupBox.Controls.Add(this.yellowSelected);
            this.colourGroupBox.Controls.Add(this.blueSelected);
            this.colourGroupBox.Controls.Add(this.redSelected);
            this.colourGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colourGroupBox.Location = new System.Drawing.Point(785, 12);
            this.colourGroupBox.Name = "colourGroupBox";
            this.colourGroupBox.Size = new System.Drawing.Size(132, 163);
            this.colourGroupBox.TabIndex = 1;
            this.colourGroupBox.TabStop = false;
            this.colourGroupBox.Text = "Colour";
            // 
            // yellowSelected
            // 
            this.yellowSelected.AutoSize = true;
            this.yellowSelected.Location = new System.Drawing.Point(7, 120);
            this.yellowSelected.Name = "yellowSelected";
            this.yellowSelected.Size = new System.Drawing.Size(73, 24);
            this.yellowSelected.TabIndex = 2;
            this.yellowSelected.TabStop = true;
            this.yellowSelected.Text = "Yellow";
            this.yellowSelected.UseVisualStyleBackColor = true;
            // 
            // blueSelected
            // 
            this.blueSelected.AutoSize = true;
            this.blueSelected.Location = new System.Drawing.Point(7, 78);
            this.blueSelected.Name = "blueSelected";
            this.blueSelected.Size = new System.Drawing.Size(59, 24);
            this.blueSelected.TabIndex = 1;
            this.blueSelected.TabStop = true;
            this.blueSelected.Text = "Blue";
            this.blueSelected.UseVisualStyleBackColor = true;
            // 
            // redSelected
            // 
            this.redSelected.AutoSize = true;
            this.redSelected.Checked = true;
            this.redSelected.Location = new System.Drawing.Point(7, 36);
            this.redSelected.Name = "redSelected";
            this.redSelected.Size = new System.Drawing.Size(57, 24);
            this.redSelected.TabIndex = 0;
            this.redSelected.TabStop = true;
            this.redSelected.Text = "Red";
            this.redSelected.UseVisualStyleBackColor = true;
            // 
            // shapenamesCombo
            // 
            this.shapenamesCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.shapenamesCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shapenamesCombo.FormattingEnabled = true;
            this.shapenamesCombo.Location = new System.Drawing.Point(12, 559);
            this.shapenamesCombo.Name = "shapenamesCombo";
            this.shapenamesCombo.Size = new System.Drawing.Size(210, 28);
            this.shapenamesCombo.TabIndex = 2;
            this.shapenamesCombo.SelectedIndexChanged += new System.EventHandler(this.shapenamesCombo_SelectedIndexChanged);
            // 
            // addRectangleBtn
            // 
            this.addRectangleBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addRectangleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRectangleBtn.Location = new System.Drawing.Point(785, 259);
            this.addRectangleBtn.Name = "addRectangleBtn";
            this.addRectangleBtn.Size = new System.Drawing.Size(132, 33);
            this.addRectangleBtn.TabIndex = 3;
            this.addRectangleBtn.Text = "Add rectangle";
            this.addRectangleBtn.UseVisualStyleBackColor = true;
            this.addRectangleBtn.Click += new System.EventHandler(this.addRectangleBtn_Click);
            // 
            // addTriangleBtn
            // 
            this.addTriangleBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addTriangleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTriangleBtn.Location = new System.Drawing.Point(785, 220);
            this.addTriangleBtn.Name = "addTriangleBtn";
            this.addTriangleBtn.Size = new System.Drawing.Size(132, 33);
            this.addTriangleBtn.TabIndex = 4;
            this.addTriangleBtn.Text = "Add triangle";
            this.addTriangleBtn.UseVisualStyleBackColor = true;
            this.addTriangleBtn.Click += new System.EventHandler(this.addTriangleBtn_Click);
            // 
            // moveUpBtn
            // 
            this.moveUpBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.moveUpBtn.Image = global::OOP_shapes.Properties.Resources.Up;
            this.moveUpBtn.Location = new System.Drawing.Point(277, 520);
            this.moveUpBtn.Name = "moveUpBtn";
            this.moveUpBtn.Size = new System.Drawing.Size(38, 35);
            this.moveUpBtn.TabIndex = 5;
            this.moveUpBtn.UseVisualStyleBackColor = true;
            this.moveUpBtn.Click += new System.EventHandler(this.moveUpBtn_Click);
            // 
            // moveDownBtn
            // 
            this.moveDownBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.moveDownBtn.Image = global::OOP_shapes.Properties.Resources.Down;
            this.moveDownBtn.Location = new System.Drawing.Point(277, 592);
            this.moveDownBtn.Name = "moveDownBtn";
            this.moveDownBtn.Size = new System.Drawing.Size(38, 35);
            this.moveDownBtn.TabIndex = 6;
            this.moveDownBtn.UseVisualStyleBackColor = true;
            this.moveDownBtn.Click += new System.EventHandler(this.moveDownBtn_Click);
            // 
            // moveLeftBtn
            // 
            this.moveLeftBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.moveLeftBtn.Image = global::OOP_shapes.Properties.Resources.Left;
            this.moveLeftBtn.Location = new System.Drawing.Point(237, 556);
            this.moveLeftBtn.Name = "moveLeftBtn";
            this.moveLeftBtn.Size = new System.Drawing.Size(38, 35);
            this.moveLeftBtn.TabIndex = 7;
            this.moveLeftBtn.UseVisualStyleBackColor = true;
            this.moveLeftBtn.Click += new System.EventHandler(this.moveLeftBtn_Click);
            // 
            // moveRightBtn
            // 
            this.moveRightBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.moveRightBtn.Image = global::OOP_shapes.Properties.Resources.Right;
            this.moveRightBtn.Location = new System.Drawing.Point(316, 556);
            this.moveRightBtn.Name = "moveRightBtn";
            this.moveRightBtn.Size = new System.Drawing.Size(38, 35);
            this.moveRightBtn.TabIndex = 8;
            this.moveRightBtn.UseVisualStyleBackColor = true;
            this.moveRightBtn.Click += new System.EventHandler(this.moveRightBtn_Click);
            // 
            // visibleCheck
            // 
            this.visibleCheck.AutoSize = true;
            this.visibleCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visibleCheck.Location = new System.Drawing.Point(82, 593);
            this.visibleCheck.Name = "visibleCheck";
            this.visibleCheck.Size = new System.Drawing.Size(74, 24);
            this.visibleCheck.TabIndex = 10;
            this.visibleCheck.Text = "Visible";
            this.visibleCheck.UseVisualStyleBackColor = true;
            this.visibleCheck.CheckedChanged += new System.EventHandler(this.visibleCheck_CheckedChanged);
            // 
            // moveHorzBtn
            // 
            this.moveHorzBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.moveHorzBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveHorzBtn.Location = new System.Drawing.Point(384, 524);
            this.moveHorzBtn.Name = "moveHorzBtn";
            this.moveHorzBtn.Size = new System.Drawing.Size(149, 31);
            this.moveHorzBtn.TabIndex = 11;
            this.moveHorzBtn.Text = "Move horizontally";
            this.moveHorzBtn.UseVisualStyleBackColor = true;
            this.moveHorzBtn.Click += new System.EventHandler(this.moveHorzBtn_Click);
            // 
            // moveVertBtn
            // 
            this.moveVertBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.moveVertBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveVertBtn.Location = new System.Drawing.Point(384, 561);
            this.moveVertBtn.Name = "moveVertBtn";
            this.moveVertBtn.Size = new System.Drawing.Size(149, 31);
            this.moveVertBtn.TabIndex = 12;
            this.moveVertBtn.Text = "Move vertically";
            this.moveVertBtn.UseVisualStyleBackColor = true;
            this.moveVertBtn.Click += new System.EventHandler(this.moveVertBtn_Click);
            // 
            // resizeBtn
            // 
            this.resizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.resizeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resizeBtn.Location = new System.Drawing.Point(384, 598);
            this.resizeBtn.Name = "resizeBtn";
            this.resizeBtn.Size = new System.Drawing.Size(149, 31);
            this.resizeBtn.TabIndex = 13;
            this.resizeBtn.Text = "Resize";
            this.resizeBtn.UseVisualStyleBackColor = true;
            this.resizeBtn.Click += new System.EventHandler(this.resizeBtn_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 635);
            this.Controls.Add(this.resizeBtn);
            this.Controls.Add(this.moveVertBtn);
            this.Controls.Add(this.moveHorzBtn);
            this.Controls.Add(this.visibleCheck);
            this.Controls.Add(this.moveRightBtn);
            this.Controls.Add(this.moveLeftBtn);
            this.Controls.Add(this.moveDownBtn);
            this.Controls.Add(this.moveUpBtn);
            this.Controls.Add(this.addTriangleBtn);
            this.Controls.Add(this.addRectangleBtn);
            this.Controls.Add(this.shapenamesCombo);
            this.Controls.Add(this.colourGroupBox);
            this.Controls.Add(this.addCircleBtn);
            this.Name = "MainScreen";
            this.Text = "OOP Shapes";
            this.Activated += new System.EventHandler(this.MainScreen_Activated);
            this.Resize += new System.EventHandler(this.MainScreen_Resize);
            this.colourGroupBox.ResumeLayout(false);
            this.colourGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addCircleBtn;
        private System.Windows.Forms.GroupBox colourGroupBox;
        private System.Windows.Forms.RadioButton yellowSelected;
        private System.Windows.Forms.RadioButton blueSelected;
        private System.Windows.Forms.RadioButton redSelected;
        private System.Windows.Forms.ComboBox shapenamesCombo;
        private System.Windows.Forms.Button addRectangleBtn;
        private System.Windows.Forms.Button addTriangleBtn;
        private System.Windows.Forms.Button moveUpBtn;
        private System.Windows.Forms.Button moveDownBtn;
        private System.Windows.Forms.Button moveLeftBtn;
        private System.Windows.Forms.Button moveRightBtn;
        private System.Windows.Forms.CheckBox visibleCheck;
        private System.Windows.Forms.Button moveHorzBtn;
        private System.Windows.Forms.Button moveVertBtn;
        private System.Windows.Forms.Button resizeBtn;
    }
}

