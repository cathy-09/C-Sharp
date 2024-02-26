namespace Recursion_Tutorial
{
    partial class Minimum_element
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Minimum_element));
            buttonMinimumElementResult = new Button();
            labelArrayTextDoubleSequence = new Label();
            textBoxArraySequenceDouble = new TextBox();
            labelMinimumElement = new Label();
            labelResultMimimumElement = new Label();
            SuspendLayout();
            // 
            // buttonMinimumElementResult
            // 
            buttonMinimumElementResult.BackColor = Color.Thistle;
            buttonMinimumElementResult.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMinimumElementResult.Location = new Point(356, 71);
            buttonMinimumElementResult.Name = "buttonMinimumElementResult";
            buttonMinimumElementResult.Size = new Size(92, 28);
            buttonMinimumElementResult.TabIndex = 0;
            buttonMinimumElementResult.Text = "Result";
            buttonMinimumElementResult.UseVisualStyleBackColor = false;
            buttonMinimumElementResult.Click += buttonMinimumElementResult_Click;
            // 
            // labelArrayTextDoubleSequence
            // 
            labelArrayTextDoubleSequence.AutoSize = true;
            labelArrayTextDoubleSequence.BackColor = Color.White;
            labelArrayTextDoubleSequence.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelArrayTextDoubleSequence.Location = new Point(12, 9);
            labelArrayTextDoubleSequence.Name = "labelArrayTextDoubleSequence";
            labelArrayTextDoubleSequence.Size = new Size(124, 19);
            labelArrayTextDoubleSequence.TabIndex = 1;
            labelArrayTextDoubleSequence.Text = "Array sequence: ";
            // 
            // textBoxArraySequenceDouble
            // 
            textBoxArraySequenceDouble.Location = new Point(12, 42);
            textBoxArraySequenceDouble.Name = "textBoxArraySequenceDouble";
            textBoxArraySequenceDouble.Size = new Size(436, 23);
            textBoxArraySequenceDouble.TabIndex = 2;
            // 
            // labelMinimumElement
            // 
            labelMinimumElement.AutoSize = true;
            labelMinimumElement.BackColor = Color.White;
            labelMinimumElement.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelMinimumElement.Location = new Point(12, 80);
            labelMinimumElement.Name = "labelMinimumElement";
            labelMinimumElement.Size = new Size(144, 19);
            labelMinimumElement.TabIndex = 3;
            labelMinimumElement.Text = "Minimum element: ";
            // 
            // labelResultMimimumElement
            // 
            labelResultMimimumElement.AutoSize = true;
            labelResultMimimumElement.BackColor = Color.White;
            labelResultMimimumElement.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelResultMimimumElement.Location = new Point(176, 80);
            labelResultMimimumElement.Name = "labelResultMimimumElement";
            labelResultMimimumElement.Size = new Size(0, 19);
            labelResultMimimumElement.TabIndex = 4;
            // 
            // Minimum_element
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(460, 110);
            Controls.Add(labelResultMimimumElement);
            Controls.Add(labelMinimumElement);
            Controls.Add(textBoxArraySequenceDouble);
            Controls.Add(labelArrayTextDoubleSequence);
            Controls.Add(buttonMinimumElementResult);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Minimum_element";
            Text = "Minimum_element";
            Load += Minimum_element_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonMinimumElementResult;
        private Label labelArrayTextDoubleSequence;
        private TextBox textBoxArraySequenceDouble;
        private Label labelMinimumElement;
        private Label labelResultMimimumElement;
    }
}