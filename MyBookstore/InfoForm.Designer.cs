namespace MyBookstore
{
    partial class InfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoForm));
            labelText = new Label();
            listBoxListBooks = new ListBox();
            labelPrice = new Label();
            listBoxInfoUser = new ListBox();
            labelTextBooks = new Label();
            labelTextInfoUser = new Label();
            buttonExitOrder = new Button();
            listBoxAge = new ListBox();
            SuspendLayout();
            // 
            // labelText
            // 
            labelText.AutoSize = true;
            labelText.BackColor = Color.White;
            labelText.Font = new Font("Corbel", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelText.Location = new Point(12, 9);
            labelText.Name = "labelText";
            labelText.Size = new Size(361, 39);
            labelText.TabIndex = 0;
            labelText.Text = "Потвърди поръчката си!";
            // 
            // listBoxListBooks
            // 
            listBoxListBooks.FormattingEnabled = true;
            listBoxListBooks.ItemHeight = 15;
            listBoxListBooks.Location = new Point(14, 87);
            listBoxListBooks.Name = "listBoxListBooks";
            listBoxListBooks.Size = new Size(361, 199);
            listBoxListBooks.TabIndex = 1;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.BackColor = Color.White;
            labelPrice.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelPrice.Location = new Point(228, 298);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(51, 19);
            labelPrice.TabIndex = 2;
            labelPrice.Text = "Цена:";
            // 
            // listBoxInfoUser
            // 
            listBoxInfoUser.FormattingEnabled = true;
            listBoxInfoUser.ItemHeight = 15;
            listBoxInfoUser.Location = new Point(14, 352);
            listBoxInfoUser.Name = "listBoxInfoUser";
            listBoxInfoUser.Size = new Size(359, 34);
            listBoxInfoUser.TabIndex = 3;
            // 
            // labelTextBooks
            // 
            labelTextBooks.AutoSize = true;
            labelTextBooks.BackColor = Color.White;
            labelTextBooks.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelTextBooks.Location = new Point(17, 59);
            labelTextBooks.Name = "labelTextBooks";
            labelTextBooks.Size = new Size(151, 19);
            labelTextBooks.TabIndex = 4;
            labelTextBooks.Text = "Книги в кошницата:";
            // 
            // labelTextInfoUser
            // 
            labelTextInfoUser.AutoSize = true;
            labelTextInfoUser.BackColor = Color.White;
            labelTextInfoUser.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelTextInfoUser.Location = new Point(14, 322);
            labelTextInfoUser.Name = "labelTextInfoUser";
            labelTextInfoUser.Size = new Size(147, 19);
            labelTextInfoUser.TabIndex = 4;
            labelTextInfoUser.Text = "Данни за купувача:";
            // 
            // buttonExitOrder
            // 
            buttonExitOrder.BackColor = Color.Lavender;
            buttonExitOrder.Font = new Font("Corbel", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExitOrder.Location = new Point(12, 432);
            buttonExitOrder.Name = "buttonExitOrder";
            buttonExitOrder.Size = new Size(358, 41);
            buttonExitOrder.TabIndex = 5;
            buttonExitOrder.Text = "Поръчай";
            buttonExitOrder.UseVisualStyleBackColor = false;
            buttonExitOrder.Click += buttonExitOrder_Click;
            // 
            // listBoxAge
            // 
            listBoxAge.FormattingEnabled = true;
            listBoxAge.ItemHeight = 15;
            listBoxAge.Location = new Point(14, 392);
            listBoxAge.Name = "listBoxAge";
            listBoxAge.Size = new Size(359, 34);
            listBoxAge.TabIndex = 3;
            // 
            // InfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(392, 480);
            Controls.Add(buttonExitOrder);
            Controls.Add(labelTextInfoUser);
            Controls.Add(labelTextBooks);
            Controls.Add(listBoxAge);
            Controls.Add(listBoxInfoUser);
            Controls.Add(labelPrice);
            Controls.Add(listBoxListBooks);
            Controls.Add(labelText);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "InfoForm";
            Text = "InfoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelText;
        private ListBox listBoxListBooks;
        private Label labelPrice;
        private ListBox listBoxInfoUser;
        private Label labelTextBooks;
        private Label labelTextInfoUser;
        private Button buttonExitOrder;
        private ListBox listBoxAge;
    }
}