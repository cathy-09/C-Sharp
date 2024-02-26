namespace Arrays
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
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.textBoxQ = new System.Windows.Forms.TextBox();
            this.buttonOutput = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelP = new System.Windows.Forms.Label();
            this.labelQ = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelMinimum = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelMaximum = new System.Windows.Forms.Label();
            this.richTextBoxData = new System.Windows.Forms.RichTextBox();
            this.labelAverage = new System.Windows.Forms.Label();
            this.labelAverageResult = new System.Windows.Forms.Label();
            this.labelSort = new System.Windows.Forms.Label();
            this.labelSortResult = new System.Windows.Forms.Label();
            this.labelSum = new System.Windows.Forms.Label();
            this.labelSumResult = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelCountResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxP
            // 
            this.textBoxP.Location = new System.Drawing.Point(40, 17);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(100, 23);
            this.textBoxP.TabIndex = 1;
            // 
            // textBoxQ
            // 
            this.textBoxQ.Location = new System.Drawing.Point(40, 46);
            this.textBoxQ.Name = "textBoxQ";
            this.textBoxQ.Size = new System.Drawing.Size(100, 23);
            this.textBoxQ.TabIndex = 2;
            // 
            // buttonOutput
            // 
            this.buttonOutput.Location = new System.Drawing.Point(12, 88);
            this.buttonOutput.Name = "buttonOutput";
            this.buttonOutput.Size = new System.Drawing.Size(128, 23);
            this.buttonOutput.TabIndex = 3;
            this.buttonOutput.Text = "Изведи";
            this.buttonOutput.UseVisualStyleBackColor = true;
            this.buttonOutput.Click += new System.EventHandler(this.buttonOutput_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(12, 117);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(128, 21);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Изчисти";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelP
            // 
            this.labelP.AutoSize = true;
            this.labelP.Location = new System.Drawing.Point(12, 20);
            this.labelP.Name = "labelP";
            this.labelP.Size = new System.Drawing.Size(22, 15);
            this.labelP.TabIndex = 5;
            this.labelP.Text = "P=";
            // 
            // labelQ
            // 
            this.labelQ.AutoSize = true;
            this.labelQ.Location = new System.Drawing.Point(10, 49);
            this.labelQ.Name = "labelQ";
            this.labelQ.Size = new System.Drawing.Size(24, 15);
            this.labelQ.TabIndex = 6;
            this.labelQ.Text = "Q=";
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Location = new System.Drawing.Point(18, 150);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(129, 15);
            this.labelMin.TabIndex = 7;
            this.labelMin.Text = "Минимален елемент: ";
            // 
            // labelMinimum
            // 
            this.labelMinimum.AutoSize = true;
            this.labelMinimum.Location = new System.Drawing.Point(22, 167);
            this.labelMinimum.Name = "labelMinimum";
            this.labelMinimum.Size = new System.Drawing.Size(0, 15);
            this.labelMinimum.TabIndex = 8;
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(18, 182);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(130, 15);
            this.labelMax.TabIndex = 9;
            this.labelMax.Text = "Максимален елемент:";
            // 
            // labelMaximum
            // 
            this.labelMaximum.AutoSize = true;
            this.labelMaximum.Location = new System.Drawing.Point(23, 209);
            this.labelMaximum.Name = "labelMaximum";
            this.labelMaximum.Size = new System.Drawing.Size(0, 15);
            this.labelMaximum.TabIndex = 10;
            // 
            // richTextBoxData
            // 
            this.richTextBoxData.Location = new System.Drawing.Point(277, 7);
            this.richTextBoxData.Name = "richTextBoxData";
            this.richTextBoxData.Size = new System.Drawing.Size(117, 338);
            this.richTextBoxData.TabIndex = 11;
            this.richTextBoxData.Text = "";
            // 
            // labelAverage
            // 
            this.labelAverage.AutoSize = true;
            this.labelAverage.Location = new System.Drawing.Point(18, 224);
            this.labelAverage.Name = "labelAverage";
            this.labelAverage.Size = new System.Drawing.Size(127, 15);
            this.labelAverage.TabIndex = 12;
            this.labelAverage.Text = "Средно аритметично:";
            // 
            // labelAverageResult
            // 
            this.labelAverageResult.AutoSize = true;
            this.labelAverageResult.Location = new System.Drawing.Point(26, 240);
            this.labelAverageResult.Name = "labelAverageResult";
            this.labelAverageResult.Size = new System.Drawing.Size(0, 15);
            this.labelAverageResult.TabIndex = 13;
            // 
            // labelSort
            // 
            this.labelSort.AutoSize = true;
            this.labelSort.Location = new System.Drawing.Point(20, 255);
            this.labelSort.Name = "labelSort";
            this.labelSort.Size = new System.Drawing.Size(76, 15);
            this.labelSort.TabIndex = 14;
            this.labelSort.Text = "Сортировка:";
            // 
            // labelSortResult
            // 
            this.labelSortResult.AutoSize = true;
            this.labelSortResult.Location = new System.Drawing.Point(27, 280);
            this.labelSortResult.Name = "labelSortResult";
            this.labelSortResult.Size = new System.Drawing.Size(0, 15);
            this.labelSortResult.TabIndex = 15;
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Location = new System.Drawing.Point(22, 295);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(39, 15);
            this.labelSum.TabIndex = 16;
            this.labelSum.Text = "Сума:";
            // 
            // labelSumResult
            // 
            this.labelSumResult.AutoSize = true;
            this.labelSumResult.Location = new System.Drawing.Point(23, 315);
            this.labelSumResult.Name = "labelSumResult";
            this.labelSumResult.Size = new System.Drawing.Size(0, 15);
            this.labelSumResult.TabIndex = 17;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(22, 330);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(38, 15);
            this.labelCount.TabIndex = 18;
            this.labelCount.Text = "Брой:";
            // 
            // labelCountResult
            // 
            this.labelCountResult.AutoSize = true;
            this.labelCountResult.Location = new System.Drawing.Point(26, 350);
            this.labelCountResult.Name = "labelCountResult";
            this.labelCountResult.Size = new System.Drawing.Size(0, 15);
            this.labelCountResult.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 360);
            this.Controls.Add(this.labelCountResult);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelSumResult);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.labelSortResult);
            this.Controls.Add(this.labelSort);
            this.Controls.Add(this.labelAverageResult);
            this.Controls.Add(this.labelAverage);
            this.Controls.Add(this.richTextBoxData);
            this.Controls.Add(this.labelMaximum);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.labelMinimum);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.labelQ);
            this.Controls.Add(this.labelP);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonOutput);
            this.Controls.Add(this.textBoxQ);
            this.Controls.Add(this.textBoxP);
            this.Name = "Form1";
            this.Text = "Обработка на масиви";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textBoxP;
        private TextBox textBoxQ;
        private Button buttonOutput;
        private Button buttonClear;
        private Label labelP;
        private Label labelQ;
        private Label labelMin;
        private Label labelMinimum;
        private Label labelMax;
        private Label labelMaximum;
        private RichTextBox richTextBoxData;
        private Label labelAverage;
        private Label labelAverageResult;
        private Label labelSort;
        private Label labelSortResult;
        private Label labelSum;
        private Label labelSumResult;
        private Label labelCount;
        private Label labelCountResult;
    }
}