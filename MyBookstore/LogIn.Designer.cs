namespace MyBookstore
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            textBoxPassword = new TextBox();
            textBoxUsername = new TextBox();
            labelPassword = new Label();
            labelUsername = new Label();
            labelText = new Label();
            buttonLogIn = new Button();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(220, 110);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(186, 23);
            textBoxPassword.TabIndex = 9;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(220, 79);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(186, 23);
            textBoxUsername.TabIndex = 8;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.BackColor = Color.White;
            labelPassword.Font = new Font("Corbel", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelPassword.Location = new Point(12, 110);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(89, 26);
            labelPassword.TabIndex = 5;
            labelPassword.Text = "Парола:";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.BackColor = Color.White;
            labelUsername.Font = new Font("Corbel", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelUsername.Location = new Point(12, 76);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(202, 26);
            labelUsername.TabIndex = 6;
            labelUsername.Text = "Потребителско име:";
            // 
            // labelText
            // 
            labelText.AutoSize = true;
            labelText.BackColor = Color.White;
            labelText.Font = new Font("Corbel", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelText.Location = new Point(12, 18);
            labelText.Name = "labelText";
            labelText.Size = new Size(336, 45);
            labelText.TabIndex = 9;
            labelText.Text = "Влез в профила си:";
            // 
            // buttonLogIn
            // 
            buttonLogIn.BackColor = Color.Lavender;
            buttonLogIn.Font = new Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogIn.Location = new Point(12, 153);
            buttonLogIn.Name = "buttonLogIn";
            buttonLogIn.Size = new Size(269, 44);
            buttonLogIn.TabIndex = 10;
            buttonLogIn.Text = "Влез в профила си";
            buttonLogIn.UseVisualStyleBackColor = false;
            buttonLogIn.Click += buttonLogIn_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.Lavender;
            buttonExit.Font = new Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExit.Location = new Point(287, 153);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(119, 44);
            buttonExit.TabIndex = 11;
            buttonExit.Text = "Изход";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(418, 209);
            Controls.Add(buttonExit);
            Controls.Add(buttonLogIn);
            Controls.Add(labelText);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(labelPassword);
            Controls.Add(labelUsername);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LogIn";
            Text = "LogIn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPassword;
        private TextBox textBoxUsername;
        private Label labelPassword;
        private Label labelUsername;
        private Label labelText;
        private Button buttonLogIn;
        private Button buttonExit;
    }
}