namespace Recursion_Tutorial
{
    partial class Sum_of_an_array_sequence
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sum_of_an_array_sequence));
            labelArraySequence = new Label();
            textBoxArraySequence = new TextBox();
            labelSumText = new Label();
            labelResultSum = new Label();
            buttonResultArraySequence = new Button();
            SuspendLayout();
            // 
            // labelArraySequence
            // 
            labelArraySequence.AutoSize = true;
            labelArraySequence.BackColor = Color.White;
            labelArraySequence.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelArraySequence.Location = new Point(23, 16);
            labelArraySequence.Name = "labelArraySequence";
            labelArraySequence.Size = new Size(124, 19);
            labelArraySequence.TabIndex = 0;
            labelArraySequence.Text = "Array sequence: ";
            labelArraySequence.Click += label1_Click;
            // 
            // textBoxArraySequence
            // 
            textBoxArraySequence.Location = new Point(23, 50);
            textBoxArraySequence.Name = "textBoxArraySequence";
            textBoxArraySequence.Size = new Size(441, 23);
            textBoxArraySequence.TabIndex = 1;
            textBoxArraySequence.TextChanged += textBoxArraySequence_TextChanged;
            // 
            // labelSumText
            // 
            labelSumText.AutoSize = true;
            labelSumText.BackColor = Color.White;
            labelSumText.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelSumText.Location = new Point(23, 93);
            labelSumText.Name = "labelSumText";
            labelSumText.Size = new Size(142, 19);
            labelSumText.TabIndex = 2;
            labelSumText.Text = "Sum of Sequence = ";
            labelSumText.Click += labelSumText_Click;
            // 
            // labelResultSum
            // 
            labelResultSum.AutoSize = true;
            labelResultSum.BackColor = Color.White;
            labelResultSum.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelResultSum.Location = new Point(186, 93);
            labelResultSum.Name = "labelResultSum";
            labelResultSum.Size = new Size(0, 19);
            labelResultSum.TabIndex = 3;
            // 
            // buttonResultArraySequence
            // 
            buttonResultArraySequence.BackColor = Color.Thistle;
            buttonResultArraySequence.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonResultArraySequence.Location = new Point(380, 88);
            buttonResultArraySequence.Name = "buttonResultArraySequence";
            buttonResultArraySequence.Size = new Size(84, 29);
            buttonResultArraySequence.TabIndex = 4;
            buttonResultArraySequence.Text = "Result";
            buttonResultArraySequence.UseVisualStyleBackColor = false;
            buttonResultArraySequence.Click += buttonResultArraySequence_Click;
            // 
            // Sum_of_an_array_sequence
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(477, 128);
            Controls.Add(buttonResultArraySequence);
            Controls.Add(labelResultSum);
            Controls.Add(labelSumText);
            Controls.Add(textBoxArraySequence);
            Controls.Add(labelArraySequence);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Sum_of_an_array_sequence";
            Text = "Sum_of_an_array_sequence";
            Load += Sum_of_an_array_sequence_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelArraySequence;
        private TextBox textBoxArraySequence;
        private Label labelSumText;
        private Label labelResultSum;
        private Button buttonResultArraySequence;
    }
}