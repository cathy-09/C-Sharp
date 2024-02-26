namespace Recursion_Tutorial
{
    partial class Sum_of_the_Mathematical_Series
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
            labelMathSeries = new Label();
            label2 = new Label();
            labelSumMathSeries = new Label();
            buttonMathSeries = new Button();
            labelXText = new Label();
            labelNText = new Label();
            textBoxXForSeries = new TextBox();
            textBoxNForSeries = new TextBox();
            SuspendLayout();
            // 
            // labelMathSeries
            // 
            labelMathSeries.AutoSize = true;
            labelMathSeries.BackColor = Color.White;
            labelMathSeries.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelMathSeries.Location = new Point(12, 9);
            labelMathSeries.Name = "labelMathSeries";
            labelMathSeries.Size = new Size(439, 19);
            labelMathSeries.TabIndex = 0;
            labelMathSeries.Text = "Sum of the Mathematical Series: 1+х^1+х^2+х^3+х^4+ . . . +х^n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 105);
            label2.Name = "label2";
            label2.Size = new Size(46, 19);
            label2.TabIndex = 1;
            label2.Text = "Sum:";
            label2.Click += label2_Click;
            // 
            // labelSumMathSeries
            // 
            labelSumMathSeries.AutoSize = true;
            labelSumMathSeries.BackColor = Color.White;
            labelSumMathSeries.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelSumMathSeries.Location = new Point(74, 105);
            labelSumMathSeries.Name = "labelSumMathSeries";
            labelSumMathSeries.Size = new Size(0, 19);
            labelSumMathSeries.TabIndex = 2;
            // 
            // buttonMathSeries
            // 
            buttonMathSeries.BackColor = Color.Thistle;
            buttonMathSeries.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMathSeries.Location = new Point(374, 101);
            buttonMathSeries.Name = "buttonMathSeries";
            buttonMathSeries.Size = new Size(77, 32);
            buttonMathSeries.TabIndex = 3;
            buttonMathSeries.Text = "Result";
            buttonMathSeries.UseVisualStyleBackColor = false;
            buttonMathSeries.Click += buttonMathSeries_Click;
            // 
            // labelXText
            // 
            labelXText.AutoSize = true;
            labelXText.BackColor = Color.White;
            labelXText.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelXText.Location = new Point(12, 44);
            labelXText.Name = "labelXText";
            labelXText.Size = new Size(64, 19);
            labelXText.TabIndex = 4;
            labelXText.Text = "Enter X:";
            // 
            // labelNText
            // 
            labelNText.AutoSize = true;
            labelNText.BackColor = Color.White;
            labelNText.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelNText.Location = new Point(12, 75);
            labelNText.Name = "labelNText";
            labelNText.Size = new Size(67, 19);
            labelNText.TabIndex = 5;
            labelNText.Text = "Enter N:";
            // 
            // textBoxXForSeries
            // 
            textBoxXForSeries.Location = new Point(82, 40);
            textBoxXForSeries.Name = "textBoxXForSeries";
            textBoxXForSeries.Size = new Size(369, 23);
            textBoxXForSeries.TabIndex = 6;
            textBoxXForSeries.TextChanged += textBox1_TextChanged;
            // 
            // textBoxNForSeries
            // 
            textBoxNForSeries.Location = new Point(85, 75);
            textBoxNForSeries.Name = "textBoxNForSeries";
            textBoxNForSeries.Size = new Size(366, 23);
            textBoxNForSeries.TabIndex = 7;
            textBoxNForSeries.TextChanged += textBox2_TextChanged;
            // 
            // Sum_of_the_Mathematical_Series
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(463, 140);
            Controls.Add(textBoxNForSeries);
            Controls.Add(textBoxXForSeries);
            Controls.Add(labelNText);
            Controls.Add(labelXText);
            Controls.Add(buttonMathSeries);
            Controls.Add(labelSumMathSeries);
            Controls.Add(label2);
            Controls.Add(labelMathSeries);
            Name = "Sum_of_the_Mathematical_Series";
            Text = "Sum_of_the_Mathematical_Series";
            Load += Sum_of_the_Mathematical_Series_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMathSeries;
        private Label label2;
        private Label labelSumMathSeries;
        private Button buttonMathSeries;
        private Label labelXText;
        private Label labelNText;
        private TextBox textBoxXForSeries;
        private TextBox textBoxNForSeries;
    }
}