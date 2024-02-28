namespace Recursion_Tutorial
{
    partial class Decimal_to_binary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Decimal_to_binary));
            labelTextDecimalToBinary = new Label();
            buttonBinaryResult = new Button();
            textBoxEnterDecimal = new TextBox();
            labelTextBinaryNumber = new Label();
            labelBinaryResult = new Label();
            buttonClearDecToBinary = new Button();
            SuspendLayout();
            // 
            // labelTextDecimalToBinary
            // 
            labelTextDecimalToBinary.AutoSize = true;
            labelTextDecimalToBinary.BackColor = Color.White;
            labelTextDecimalToBinary.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelTextDecimalToBinary.Location = new Point(13, 13);
            labelTextDecimalToBinary.Name = "labelTextDecimalToBinary";
            labelTextDecimalToBinary.Size = new Size(172, 19);
            labelTextDecimalToBinary.TabIndex = 0;
            labelTextDecimalToBinary.Text = "Enter Decimal Number:";
            // 
            // buttonBinaryResult
            // 
            buttonBinaryResult.BackColor = Color.Thistle;
            buttonBinaryResult.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBinaryResult.Location = new Point(442, 80);
            buttonBinaryResult.Name = "buttonBinaryResult";
            buttonBinaryResult.Size = new Size(88, 31);
            buttonBinaryResult.TabIndex = 1;
            buttonBinaryResult.Text = "Convert";
            buttonBinaryResult.UseVisualStyleBackColor = false;
            buttonBinaryResult.Click += buttonBinaryResult_Click;
            // 
            // textBoxEnterDecimal
            // 
            textBoxEnterDecimal.Location = new Point(13, 47);
            textBoxEnterDecimal.Name = "textBoxEnterDecimal";
            textBoxEnterDecimal.Size = new Size(517, 23);
            textBoxEnterDecimal.TabIndex = 2;
            textBoxEnterDecimal.TextChanged += textBox1_TextChanged;
            // 
            // labelTextBinaryNumber
            // 
            labelTextBinaryNumber.AutoSize = true;
            labelTextBinaryNumber.BackColor = Color.White;
            labelTextBinaryNumber.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelTextBinaryNumber.Location = new Point(13, 86);
            labelTextBinaryNumber.Name = "labelTextBinaryNumber";
            labelTextBinaryNumber.Size = new Size(117, 19);
            labelTextBinaryNumber.TabIndex = 3;
            labelTextBinaryNumber.Text = "Binary number:";
            labelTextBinaryNumber.Click += labelTextBinaryNumber_Click;
            // 
            // labelBinaryResult
            // 
            labelBinaryResult.AutoSize = true;
            labelBinaryResult.BackColor = Color.White;
            labelBinaryResult.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelBinaryResult.Location = new Point(155, 86);
            labelBinaryResult.Name = "labelBinaryResult";
            labelBinaryResult.Size = new Size(0, 19);
            labelBinaryResult.TabIndex = 4;
            labelBinaryResult.Click += labelBinaryResult_Click;
            // 
            // buttonClearDecToBinary
            // 
            buttonClearDecToBinary.BackColor = Color.Thistle;
            buttonClearDecToBinary.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonClearDecToBinary.Location = new Point(349, 80);
            buttonClearDecToBinary.Name = "buttonClearDecToBinary";
            buttonClearDecToBinary.Size = new Size(87, 31);
            buttonClearDecToBinary.TabIndex = 5;
            buttonClearDecToBinary.Text = "Clear";
            buttonClearDecToBinary.UseVisualStyleBackColor = false;
            buttonClearDecToBinary.Click += buttonClearDecToBinary_Click;
            // 
            // Decimal_to_binary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(542, 115);
            Controls.Add(buttonClearDecToBinary);
            Controls.Add(labelBinaryResult);
            Controls.Add(labelTextBinaryNumber);
            Controls.Add(textBoxEnterDecimal);
            Controls.Add(buttonBinaryResult);
            Controls.Add(labelTextDecimalToBinary);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Decimal_to_binary";
            Text = "Decimal_to_binary";
            Load += Decimal_to_binary_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTextDecimalToBinary;
        private Button buttonBinaryResult;
        private TextBox textBoxEnterDecimal;
        private Label labelTextBinaryNumber;
        private Label labelBinaryResult;
        private Button buttonClearDecToBinary;
    }
}