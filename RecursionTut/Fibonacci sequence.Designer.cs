namespace Recursion_Tutorial
{
    partial class Fibonacci_sequence
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fibonacci_sequence));
            labeEnterN = new Label();
            labelResultFibonacciSequence = new Label();
            textBoxEnterN = new TextBox();
            labelOutputResultFibonacciSequence = new Label();
            buttonResultFibSequ = new Button();
            buttonClearFib = new Button();
            SuspendLayout();
            // 
            // labeEnterN
            // 
            labeEnterN.AutoSize = true;
            labeEnterN.BackColor = Color.White;
            labeEnterN.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labeEnterN.Location = new Point(16, 9);
            labeEnterN.Name = "labeEnterN";
            labeEnterN.Size = new Size(264, 19);
            labeEnterN.TabIndex = 0;
            labeEnterN.Text = "n-th Term of The Fibonacci Sequence:";
            // 
            // labelResultFibonacciSequence
            // 
            labelResultFibonacciSequence.AutoSize = true;
            labelResultFibonacciSequence.BackColor = Color.White;
            labelResultFibonacciSequence.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelResultFibonacciSequence.Location = new Point(16, 74);
            labelResultFibonacciSequence.Name = "labelResultFibonacciSequence";
            labelResultFibonacciSequence.Size = new Size(58, 19);
            labelResultFibonacciSequence.TabIndex = 1;
            labelResultFibonacciSequence.Text = "Result:";
            // 
            // textBoxEnterN
            // 
            textBoxEnterN.Location = new Point(16, 37);
            textBoxEnterN.Name = "textBoxEnterN";
            textBoxEnterN.Size = new Size(406, 23);
            textBoxEnterN.TabIndex = 2;
            // 
            // labelOutputResultFibonacciSequence
            // 
            labelOutputResultFibonacciSequence.AutoSize = true;
            labelOutputResultFibonacciSequence.BackColor = Color.White;
            labelOutputResultFibonacciSequence.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelOutputResultFibonacciSequence.Location = new Point(86, 74);
            labelOutputResultFibonacciSequence.Name = "labelOutputResultFibonacciSequence";
            labelOutputResultFibonacciSequence.Size = new Size(0, 19);
            labelOutputResultFibonacciSequence.TabIndex = 3;
            // 
            // buttonResultFibSequ
            // 
            buttonResultFibSequ.BackColor = Color.Thistle;
            buttonResultFibSequ.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonResultFibSequ.Location = new Point(335, 66);
            buttonResultFibSequ.Name = "buttonResultFibSequ";
            buttonResultFibSequ.Size = new Size(87, 33);
            buttonResultFibSequ.TabIndex = 4;
            buttonResultFibSequ.Text = "Result";
            buttonResultFibSequ.UseVisualStyleBackColor = false;
            buttonResultFibSequ.Click += buttonResultFibSequ_Click;
            // 
            // buttonClearFib
            // 
            buttonClearFib.BackColor = Color.Thistle;
            buttonClearFib.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonClearFib.Location = new Point(243, 66);
            buttonClearFib.Name = "buttonClearFib";
            buttonClearFib.Size = new Size(86, 32);
            buttonClearFib.TabIndex = 5;
            buttonClearFib.Text = "Clear";
            buttonClearFib.UseVisualStyleBackColor = false;
            buttonClearFib.Click += buttonClearFib_Click;
            // 
            // Fibonacci_sequence
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(434, 105);
            Controls.Add(buttonClearFib);
            Controls.Add(buttonResultFibSequ);
            Controls.Add(labelOutputResultFibonacciSequence);
            Controls.Add(textBoxEnterN);
            Controls.Add(labelResultFibonacciSequence);
            Controls.Add(labeEnterN);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Fibonacci_sequence";
            Text = "Fibonacci_sequence";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labeEnterN;
        private Label labelResultFibonacciSequence;
        private TextBox textBoxEnterN;
        private Label labelOutputResultFibonacciSequence;
        private Button buttonResultFibSequ;
        private Button buttonClearFib;
    }
}