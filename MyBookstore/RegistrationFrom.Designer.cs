namespace MyBookstore
{
    partial class RegistrationFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationFrom));
            labelText = new Label();
            labelFirstName = new Label();
            labelSurname = new Label();
            labelLastName = new Label();
            labelEGN = new Label();
            labelPhoneNumber = new Label();
            labelUsername = new Label();
            labelPassword = new Label();
            buttonSignIn = new Button();
            buttonLogIn = new Button();
            textBoxFirstName = new TextBox();
            textBoxSurname = new TextBox();
            textBoxLastName = new TextBox();
            textBoxEGN = new TextBox();
            textBoxPhoneNumber = new TextBox();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // labelText
            // 
            labelText.AutoSize = true;
            labelText.BackColor = Color.White;
            labelText.Font = new Font("Corbel", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelText.Location = new Point(15, 9);
            labelText.Name = "labelText";
            labelText.Size = new Size(511, 42);
            labelText.TabIndex = 0;
            labelText.Text = "Здравей. Регистрирай се, моля!";
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.BackColor = Color.White;
            labelFirstName.Font = new Font("Corbel", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelFirstName.Location = new Point(15, 70);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(58, 26);
            labelFirstName.TabIndex = 1;
            labelFirstName.Text = "Име:";
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.BackColor = Color.White;
            labelSurname.Font = new Font("Corbel", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelSurname.Location = new Point(15, 105);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(102, 26);
            labelSurname.TabIndex = 1;
            labelSurname.Text = "Презиме:";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.BackColor = Color.White;
            labelLastName.Font = new Font("Corbel", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelLastName.Location = new Point(15, 140);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(105, 26);
            labelLastName.TabIndex = 1;
            labelLastName.Text = "Фамилия:";
            // 
            // labelEGN
            // 
            labelEGN.AutoSize = true;
            labelEGN.BackColor = Color.White;
            labelEGN.Font = new Font("Corbel", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelEGN.Location = new Point(15, 173);
            labelEGN.Name = "labelEGN";
            labelEGN.Size = new Size(55, 26);
            labelEGN.TabIndex = 1;
            labelEGN.Text = "ЕНГ:";
            // 
            // labelPhoneNumber
            // 
            labelPhoneNumber.AutoSize = true;
            labelPhoneNumber.BackColor = Color.White;
            labelPhoneNumber.Font = new Font("Corbel", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelPhoneNumber.Location = new Point(15, 204);
            labelPhoneNumber.Name = "labelPhoneNumber";
            labelPhoneNumber.Size = new Size(189, 26);
            labelPhoneNumber.TabIndex = 1;
            labelPhoneNumber.Text = "Телефонен номер:";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.BackColor = Color.White;
            labelUsername.Font = new Font("Corbel", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelUsername.Location = new Point(15, 237);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(202, 26);
            labelUsername.TabIndex = 1;
            labelUsername.Text = "Потребителско име:";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.BackColor = Color.White;
            labelPassword.Font = new Font("Corbel", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelPassword.Location = new Point(15, 268);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(89, 26);
            labelPassword.TabIndex = 1;
            labelPassword.Text = "Парола:";
            // 
            // buttonSignIn
            // 
            buttonSignIn.BackColor = Color.Lavender;
            buttonSignIn.Font = new Font("Corbel", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSignIn.Location = new Point(15, 306);
            buttonSignIn.Name = "buttonSignIn";
            buttonSignIn.Size = new Size(164, 39);
            buttonSignIn.TabIndex = 2;
            buttonSignIn.Text = "Регистрирай се";
            buttonSignIn.UseVisualStyleBackColor = false;
            buttonSignIn.Click += buttonSignIn_Click;
            // 
            // buttonLogIn
            // 
            buttonLogIn.BackColor = Color.Lavender;
            buttonLogIn.Font = new Font("Corbel", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogIn.Location = new Point(185, 306);
            buttonLogIn.Name = "buttonLogIn";
            buttonLogIn.Size = new Size(167, 39);
            buttonLogIn.TabIndex = 3;
            buttonLogIn.Text = "Влез";
            buttonLogIn.UseVisualStyleBackColor = false;
            buttonLogIn.Click += buttonLogIn_Click;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(223, 73);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(303, 23);
            textBoxFirstName.TabIndex = 4;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(223, 108);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(303, 23);
            textBoxSurname.TabIndex = 4;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(223, 143);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(299, 23);
            textBoxLastName.TabIndex = 4;
            // 
            // textBoxEGN
            // 
            textBoxEGN.Location = new Point(223, 176);
            textBoxEGN.Name = "textBoxEGN";
            textBoxEGN.Size = new Size(299, 23);
            textBoxEGN.TabIndex = 4;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Location = new Point(223, 207);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(299, 23);
            textBoxPhoneNumber.TabIndex = 4;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(223, 240);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(299, 23);
            textBoxUsername.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(223, 271);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(299, 23);
            textBoxPassword.TabIndex = 4;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.Lavender;
            buttonExit.Font = new Font("Corbel", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExit.Location = new Point(358, 306);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(167, 39);
            buttonExit.TabIndex = 3;
            buttonExit.Text = "Изход";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // RegistrationFrom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(534, 354);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(textBoxPhoneNumber);
            Controls.Add(textBoxEGN);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxSurname);
            Controls.Add(textBoxFirstName);
            Controls.Add(buttonExit);
            Controls.Add(buttonLogIn);
            Controls.Add(buttonSignIn);
            Controls.Add(labelPassword);
            Controls.Add(labelUsername);
            Controls.Add(labelPhoneNumber);
            Controls.Add(labelLastName);
            Controls.Add(labelEGN);
            Controls.Add(labelSurname);
            Controls.Add(labelFirstName);
            Controls.Add(labelText);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RegistrationFrom";
            Text = "RegistrationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelText;
        private Label labelFirstName;
        private Label labelSurname;
        private Label labelLastName;
        private Label labelEGN;
        private Label labelPhoneNumber;
        private Label labelUsername;
        private Label labelPassword;
        private Button buttonSignIn;
        private Button buttonLogIn;
        private TextBox textBoxFirstName;
        private TextBox textBoxSurname;
        private TextBox textBoxLastName;
        private TextBox textBoxEGN;
        private TextBox textBoxPhoneNumber;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Button buttonExit;
    }
}