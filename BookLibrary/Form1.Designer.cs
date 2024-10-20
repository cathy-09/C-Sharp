namespace BookLibrary
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblTitle = new Label();
            lblRating = new Label();
            txtTitle = new TextBox();
            txtRating = new TextBox();
            listBoxLibrary = new ListBox();
            btnAddBook = new Button();
            btnSortByTitle = new Button();
            btnSortByRating = new Button();
            btnCheckBook = new Button();
            btnAverageRating = new Button();
            btnGetBooksByRating = new Button();
            lblResult = new Label();
            btnClear = new Button();
            txtHigherRating = new TextBox();
            txtTitleCheck = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lblRez = new Label();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial Rounded MT Bold", 14.25F);
            lblTitle.Location = new Point(16, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(56, 22);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Title:";
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.Font = new Font("Arial Rounded MT Bold", 14.25F);
            lblRating.Location = new Point(16, 57);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(76, 22);
            lblRating.TabIndex = 1;
            lblRating.Text = "Rating:";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(98, 24);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(1017, 23);
            txtTitle.TabIndex = 2;
            // 
            // txtRating
            // 
            txtRating.Location = new Point(98, 56);
            txtRating.Name = "txtRating";
            txtRating.Size = new Size(1017, 23);
            txtRating.TabIndex = 2;
            // 
            // listBoxLibrary
            // 
            listBoxLibrary.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxLibrary.FormattingEnabled = true;
            listBoxLibrary.ItemHeight = 22;
            listBoxLibrary.Location = new Point(16, 91);
            listBoxLibrary.Name = "listBoxLibrary";
            listBoxLibrary.Size = new Size(295, 356);
            listBoxLibrary.TabIndex = 3;
            // 
            // btnAddBook
            // 
            btnAddBook.BackColor = Color.Lavender;
            btnAddBook.Font = new Font("Arial Rounded MT Bold", 14.25F);
            btnAddBook.Location = new Point(326, 91);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(168, 33);
            btnAddBook.TabIndex = 4;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = false;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // btnSortByTitle
            // 
            btnSortByTitle.BackColor = Color.Lavender;
            btnSortByTitle.Font = new Font("Arial Rounded MT Bold", 14.25F);
            btnSortByTitle.Location = new Point(326, 130);
            btnSortByTitle.Name = "btnSortByTitle";
            btnSortByTitle.Size = new Size(168, 33);
            btnSortByTitle.TabIndex = 5;
            btnSortByTitle.Text = "Sort By Title";
            btnSortByTitle.UseVisualStyleBackColor = false;
            btnSortByTitle.Click += btnSortByTitle_Click;
            // 
            // btnSortByRating
            // 
            btnSortByRating.BackColor = Color.Lavender;
            btnSortByRating.Font = new Font("Arial Rounded MT Bold", 14.25F);
            btnSortByRating.Location = new Point(326, 169);
            btnSortByRating.Name = "btnSortByRating";
            btnSortByRating.Size = new Size(168, 33);
            btnSortByRating.TabIndex = 6;
            btnSortByRating.Text = "Sort By Rating";
            btnSortByRating.UseVisualStyleBackColor = false;
            btnSortByRating.Click += btnSortByRating_Click;
            // 
            // btnCheckBook
            // 
            btnCheckBook.BackColor = Color.Lavender;
            btnCheckBook.Font = new Font("Arial Rounded MT Bold", 14.25F);
            btnCheckBook.Location = new Point(326, 208);
            btnCheckBook.Name = "btnCheckBook";
            btnCheckBook.Size = new Size(168, 33);
            btnCheckBook.TabIndex = 7;
            btnCheckBook.Text = "Check Book";
            btnCheckBook.UseVisualStyleBackColor = false;
            btnCheckBook.Click += btnCheckBook_Click;
            // 
            // btnAverageRating
            // 
            btnAverageRating.BackColor = Color.Lavender;
            btnAverageRating.Font = new Font("Arial Rounded MT Bold", 14.25F);
            btnAverageRating.Location = new Point(326, 247);
            btnAverageRating.Name = "btnAverageRating";
            btnAverageRating.Size = new Size(168, 33);
            btnAverageRating.TabIndex = 8;
            btnAverageRating.Text = "Average Rating";
            btnAverageRating.UseVisualStyleBackColor = false;
            btnAverageRating.Click += btnAverageRating_Click;
            // 
            // btnGetBooksByRating
            // 
            btnGetBooksByRating.BackColor = Color.Lavender;
            btnGetBooksByRating.Font = new Font("Arial Rounded MT Bold", 14.25F);
            btnGetBooksByRating.Location = new Point(326, 286);
            btnGetBooksByRating.Name = "btnGetBooksByRating";
            btnGetBooksByRating.Size = new Size(168, 72);
            btnGetBooksByRating.TabIndex = 9;
            btnGetBooksByRating.Text = "Get Books By Higher Rating";
            btnGetBooksByRating.UseVisualStyleBackColor = false;
            btnGetBooksByRating.Click += btnGetBooksByRating_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(331, 335);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 15);
            lblResult.TabIndex = 10;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Lavender;
            btnClear.Font = new Font("Arial Rounded MT Bold", 14.25F);
            btnClear.Location = new Point(326, 364);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(168, 33);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // txtHigherRating
            // 
            txtHigherRating.Location = new Point(592, 130);
            txtHigherRating.Name = "txtHigherRating";
            txtHigherRating.Size = new Size(523, 23);
            txtHigherRating.TabIndex = 14;
            // 
            // txtTitleCheck
            // 
            txtTitleCheck.Location = new Point(592, 98);
            txtTitleCheck.Name = "txtTitleCheck";
            txtTitleCheck.Size = new Size(523, 23);
            txtTitleCheck.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 14.25F);
            label1.Location = new Point(510, 131);
            label1.Name = "label1";
            label1.Size = new Size(76, 22);
            label1.TabIndex = 13;
            label1.Text = "Rating:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 14.25F);
            label2.Location = new Point(510, 99);
            label2.Name = "label2";
            label2.Size = new Size(56, 22);
            label2.TabIndex = 12;
            label2.Text = "Title:";
            // 
            // lblRez
            // 
            lblRez.AutoSize = true;
            lblRez.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRez.Location = new Point(522, 174);
            lblRez.Name = "lblRez";
            lblRez.Size = new Size(0, 22);
            lblRez.TabIndex = 16;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Lavender;
            btnExit.Font = new Font("Arial Rounded MT Bold", 14.25F);
            btnExit.Location = new Point(326, 406);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(168, 33);
            btnExit.TabIndex = 17;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            ClientSize = new Size(1127, 460);
            Controls.Add(btnExit);
            Controls.Add(lblRez);
            Controls.Add(txtHigherRating);
            Controls.Add(txtTitleCheck);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(btnClear);
            Controls.Add(lblResult);
            Controls.Add(btnGetBooksByRating);
            Controls.Add(btnAverageRating);
            Controls.Add(btnCheckBook);
            Controls.Add(btnSortByRating);
            Controls.Add(btnSortByTitle);
            Controls.Add(btnAddBook);
            Controls.Add(listBoxLibrary);
            Controls.Add(txtRating);
            Controls.Add(txtTitle);
            Controls.Add(lblRating);
            Controls.Add(lblTitle);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Book Library";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblRating;
        private TextBox txtTitle;
        private TextBox txtRating;
        private ListBox listBoxLibrary;
        private Button btnAddBook;
        private Button btnSortByTitle;
        private Button btnSortByRating;
        private Button btnCheckBook;
        private Button btnAverageRating;
        private Button btnGetBooksByRating;
        private Label lblResult;
        private Button btnClear;
        private TextBox txtHigherRating;
        private TextBox txtTitleCheck;
        private Label label1;
        private Label label2;
        private Label lblRez;
        private Button btnExit;
    }
}