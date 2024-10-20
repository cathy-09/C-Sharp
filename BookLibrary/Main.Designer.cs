namespace BookLibrary
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
            btnExit = new Button();
            label1 = new Label();
            btnGoToLibrary = new Button();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Lavender;
            btnExit.Font = new Font("Arial Rounded MT Bold", 18F);
            btnExit.Location = new Point(12, 155);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(456, 51);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(-2, 9);
            label1.Name = "label1";
            label1.Size = new Size(485, 75);
            label1.TabIndex = 4;
            label1.Text = "Library 'Cathy'";
            // 
            // btnGoToLibrary
            // 
            btnGoToLibrary.BackColor = Color.Lavender;
            btnGoToLibrary.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGoToLibrary.Location = new Point(12, 98);
            btnGoToLibrary.Name = "btnGoToLibrary";
            btnGoToLibrary.Size = new Size(456, 51);
            btnGoToLibrary.TabIndex = 3;
            btnGoToLibrary.Text = "Library 'Cathy'";
            btnGoToLibrary.UseVisualStyleBackColor = false;
            btnGoToLibrary.Click += btnGoToLibrary_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            ClientSize = new Size(480, 221);
            Controls.Add(btnExit);
            Controls.Add(label1);
            Controls.Add(btnGoToLibrary);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            Text = "Main Library";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Label label1;
        private Button btnGoToLibrary;
    }
}