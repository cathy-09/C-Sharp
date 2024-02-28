namespace Recursion_Tutorial
{
    partial class Factorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factorial));
            labelEnterN = new Label();
            buttonResultNFactorial = new Button();
            textBoxEnterN = new TextBox();
            labelTextFactorial = new Label();
            labelResultFactorial = new Label();
            buttonClearFact = new Button();
            SuspendLayout();
            // 
            // labelEnterN
            // 
            labelEnterN.AutoSize = true;
            labelEnterN.BackColor = Color.White;
            labelEnterN.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelEnterN.Location = new Point(12, 9);
            labelEnterN.Name = "labelEnterN";
            labelEnterN.Size = new Size(64, 19);
            labelEnterN.TabIndex = 0;
            labelEnterN.Text = "Enter n:";
            // 
            // buttonResultNFactorial
            // 
            buttonResultNFactorial.BackColor = Color.Thistle;
            buttonResultNFactorial.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonResultNFactorial.Location = new Point(328, 75);
            buttonResultNFactorial.Name = "buttonResultNFactorial";
            buttonResultNFactorial.Size = new Size(86, 28);
            buttonResultNFactorial.TabIndex = 1;
            buttonResultNFactorial.Text = "Result";
            buttonResultNFactorial.UseVisualStyleBackColor = false;
            buttonResultNFactorial.Click += buttonResultNFactorial_Click;
            // 
            // textBoxEnterN
            // 
            textBoxEnterN.BackColor = Color.White;
            textBoxEnterN.Location = new Point(12, 46);
            textBoxEnterN.Name = "textBoxEnterN";
            textBoxEnterN.Size = new Size(402, 23);
            textBoxEnterN.TabIndex = 2;
            textBoxEnterN.TextChanged += textBoxEnterN_TextChanged;
            // 
            // labelTextFactorial
            // 
            labelTextFactorial.AutoSize = true;
            labelTextFactorial.BackColor = Color.White;
            labelTextFactorial.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelTextFactorial.Location = new Point(12, 84);
            labelTextFactorial.Name = "labelTextFactorial";
            labelTextFactorial.Size = new Size(37, 19);
            labelTextFactorial.TabIndex = 3;
            labelTextFactorial.Text = "n! = ";
            labelTextFactorial.Click += labelTextFactorial_Click;
            // 
            // labelResultFactorial
            // 
            labelResultFactorial.AutoSize = true;
            labelResultFactorial.BackColor = Color.White;
            labelResultFactorial.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelResultFactorial.Location = new Point(55, 84);
            labelResultFactorial.Name = "labelResultFactorial";
            labelResultFactorial.Size = new Size(0, 19);
            labelResultFactorial.TabIndex = 4;
            labelResultFactorial.Click += labelResultFactorial_Click;
            // 
            // buttonClearFact
            // 
            buttonClearFact.BackColor = Color.Thistle;
            buttonClearFact.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonClearFact.Location = new Point(236, 75);
            buttonClearFact.Name = "buttonClearFact";
            buttonClearFact.Size = new Size(86, 28);
            buttonClearFact.TabIndex = 5;
            buttonClearFact.Text = "Clear";
            buttonClearFact.UseVisualStyleBackColor = false;
            buttonClearFact.Click += buttonClearFact_Click;
            // 
            // Factorial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(427, 112);
            Controls.Add(buttonClearFact);
            Controls.Add(labelResultFactorial);
            Controls.Add(labelTextFactorial);
            Controls.Add(textBoxEnterN);
            Controls.Add(buttonResultNFactorial);
            Controls.Add(labelEnterN);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Factorial";
            Text = "Factorial";
            Load += Factorial_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelEnterN;
        private Button buttonResultNFactorial;
        private TextBox textBoxEnterN;
        private Label labelTextFactorial;
        private Label labelResultFactorial;
        private Button buttonClearFact;
    }
}