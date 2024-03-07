namespace Average
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAverageGrade = new System.Windows.Forms.Button();
            this.labelAverage = new System.Windows.Forms.Label();
            this.textBoxResultAverage = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAverageGrade
            // 
            this.buttonAverageGrade.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonAverageGrade.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAverageGrade.Location = new System.Drawing.Point(26, 12);
            this.buttonAverageGrade.Name = "buttonAverageGrade";
            this.buttonAverageGrade.Size = new System.Drawing.Size(340, 44);
            this.buttonAverageGrade.TabIndex = 0;
            this.buttonAverageGrade.Text = "Изчисли среден успех";
            this.buttonAverageGrade.UseVisualStyleBackColor = false;
            this.buttonAverageGrade.Click += new System.EventHandler(this.buttonAverageGrade_Click);
            // 
            // labelAverage
            // 
            this.labelAverage.AutoSize = true;
            this.labelAverage.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAverage.Location = new System.Drawing.Point(262, 488);
            this.labelAverage.Name = "labelAverage";
            this.labelAverage.Size = new System.Drawing.Size(104, 18);
            this.labelAverage.TabIndex = 1;
            this.labelAverage.Text = "Среден успех:";
            // 
            // textBoxResultAverage
            // 
            this.textBoxResultAverage.BackColor = System.Drawing.Color.RosyBrown;
            this.textBoxResultAverage.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxResultAverage.ForeColor = System.Drawing.Color.Black;
            this.textBoxResultAverage.Location = new System.Drawing.Point(261, 509);
            this.textBoxResultAverage.Multiline = true;
            this.textBoxResultAverage.Name = "textBoxResultAverage";
            this.textBoxResultAverage.Size = new System.Drawing.Size(105, 36);
            this.textBoxResultAverage.TabIndex = 2;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonClear.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonClear.Location = new System.Drawing.Point(26, 488);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(229, 57);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Изчисти";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(398, 557);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textBoxResultAverage);
            this.Controls.Add(this.labelAverage);
            this.Controls.Add(this.buttonAverageGrade);
            this.Name = "Form1";
            this.Text = "Average";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonAverageGrade;
        private Label labelAverage;
        private TextBox textBoxResultAverage;
        private Button buttonClear;
    }
}