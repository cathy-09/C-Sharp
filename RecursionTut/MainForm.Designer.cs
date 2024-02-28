namespace Recursion_Tutorial
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            labelWelcomeGreeting = new Label();
            labelDocumentationText = new Label();
            buttonConnectToFile = new Button();
            listBoxInfoFromTxt = new ListBox();
            buttonFibonacciSequence = new Button();
            buttonFactorial = new Button();
            buttonSumArray = new Button();
            buttonBinomialCoefficients = new Button();
            buttonMinimum = new Button();
            buttonDecimalToBinary = new Button();
            buttonSumMathSeries = new Button();
            openFileDialog1 = new OpenFileDialog();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // labelWelcomeGreeting
            // 
            labelWelcomeGreeting.AutoSize = true;
            labelWelcomeGreeting.BackColor = Color.White;
            labelWelcomeGreeting.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelWelcomeGreeting.Location = new Point(12, 9);
            labelWelcomeGreeting.Name = "labelWelcomeGreeting";
            labelWelcomeGreeting.Size = new Size(637, 78);
            labelWelcomeGreeting.TabIndex = 0;
            labelWelcomeGreeting.Text = "Welcome to your all-in-one app for calculating more complex algorithms. \r\nPlease visit the documentation link to view \r\nthe \"User Guide subtopic\".";
            labelWelcomeGreeting.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelDocumentationText
            // 
            labelDocumentationText.AutoSize = true;
            labelDocumentationText.Font = new Font("Corbel", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            labelDocumentationText.ForeColor = Color.Blue;
            labelDocumentationText.Location = new Point(476, 275);
            labelDocumentationText.Name = "labelDocumentationText";
            labelDocumentationText.Size = new Size(44, 19);
            labelDocumentationText.TabIndex = 1;
            labelDocumentationText.Text = "Link:";
            // 
            // buttonConnectToFile
            // 
            buttonConnectToFile.BackColor = Color.White;
            buttonConnectToFile.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonConnectToFile.Location = new Point(526, 269);
            buttonConnectToFile.Name = "buttonConnectToFile";
            buttonConnectToFile.Size = new Size(125, 30);
            buttonConnectToFile.TabIndex = 2;
            buttonConnectToFile.Text = "Click";
            buttonConnectToFile.UseVisualStyleBackColor = false;
            buttonConnectToFile.Click += buttonConnectToFile_Click;
            // 
            // listBoxInfoFromTxt
            // 
            listBoxInfoFromTxt.FormattingEnabled = true;
            listBoxInfoFromTxt.ItemHeight = 15;
            listBoxInfoFromTxt.Location = new Point(12, 343);
            listBoxInfoFromTxt.Name = "listBoxInfoFromTxt";
            listBoxInfoFromTxt.Size = new Size(637, 79);
            listBoxInfoFromTxt.TabIndex = 3;
            listBoxInfoFromTxt.Visible = false;
            // 
            // buttonFibonacciSequence
            // 
            buttonFibonacciSequence.BackColor = Color.Thistle;
            buttonFibonacciSequence.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFibonacciSequence.Location = new Point(12, 101);
            buttonFibonacciSequence.Name = "buttonFibonacciSequence";
            buttonFibonacciSequence.Size = new Size(149, 76);
            buttonFibonacciSequence.TabIndex = 4;
            buttonFibonacciSequence.Text = "Fibonacci \r\nsequence";
            buttonFibonacciSequence.UseVisualStyleBackColor = false;
            buttonFibonacciSequence.Click += buttonFibonacciSequence_Click;
            // 
            // buttonFactorial
            // 
            buttonFactorial.BackColor = Color.Thistle;
            buttonFactorial.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFactorial.Location = new Point(177, 101);
            buttonFactorial.Name = "buttonFactorial";
            buttonFactorial.Size = new Size(149, 76);
            buttonFactorial.TabIndex = 5;
            buttonFactorial.Text = "Factorial";
            buttonFactorial.UseVisualStyleBackColor = false;
            buttonFactorial.Click += buttonFactorial_Click;
            // 
            // buttonSumArray
            // 
            buttonSumArray.BackColor = Color.Thistle;
            buttonSumArray.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSumArray.Location = new Point(502, 101);
            buttonSumArray.Name = "buttonSumArray";
            buttonSumArray.Size = new Size(149, 76);
            buttonSumArray.TabIndex = 6;
            buttonSumArray.Text = "Sum of an array\r\nof integers";
            buttonSumArray.UseVisualStyleBackColor = false;
            buttonSumArray.Click += buttonSumArray_Click;
            // 
            // buttonBinomialCoefficients
            // 
            buttonBinomialCoefficients.BackColor = Color.Thistle;
            buttonBinomialCoefficients.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBinomialCoefficients.Location = new Point(341, 101);
            buttonBinomialCoefficients.Name = "buttonBinomialCoefficients";
            buttonBinomialCoefficients.Size = new Size(149, 76);
            buttonBinomialCoefficients.TabIndex = 7;
            buttonBinomialCoefficients.Text = "Binomial\r\ncoefficients";
            buttonBinomialCoefficients.UseVisualStyleBackColor = false;
            buttonBinomialCoefficients.Click += buttonBinomialCoefficients_Click;
            // 
            // buttonMinimum
            // 
            buttonMinimum.BackColor = Color.Thistle;
            buttonMinimum.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMinimum.Location = new Point(12, 183);
            buttonMinimum.Name = "buttonMinimum";
            buttonMinimum.Size = new Size(149, 76);
            buttonMinimum.TabIndex = 8;
            buttonMinimum.Text = "Minimum element \r\nof an array of\r\n floating-point \r\nnumbers";
            buttonMinimum.UseVisualStyleBackColor = false;
            buttonMinimum.Click += buttonMinimum_Click;
            // 
            // buttonDecimalToBinary
            // 
            buttonDecimalToBinary.BackColor = Color.Thistle;
            buttonDecimalToBinary.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDecimalToBinary.Location = new Point(177, 183);
            buttonDecimalToBinary.Name = "buttonDecimalToBinary";
            buttonDecimalToBinary.Size = new Size(149, 76);
            buttonDecimalToBinary.TabIndex = 9;
            buttonDecimalToBinary.Text = "Decimal to binary conversion";
            buttonDecimalToBinary.UseVisualStyleBackColor = false;
            buttonDecimalToBinary.Click += buttonDecimalToBinary_Click;
            // 
            // buttonSumMathSeries
            // 
            buttonSumMathSeries.AutoEllipsis = true;
            buttonSumMathSeries.BackColor = Color.Thistle;
            buttonSumMathSeries.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSumMathSeries.Location = new Point(341, 183);
            buttonSumMathSeries.Name = "buttonSumMathSeries";
            buttonSumMathSeries.Size = new Size(308, 76);
            buttonSumMathSeries.TabIndex = 10;
            buttonSumMathSeries.Text = "Sum of the Mathematical Series:\r\n1+х^1+х^2+х^3+х^4+ . . . +х^n";
            buttonSumMathSeries.UseVisualStyleBackColor = false;
            buttonSumMathSeries.Click += buttonSumMathSeries_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.White;
            buttonExit.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExit.Location = new Point(12, 305);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(637, 32);
            buttonExit.TabIndex = 11;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(663, 434);
            Controls.Add(buttonExit);
            Controls.Add(buttonSumMathSeries);
            Controls.Add(buttonDecimalToBinary);
            Controls.Add(buttonMinimum);
            Controls.Add(buttonBinomialCoefficients);
            Controls.Add(buttonSumArray);
            Controls.Add(buttonFactorial);
            Controls.Add(buttonFibonacciSequence);
            Controls.Add(listBoxInfoFromTxt);
            Controls.Add(buttonConnectToFile);
            Controls.Add(labelDocumentationText);
            Controls.Add(labelWelcomeGreeting);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Recursion Tutorial";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelWelcomeGreeting;
        private Label labelDocumentationText;
        private Button buttonConnectToFile;
        private ListBox listBoxInfoFromTxt;
        private Button buttonFibonacciSequence;
        private Button buttonFactorial;
        private Button buttonSumArray;
        private Button buttonBinomialCoefficients;
        private Button buttonMinimum;
        private Button buttonDecimalToBinary;
        private Button buttonSumMathSeries;
        private OpenFileDialog openFileDialog1;
        private Button buttonExit;
    }
}