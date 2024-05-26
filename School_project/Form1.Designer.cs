namespace school_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            gBPosition = new GroupBox();
            rdBEmployee = new RadioButton();
            rdBStudent = new RadioButton();
            gBStudent = new GroupBox();
            rbWomenStudent = new RadioButton();
            rbMaleStudent = new RadioButton();
            txtBParalelkaStudent = new TextBox();
            txtBClassStudent = new TextBox();
            txtBEGNStudent = new TextBox();
            txtBNameStudent = new TextBox();
            lblGenderStudent = new Label();
            lblParalelkaStudent = new Label();
            lblClassStudent = new Label();
            lblEGNStudent = new Label();
            lblNameStudent = new Label();
            rbWomanEmployee = new RadioButton();
            rbMaleEmployee = new RadioButton();
            txtBExperienceEmployee = new TextBox();
            txtBPositionEmployee = new TextBox();
            txtBEGNEmployee = new TextBox();
            txtBNameEmployee = new TextBox();
            lblGenderEmployee = new Label();
            lblExperienceEmployee = new Label();
            lblPositionEmployee = new Label();
            lblEGNEmployee = new Label();
            lblNameEmployee = new Label();
            gpBEmployee = new GroupBox();
            btnInput = new Button();
            pBSchool = new PictureBox();
            pBPPMG = new PictureBox();
            lblStudentName = new Label();
            lblEmployeeName = new Label();
            lBStudent = new ListBox();
            lBEmployee = new ListBox();
            btnLoad = new Button();
            lblEGNSearch = new Label();
            txtBSearchedEGN = new TextBox();
            btnSearch = new Button();
            gBPosition.SuspendLayout();
            gBStudent.SuspendLayout();
            gpBEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBSchool).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBPPMG).BeginInit();
            SuspendLayout();
            // 
            // gBPosition
            // 
            gBPosition.Controls.Add(rdBEmployee);
            gBPosition.Controls.Add(rdBStudent);
            gBPosition.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            gBPosition.Location = new Point(16, 12);
            gBPosition.Name = "gBPosition";
            gBPosition.Size = new Size(169, 77);
            gBPosition.TabIndex = 0;
            gBPosition.TabStop = false;
            gBPosition.Text = "Моля, изберете длъжност:";
            gBPosition.Enter += gBPosition_Enter;
            // 
            // rdBEmployee
            // 
            rdBEmployee.AutoSize = true;
            rdBEmployee.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rdBEmployee.Location = new Point(18, 47);
            rdBEmployee.Name = "rdBEmployee";
            rdBEmployee.Size = new Size(82, 19);
            rdBEmployee.TabIndex = 1;
            rdBEmployee.Text = "Служител";
            rdBEmployee.UseVisualStyleBackColor = true;
            rdBEmployee.CheckedChanged += rdBEmployee_CheckedChanged;
            // 
            // rdBStudent
            // 
            rdBStudent.AutoSize = true;
            rdBStudent.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rdBStudent.Location = new Point(18, 22);
            rdBStudent.Name = "rdBStudent";
            rdBStudent.Size = new Size(66, 19);
            rdBStudent.TabIndex = 0;
            rdBStudent.Text = "Ученик";
            rdBStudent.UseVisualStyleBackColor = true;
            rdBStudent.CheckedChanged += rdBStudent_CheckedChanged;
            // 
            // gBStudent
            // 
            gBStudent.Controls.Add(rbWomenStudent);
            gBStudent.Controls.Add(rbMaleStudent);
            gBStudent.Controls.Add(txtBParalelkaStudent);
            gBStudent.Controls.Add(txtBClassStudent);
            gBStudent.Controls.Add(txtBEGNStudent);
            gBStudent.Controls.Add(txtBNameStudent);
            gBStudent.Controls.Add(lblGenderStudent);
            gBStudent.Controls.Add(lblParalelkaStudent);
            gBStudent.Controls.Add(lblClassStudent);
            gBStudent.Controls.Add(lblEGNStudent);
            gBStudent.Controls.Add(lblNameStudent);
            gBStudent.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gBStudent.Location = new Point(16, 100);
            gBStudent.Name = "gBStudent";
            gBStudent.Size = new Size(200, 170);
            gBStudent.TabIndex = 1;
            gBStudent.TabStop = false;
            gBStudent.Text = "Ученик";
            gBStudent.Visible = false;
            // 
            // rbWomenStudent
            // 
            rbWomenStudent.AutoSize = true;
            rbWomenStudent.Enabled = false;
            rbWomenStudent.Location = new Point(95, 147);
            rbWomenStudent.Name = "rbWomenStudent";
            rbWomenStudent.Size = new Size(55, 19);
            rbWomenStudent.TabIndex = 10;
            rbWomenStudent.TabStop = true;
            rbWomenStudent.Text = "жена";
            rbWomenStudent.UseVisualStyleBackColor = true;
            // 
            // rbMaleStudent
            // 
            rbMaleStudent.AutoSize = true;
            rbMaleStudent.Enabled = false;
            rbMaleStudent.Location = new Point(97, 126);
            rbMaleStudent.Name = "rbMaleStudent";
            rbMaleStudent.Size = new Size(50, 19);
            rbMaleStudent.TabIndex = 9;
            rbMaleStudent.TabStop = true;
            rbMaleStudent.Text = "мъж";
            rbMaleStudent.UseVisualStyleBackColor = true;
            // 
            // txtBParalelkaStudent
            // 
            txtBParalelkaStudent.Enabled = false;
            txtBParalelkaStudent.Location = new Point(96, 94);
            txtBParalelkaStudent.Name = "txtBParalelkaStudent";
            txtBParalelkaStudent.Size = new Size(100, 21);
            txtBParalelkaStudent.TabIndex = 8;
            // 
            // txtBClassStudent
            // 
            txtBClassStudent.Enabled = false;
            txtBClassStudent.Location = new Point(96, 67);
            txtBClassStudent.Name = "txtBClassStudent";
            txtBClassStudent.Size = new Size(100, 21);
            txtBClassStudent.TabIndex = 7;
            // 
            // txtBEGNStudent
            // 
            txtBEGNStudent.Enabled = false;
            txtBEGNStudent.Location = new Point(95, 42);
            txtBEGNStudent.Name = "txtBEGNStudent";
            txtBEGNStudent.Size = new Size(100, 21);
            txtBEGNStudent.TabIndex = 6;
            // 
            // txtBNameStudent
            // 
            txtBNameStudent.Enabled = false;
            txtBNameStudent.Location = new Point(94, 16);
            txtBNameStudent.Name = "txtBNameStudent";
            txtBNameStudent.Size = new Size(100, 21);
            txtBNameStudent.TabIndex = 5;
            // 
            // lblGenderStudent
            // 
            lblGenderStudent.AutoSize = true;
            lblGenderStudent.Location = new Point(14, 133);
            lblGenderStudent.Name = "lblGenderStudent";
            lblGenderStudent.Size = new Size(33, 15);
            lblGenderStudent.TabIndex = 4;
            lblGenderStudent.Text = "Пол:";
            // 
            // lblParalelkaStudent
            // 
            lblParalelkaStudent.AutoSize = true;
            lblParalelkaStudent.Location = new Point(15, 97);
            lblParalelkaStudent.Name = "lblParalelkaStudent";
            lblParalelkaStudent.Size = new Size(74, 15);
            lblParalelkaStudent.TabIndex = 3;
            lblParalelkaStudent.Text = "Паралелка:";
            // 
            // lblClassStudent
            // 
            lblClassStudent.AutoSize = true;
            lblClassStudent.Location = new Point(15, 70);
            lblClassStudent.Name = "lblClassStudent";
            lblClassStudent.Size = new Size(38, 15);
            lblClassStudent.TabIndex = 2;
            lblClassStudent.Text = "Клас:";
            // 
            // lblEGNStudent
            // 
            lblEGNStudent.AutoSize = true;
            lblEGNStudent.Location = new Point(15, 42);
            lblEGNStudent.Name = "lblEGNStudent";
            lblEGNStudent.Size = new Size(34, 15);
            lblEGNStudent.TabIndex = 1;
            lblEGNStudent.Text = "ЕГН:";
            // 
            // lblNameStudent
            // 
            lblNameStudent.AutoSize = true;
            lblNameStudent.Location = new Point(15, 20);
            lblNameStudent.Name = "lblNameStudent";
            lblNameStudent.Size = new Size(35, 15);
            lblNameStudent.TabIndex = 0;
            lblNameStudent.Text = "Име:";
            // 
            // rbWomanEmployee
            // 
            rbWomanEmployee.AutoSize = true;
            rbWomanEmployee.Enabled = false;
            rbWomanEmployee.Location = new Point(149, 152);
            rbWomanEmployee.Name = "rbWomanEmployee";
            rbWomanEmployee.Size = new Size(55, 19);
            rbWomanEmployee.TabIndex = 16;
            rbWomanEmployee.TabStop = true;
            rbWomanEmployee.Text = "жена";
            rbWomanEmployee.UseVisualStyleBackColor = true;
            // 
            // rbMaleEmployee
            // 
            rbMaleEmployee.AutoSize = true;
            rbMaleEmployee.Enabled = false;
            rbMaleEmployee.Location = new Point(148, 129);
            rbMaleEmployee.Name = "rbMaleEmployee";
            rbMaleEmployee.Size = new Size(50, 19);
            rbMaleEmployee.TabIndex = 15;
            rbMaleEmployee.TabStop = true;
            rbMaleEmployee.Text = "мъж";
            rbMaleEmployee.UseVisualStyleBackColor = true;
            // 
            // txtBExperienceEmployee
            // 
            txtBExperienceEmployee.Enabled = false;
            txtBExperienceEmployee.Location = new Point(149, 99);
            txtBExperienceEmployee.Name = "txtBExperienceEmployee";
            txtBExperienceEmployee.Size = new Size(100, 21);
            txtBExperienceEmployee.TabIndex = 14;
            // 
            // txtBPositionEmployee
            // 
            txtBPositionEmployee.Enabled = false;
            txtBPositionEmployee.Location = new Point(149, 72);
            txtBPositionEmployee.Name = "txtBPositionEmployee";
            txtBPositionEmployee.Size = new Size(100, 21);
            txtBPositionEmployee.TabIndex = 13;
            // 
            // txtBEGNEmployee
            // 
            txtBEGNEmployee.Enabled = false;
            txtBEGNEmployee.Location = new Point(149, 46);
            txtBEGNEmployee.Name = "txtBEGNEmployee";
            txtBEGNEmployee.Size = new Size(100, 21);
            txtBEGNEmployee.TabIndex = 12;
            // 
            // txtBNameEmployee
            // 
            txtBNameEmployee.Enabled = false;
            txtBNameEmployee.Location = new Point(149, 20);
            txtBNameEmployee.Name = "txtBNameEmployee";
            txtBNameEmployee.Size = new Size(100, 21);
            txtBNameEmployee.TabIndex = 11;
            // 
            // lblGenderEmployee
            // 
            lblGenderEmployee.AutoSize = true;
            lblGenderEmployee.Location = new Point(18, 133);
            lblGenderEmployee.Name = "lblGenderEmployee";
            lblGenderEmployee.Size = new Size(33, 15);
            lblGenderEmployee.TabIndex = 4;
            lblGenderEmployee.Text = "Пол:";
            // 
            // lblExperienceEmployee
            // 
            lblExperienceEmployee.AutoSize = true;
            lblExperienceEmployee.Location = new Point(18, 102);
            lblExperienceEmployee.Name = "lblExperienceEmployee";
            lblExperienceEmployee.Size = new Size(130, 15);
            lblExperienceEmployee.TabIndex = 3;
            lblExperienceEmployee.Text = "Години трудов стаж: ";
            // 
            // lblPositionEmployee
            // 
            lblPositionEmployee.AutoSize = true;
            lblPositionEmployee.Location = new Point(18, 78);
            lblPositionEmployee.Name = "lblPositionEmployee";
            lblPositionEmployee.Size = new Size(125, 15);
            lblPositionEmployee.TabIndex = 2;
            lblPositionEmployee.Text = "Заемана длъжност: ";
            // 
            // lblEGNEmployee
            // 
            lblEGNEmployee.AutoSize = true;
            lblEGNEmployee.Location = new Point(18, 50);
            lblEGNEmployee.Name = "lblEGNEmployee";
            lblEGNEmployee.Size = new Size(34, 15);
            lblEGNEmployee.TabIndex = 1;
            lblEGNEmployee.Text = "ЕГН:";
            // 
            // lblNameEmployee
            // 
            lblNameEmployee.AutoSize = true;
            lblNameEmployee.Location = new Point(16, 23);
            lblNameEmployee.Name = "lblNameEmployee";
            lblNameEmployee.Size = new Size(38, 15);
            lblNameEmployee.TabIndex = 0;
            lblNameEmployee.Text = "Име: ";
            // 
            // gpBEmployee
            // 
            gpBEmployee.Controls.Add(rbWomanEmployee);
            gpBEmployee.Controls.Add(lblNameEmployee);
            gpBEmployee.Controls.Add(rbMaleEmployee);
            gpBEmployee.Controls.Add(lblEGNEmployee);
            gpBEmployee.Controls.Add(txtBExperienceEmployee);
            gpBEmployee.Controls.Add(lblPositionEmployee);
            gpBEmployee.Controls.Add(txtBPositionEmployee);
            gpBEmployee.Controls.Add(lblExperienceEmployee);
            gpBEmployee.Controls.Add(txtBEGNEmployee);
            gpBEmployee.Controls.Add(lblGenderEmployee);
            gpBEmployee.Controls.Add(txtBNameEmployee);
            gpBEmployee.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gpBEmployee.Location = new Point(16, 95);
            gpBEmployee.Name = "gpBEmployee";
            gpBEmployee.Size = new Size(259, 177);
            gpBEmployee.TabIndex = 3;
            gpBEmployee.TabStop = false;
            gpBEmployee.Text = "Служител";
            gpBEmployee.Visible = false;
            gpBEmployee.Enter += gpBEmployee_Enter;
            // 
            // btnInput
            // 
            btnInput.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnInput.Location = new Point(16, 283);
            btnInput.Name = "btnInput";
            btnInput.Size = new Size(259, 44);
            btnInput.TabIndex = 4;
            btnInput.Text = "Въведи";
            btnInput.UseVisualStyleBackColor = true;
            btnInput.Visible = false;
            btnInput.Click += btnInput_Click;
            // 
            // pBSchool
            // 
            pBSchool.Image = (Image)resources.GetObject("pBSchool.Image");
            pBSchool.Location = new Point(281, 12);
            pBSchool.Name = "pBSchool";
            pBSchool.Size = new Size(298, 150);
            pBSchool.SizeMode = PictureBoxSizeMode.StretchImage;
            pBSchool.TabIndex = 5;
            pBSchool.TabStop = false;
            pBSchool.Visible = false;
            // 
            // pBPPMG
            // 
            pBPPMG.Image = (Image)resources.GetObject("pBPPMG.Image");
            pBPPMG.Location = new Point(191, 12);
            pBPPMG.Name = "pBPPMG";
            pBPPMG.Size = new Size(84, 75);
            pBPPMG.SizeMode = PictureBoxSizeMode.StretchImage;
            pBPPMG.TabIndex = 6;
            pBPPMG.TabStop = false;
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblStudentName.Location = new Point(288, 170);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(131, 16);
            lblStudentName.TabIndex = 7;
            lblStudentName.Text = "Имена на ученици:";
            lblStudentName.Visible = false;
            lblStudentName.Click += lblStudentName_Click;
            // 
            // lblEmployeeName
            // 
            lblEmployeeName.AutoSize = true;
            lblEmployeeName.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmployeeName.Location = new Point(433, 170);
            lblEmployeeName.Name = "lblEmployeeName";
            lblEmployeeName.Size = new Size(146, 16);
            lblEmployeeName.TabIndex = 8;
            lblEmployeeName.Text = "Имена на служители:";
            lblEmployeeName.Visible = false;
            // 
            // lBStudent
            // 
            lBStudent.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lBStudent.FormattingEnabled = true;
            lBStudent.ItemHeight = 15;
            lBStudent.Location = new Point(287, 189);
            lBStudent.Name = "lBStudent";
            lBStudent.Size = new Size(132, 184);
            lBStudent.TabIndex = 9;
            lBStudent.Visible = false;
            lBStudent.SelectedIndexChanged += lBStudent_SelectedIndexChanged;
            // 
            // lBEmployee
            // 
            lBEmployee.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lBEmployee.FormattingEnabled = true;
            lBEmployee.ItemHeight = 15;
            lBEmployee.Location = new Point(433, 189);
            lBEmployee.Name = "lBEmployee";
            lBEmployee.Size = new Size(146, 184);
            lBEmployee.TabIndex = 10;
            lBEmployee.Visible = false;
            lBEmployee.SelectedIndexChanged += lBEmployee_SelectedIndexChanged;
            // 
            // btnLoad
            // 
            btnLoad.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoad.Location = new Point(288, 379);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(291, 37);
            btnLoad.TabIndex = 11;
            btnLoad.Text = "Зареди";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Visible = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // lblEGNSearch
            // 
            lblEGNSearch.AutoSize = true;
            lblEGNSearch.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblEGNSearch.Location = new Point(77, 330);
            lblEGNSearch.Name = "lblEGNSearch";
            lblEGNSearch.Size = new Size(139, 24);
            lblEGNSearch.TabIndex = 12;
            lblEGNSearch.Text = "Търси по ЕГН:";
            lblEGNSearch.Visible = false;
            lblEGNSearch.Click += lblEGNSearch_Click;
            // 
            // txtBSearchedEGN
            // 
            txtBSearchedEGN.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBSearchedEGN.Location = new Point(16, 357);
            txtBSearchedEGN.Multiline = true;
            txtBSearchedEGN.Name = "txtBSearchedEGN";
            txtBSearchedEGN.Size = new Size(259, 24);
            txtBSearchedEGN.TabIndex = 13;
            txtBSearchedEGN.Visible = false;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(16, 388);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(259, 28);
            btnSearch.TabIndex = 14;
            btnSearch.Text = "Търси";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Visible = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 428);
            Controls.Add(btnSearch);
            Controls.Add(txtBSearchedEGN);
            Controls.Add(lblEGNSearch);
            Controls.Add(btnLoad);
            Controls.Add(lBEmployee);
            Controls.Add(lBStudent);
            Controls.Add(lblEmployeeName);
            Controls.Add(lblStudentName);
            Controls.Add(pBPPMG);
            Controls.Add(pBSchool);
            Controls.Add(btnInput);
            Controls.Add(gpBEmployee);
            Controls.Add(gBStudent);
            Controls.Add(gBPosition);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Училище";
            gBPosition.ResumeLayout(false);
            gBPosition.PerformLayout();
            gBStudent.ResumeLayout(false);
            gBStudent.PerformLayout();
            gpBEmployee.ResumeLayout(false);
            gpBEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pBSchool).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBPPMG).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gBPosition;
        private RadioButton rdBEmployee;
        private RadioButton rdBStudent;
        private GroupBox gBStudent;
        private TextBox txtBParalelkaStudent;
        private TextBox txtBClassStudent;
        private TextBox txtBEGNStudent;
        private TextBox txtBNameStudent;
        private Label lblGenderStudent;
        private Label lblParalelkaStudent;
        private Label lblClassStudent;
        private Label lblEGNStudent;
        private Label lblNameStudent;
        private GroupBox gBEmployee;
        private Label lblNameEmployee;
        private Label lblGenderEmployee;
        private Label lblExperienceEmployee;
        private Label lblPositionEmployee;
        private Label lblEGNEmployee;
        private TextBox txtBExperienceEmployee;
        private TextBox txtBPositionEmployee;
        private TextBox txtBEGNEmployee;
        private TextBox txtBNameEmployee;
        private RadioButton rbWomenStudent;
        private RadioButton rbMaleStudent;
        private RadioButton rbWomanEmployee;
        private RadioButton rbMaleEmployee;
        private GroupBox gpBEmployee;
        private Button btnInput;
        private PictureBox pBSchool;
        private PictureBox pBPPMG;
        private Label lblStudentName;
        private Label lblEmployeeName;
        private ListBox lBStudent;
        private ListBox lBEmployee;
        private Button btnLoad;
        private Label lblEGNSearch;
        private TextBox txtBSearchedEGN;
        private Button btnSearch;
    }
}