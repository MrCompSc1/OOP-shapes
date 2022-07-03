namespace OOP_shapes
{
    partial class VertPrompt
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
            this.descriptionLbl = new System.Windows.Forms.Label();
            this.methodLbl = new System.Windows.Forms.Label();
            this.methodEndLbl = new System.Windows.Forms.Label();
            this.shapeLbl = new System.Windows.Forms.Label();
            this.moveAmountBox = new System.Windows.Forms.TextBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLbl.Location = new System.Drawing.Point(21, 19);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.Size = new System.Drawing.Size(378, 49);
            this.descriptionLbl.TabIndex = 0;
            this.descriptionLbl.Text = "This moves the selected shape vertically using a method and a parameter value you" +
    " specify.";
            // 
            // methodLbl
            // 
            this.methodLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.methodLbl.Location = new System.Drawing.Point(102, 84);
            this.methodLbl.Name = "methodLbl";
            this.methodLbl.Size = new System.Drawing.Size(149, 28);
            this.methodLbl.TabIndex = 1;
            this.methodLbl.Text = ". MoveVertically(";
            // 
            // methodEndLbl
            // 
            this.methodEndLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.methodEndLbl.Location = new System.Drawing.Point(380, 84);
            this.methodEndLbl.Name = "methodEndLbl";
            this.methodEndLbl.Size = new System.Drawing.Size(36, 28);
            this.methodEndLbl.TabIndex = 2;
            this.methodEndLbl.Text = ")";
            // 
            // shapeLbl
            // 
            this.shapeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shapeLbl.Location = new System.Drawing.Point(15, 84);
            this.shapeLbl.Name = "shapeLbl";
            this.shapeLbl.Size = new System.Drawing.Size(93, 28);
            this.shapeLbl.TabIndex = 3;
            this.shapeLbl.Text = "shape1";
            this.shapeLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // moveAmountBox
            // 
            this.moveAmountBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveAmountBox.Location = new System.Drawing.Point(246, 81);
            this.moveAmountBox.Name = "moveAmountBox";
            this.moveAmountBox.Size = new System.Drawing.Size(130, 26);
            this.moveAmountBox.TabIndex = 4;
            // 
            // okBtn
            // 
            this.okBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okBtn.Location = new System.Drawing.Point(83, 136);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(110, 31);
            this.okBtn.TabIndex = 5;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(223, 136);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(110, 31);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // VertPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 193);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.moveAmountBox);
            this.Controls.Add(this.shapeLbl);
            this.Controls.Add(this.methodEndLbl);
            this.Controls.Add(this.methodLbl);
            this.Controls.Add(this.descriptionLbl);
            this.Name = "VertPrompt";
            this.Text = "Move shape horizontally";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label descriptionLbl;
        private System.Windows.Forms.Label methodLbl;
        private System.Windows.Forms.Label methodEndLbl;
        private System.Windows.Forms.Label shapeLbl;
        private System.Windows.Forms.TextBox moveAmountBox;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}