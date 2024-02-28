namespace Recursion_Tutorial
{
    partial class Binomial_coefficients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Binomial_coefficients));
            labelTextInfo = new Label();
            labelN = new Label();
            labelK = new Label();
            labelResultTextBinomialCoefficient = new Label();
            labelResultBinomialCoefficient = new Label();
            textBoxN = new TextBox();
            textBoxK = new TextBox();
            buttonResultBinomialCoefficient = new Button();
            buttonClearBinom = new Button();
            SuspendLayout();
            // 
            // labelTextInfo
            // 
            labelTextInfo.AutoSize = true;
            labelTextInfo.BackColor = Color.White;
            labelTextInfo.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelTextInfo.Location = new Point(12, 9);
            labelTextInfo.Name = "labelTextInfo";
            labelTextInfo.Size = new Size(539, 38);
            labelTextInfo.TabIndex = 0;
            labelTextInfo.Text = "Info: The binomial coefficient of the natural numbers k and n is the number of \r\nall possible k-element subsets of a given n-element set.";
            // 
            // labelN
            // 
            labelN.AutoSize = true;
            labelN.BackColor = Color.White;
            labelN.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelN.Location = new Point(12, 61);
            labelN.Name = "labelN";
            labelN.Size = new Size(64, 19);
            labelN.TabIndex = 1;
            labelN.Text = "Enter n:";
            labelN.Click += label2_Click;
            // 
            // labelK
            // 
            labelK.AutoSize = true;
            labelK.BackColor = Color.White;
            labelK.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelK.Location = new Point(12, 92);
            labelK.Name = "labelK";
            labelK.Size = new Size(63, 19);
            labelK.TabIndex = 2;
            labelK.Text = "Enter k:";
            // 
            // labelResultTextBinomialCoefficient
            // 
            labelResultTextBinomialCoefficient.AutoSize = true;
            labelResultTextBinomialCoefficient.BackColor = Color.White;
            labelResultTextBinomialCoefficient.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelResultTextBinomialCoefficient.Location = new Point(12, 129);
            labelResultTextBinomialCoefficient.Name = "labelResultTextBinomialCoefficient";
            labelResultTextBinomialCoefficient.Size = new Size(152, 19);
            labelResultTextBinomialCoefficient.TabIndex = 3;
            labelResultTextBinomialCoefficient.Text = "Binomial Coefficient:";
            labelResultTextBinomialCoefficient.Click += labelResultTextBinomialCoefficient_Click;
            // 
            // labelResultBinomialCoefficient
            // 
            labelResultBinomialCoefficient.AutoSize = true;
            labelResultBinomialCoefficient.BackColor = Color.White;
            labelResultBinomialCoefficient.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelResultBinomialCoefficient.Location = new Point(180, 129);
            labelResultBinomialCoefficient.Name = "labelResultBinomialCoefficient";
            labelResultBinomialCoefficient.Size = new Size(0, 19);
            labelResultBinomialCoefficient.TabIndex = 4;
            labelResultBinomialCoefficient.Click += labelResultBinomialCoefficient_Click;
            // 
            // textBoxN
            // 
            textBoxN.Location = new Point(86, 61);
            textBoxN.Name = "textBoxN";
            textBoxN.Size = new Size(465, 23);
            textBoxN.TabIndex = 5;
            // 
            // textBoxK
            // 
            textBoxK.Location = new Point(86, 92);
            textBoxK.Name = "textBoxK";
            textBoxK.Size = new Size(465, 23);
            textBoxK.TabIndex = 6;
            textBoxK.TextChanged += textBox2_TextChanged;
            // 
            // buttonResultBinomialCoefficient
            // 
            buttonResultBinomialCoefficient.BackColor = Color.Thistle;
            buttonResultBinomialCoefficient.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonResultBinomialCoefficient.Location = new Point(466, 122);
            buttonResultBinomialCoefficient.Name = "buttonResultBinomialCoefficient";
            buttonResultBinomialCoefficient.Size = new Size(85, 26);
            buttonResultBinomialCoefficient.TabIndex = 7;
            buttonResultBinomialCoefficient.Text = "Result";
            buttonResultBinomialCoefficient.UseVisualStyleBackColor = false;
            buttonResultBinomialCoefficient.Click += buttonResultBinomialCoefficient_Click;
            // 
            // buttonClearBinom
            // 
            buttonClearBinom.BackColor = Color.Thistle;
            buttonClearBinom.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonClearBinom.Location = new Point(377, 123);
            buttonClearBinom.Name = "buttonClearBinom";
            buttonClearBinom.Size = new Size(83, 26);
            buttonClearBinom.TabIndex = 8;
            buttonClearBinom.Text = "Clear";
            buttonClearBinom.UseVisualStyleBackColor = false;
            buttonClearBinom.Click += buttonClearBinom_Click;
            // 
            // Binomial_coefficients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(561, 157);
            Controls.Add(buttonClearBinom);
            Controls.Add(buttonResultBinomialCoefficient);
            Controls.Add(textBoxK);
            Controls.Add(textBoxN);
            Controls.Add(labelResultBinomialCoefficient);
            Controls.Add(labelResultTextBinomialCoefficient);
            Controls.Add(labelK);
            Controls.Add(labelN);
            Controls.Add(labelTextInfo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Binomial_coefficients";
            Text = "Binomial_coefficients";
            Load += Binomial_coefficients_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTextInfo;
        private Label labelN;
        private Label labelK;
        private Label labelResultTextBinomialCoefficient;
        private Label labelResultBinomialCoefficient;
        private TextBox textBoxN;
        private TextBox textBoxK;
        private Button buttonResultBinomialCoefficient;
        private Button buttonClearBinom;
    }
}