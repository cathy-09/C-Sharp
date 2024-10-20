namespace Perfumery
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            btnGoToPerfumery = new Button();
            label1 = new Label();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnGoToPerfumery
            // 
            btnGoToPerfumery.BackColor = Color.Pink;
            btnGoToPerfumery.Font = new Font("Arial Rounded MT Bold", 18F);
            btnGoToPerfumery.Location = new Point(25, 98);
            btnGoToPerfumery.Name = "btnGoToPerfumery";
            btnGoToPerfumery.Size = new Size(544, 51);
            btnGoToPerfumery.TabIndex = 0;
            btnGoToPerfumery.Text = "Perfumery 'Cathy'";
            btnGoToPerfumery.UseVisualStyleBackColor = false;
            btnGoToPerfumery.Click += btnGoToPerfumery_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(587, 75);
            label1.TabIndex = 1;
            label1.Text = "Perfumery 'Cathy'";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Pink;
            btnExit.Font = new Font("Arial Rounded MT Bold", 18F);
            btnExit.Location = new Point(25, 155);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(544, 51);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(594, 230);
            Controls.Add(btnExit);
            Controls.Add(label1);
            Controls.Add(btnGoToPerfumery);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            Text = "Main";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGoToPerfumery;
        private Label label1;
        private Button btnExit;
    }
}