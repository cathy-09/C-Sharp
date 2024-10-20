namespace Perfumery
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
            lblName = new Label();
            lblBrand = new Label();
            lblPrice = new Label();
            txtName = new TextBox();
            txtBrand = new TextBox();
            txtPrice = new TextBox();
            listBoxPerfumeries = new ListBox();
            btnAddPerfumery = new Button();
            btnAddPerfume = new Button();
            btnPerfumeryInfo = new Button();
            btnSellPerfume = new Button();
            btnCalculateTotalPrice = new Button();
            btnClear = new Button();
            btnGoBackToMain = new Button();
            listBoxPerfumes = new ListBox();
            labelRezult = new Label();
            btnClearItems = new Button();
            btnCalculatePrice = new Button();
            btnExit = new Button();
            btnSell = new Button();
            lblResults = new Label();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Arial Rounded MT Bold", 12F);
            lblName.Location = new Point(10, 24);
            lblName.Name = "lblName";
            lblName.Size = new Size(63, 18);
            lblName.TabIndex = 0;
            lblName.Text = "Name: ";
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Font = new Font("Arial Rounded MT Bold", 12F);
            lblBrand.Location = new Point(10, 56);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(62, 18);
            lblBrand.TabIndex = 1;
            lblBrand.Text = "Brand:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Arial Rounded MT Bold", 12F);
            lblPrice.Location = new Point(10, 93);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(55, 18);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "Price:";
            // 
            // txtName
            // 
            txtName.Location = new Point(87, 19);
            txtName.Name = "txtName";
            txtName.Size = new Size(857, 23);
            txtName.TabIndex = 3;
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(87, 51);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(857, 23);
            txtBrand.TabIndex = 4;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(87, 88);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(857, 23);
            txtPrice.TabIndex = 5;
            // 
            // listBoxPerfumeries
            // 
            listBoxPerfumeries.Font = new Font("Arial Rounded MT Bold", 14.25F);
            listBoxPerfumeries.FormattingEnabled = true;
            listBoxPerfumeries.ItemHeight = 22;
            listBoxPerfumeries.Location = new Point(23, 119);
            listBoxPerfumeries.Name = "listBoxPerfumeries";
            listBoxPerfumeries.Size = new Size(277, 312);
            listBoxPerfumeries.TabIndex = 6;
            // 
            // btnAddPerfumery
            // 
            btnAddPerfumery.BackColor = Color.Pink;
            btnAddPerfumery.Font = new Font("Segoe UI", 9.75F);
            btnAddPerfumery.Location = new Point(598, 119);
            btnAddPerfumery.Name = "btnAddPerfumery";
            btnAddPerfumery.Size = new Size(346, 24);
            btnAddPerfumery.TabIndex = 7;
            btnAddPerfumery.Text = "Add Perfumery";
            btnAddPerfumery.UseVisualStyleBackColor = false;
            btnAddPerfumery.Click += btnAddPerfumery_Click;
            // 
            // btnAddPerfume
            // 
            btnAddPerfume.BackColor = Color.Pink;
            btnAddPerfume.Font = new Font("Segoe UI", 9.75F);
            btnAddPerfume.Location = new Point(598, 148);
            btnAddPerfume.Name = "btnAddPerfume";
            btnAddPerfume.Size = new Size(346, 24);
            btnAddPerfume.TabIndex = 7;
            btnAddPerfume.Text = "Add Perfume\n";
            btnAddPerfume.UseVisualStyleBackColor = false;
            btnAddPerfume.Click += btnAddPerfume_Click;
            // 
            // btnPerfumeryInfo
            // 
            btnPerfumeryInfo.BackColor = Color.Pink;
            btnPerfumeryInfo.Font = new Font("Segoe UI", 9.75F);
            btnPerfumeryInfo.Location = new Point(598, 177);
            btnPerfumeryInfo.Name = "btnPerfumeryInfo";
            btnPerfumeryInfo.Size = new Size(346, 24);
            btnPerfumeryInfo.TabIndex = 7;
            btnPerfumeryInfo.Text = "Perfumery Info";
            btnPerfumeryInfo.UseVisualStyleBackColor = false;
            btnPerfumeryInfo.Click += btnPerfumeryInfo_Click_1;
            // 
            // btnSellPerfume
            // 
            btnSellPerfume.Location = new Point(611, 473);
            btnSellPerfume.Name = "btnSellPerfume";
            btnSellPerfume.Size = new Size(225, 23);
            btnSellPerfume.TabIndex = 7;
            btnSellPerfume.Text = "Sell Perfume\n";
            btnSellPerfume.UseVisualStyleBackColor = true;
            // 
            // btnCalculateTotalPrice
            // 
            btnCalculateTotalPrice.Location = new Point(598, 502);
            btnCalculateTotalPrice.Name = "btnCalculateTotalPrice";
            btnCalculateTotalPrice.Size = new Size(225, 23);
            btnCalculateTotalPrice.TabIndex = 7;
            btnCalculateTotalPrice.Text = "Calculate TotalPrice";
            btnCalculateTotalPrice.UseVisualStyleBackColor = true;
            btnCalculateTotalPrice.Click += btnSellPerfume_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(600, 512);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(225, 23);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnSellPerfume_Click;
            // 
            // btnGoBackToMain
            // 
            btnGoBackToMain.Location = new Point(600, 483);
            btnGoBackToMain.Name = "btnGoBackToMain";
            btnGoBackToMain.Size = new Size(225, 23);
            btnGoBackToMain.TabIndex = 7;
            btnGoBackToMain.Text = "Go Back To Main";
            btnGoBackToMain.UseVisualStyleBackColor = true;
            btnGoBackToMain.Click += btnSellPerfume_Click;
            // 
            // listBoxPerfumes
            // 
            listBoxPerfumes.Font = new Font("Arial Rounded MT Bold", 14.25F);
            listBoxPerfumes.FormattingEnabled = true;
            listBoxPerfumes.ItemHeight = 22;
            listBoxPerfumes.Location = new Point(306, 119);
            listBoxPerfumes.Name = "listBoxPerfumes";
            listBoxPerfumes.Size = new Size(277, 312);
            listBoxPerfumes.TabIndex = 8;
            // 
            // labelRezult
            // 
            labelRezult.AutoSize = true;
            labelRezult.Font = new Font("Arial Rounded MT Bold", 11.25F);
            labelRezult.Location = new Point(598, 331);
            labelRezult.Name = "labelRezult";
            labelRezult.Size = new Size(0, 17);
            labelRezult.TabIndex = 9;
            // 
            // btnClearItems
            // 
            btnClearItems.BackColor = Color.Pink;
            btnClearItems.Font = new Font("Segoe UI", 9.75F);
            btnClearItems.Location = new Point(598, 264);
            btnClearItems.Name = "btnClearItems";
            btnClearItems.Size = new Size(346, 24);
            btnClearItems.TabIndex = 10;
            btnClearItems.Text = "Clear";
            btnClearItems.UseVisualStyleBackColor = false;
            btnClearItems.Click += btnClearItems_Click;
            // 
            // btnCalculatePrice
            // 
            btnCalculatePrice.BackColor = Color.Pink;
            btnCalculatePrice.Font = new Font("Segoe UI", 9.75F);
            btnCalculatePrice.Location = new Point(598, 235);
            btnCalculatePrice.Name = "btnCalculatePrice";
            btnCalculatePrice.Size = new Size(346, 24);
            btnCalculatePrice.TabIndex = 11;
            btnCalculatePrice.Text = "Calculate TotalPrice";
            btnCalculatePrice.UseVisualStyleBackColor = false;
            btnCalculatePrice.Click += btnCalculatePrice_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Pink;
            btnExit.Font = new Font("Segoe UI", 9.75F);
            btnExit.Location = new Point(598, 293);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(346, 24);
            btnExit.TabIndex = 12;
            btnExit.Text = "Go Back To Main";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnSell
            // 
            btnSell.BackColor = Color.Pink;
            btnSell.Font = new Font("Segoe UI", 9.75F);
            btnSell.Location = new Point(598, 206);
            btnSell.Name = "btnSell";
            btnSell.Size = new Size(346, 24);
            btnSell.TabIndex = 13;
            btnSell.Text = "Sell Perfume\n";
            btnSell.UseVisualStyleBackColor = false;
            btnSell.Click += btnSell_Click;
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Font = new Font("Arial Rounded MT Bold", 11.25F);
            lblResults.Location = new Point(610, 331);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(0, 17);
            lblResults.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(956, 447);
            Controls.Add(lblResults);
            Controls.Add(btnSell);
            Controls.Add(btnExit);
            Controls.Add(btnCalculatePrice);
            Controls.Add(btnClearItems);
            Controls.Add(labelRezult);
            Controls.Add(listBoxPerfumes);
            Controls.Add(btnGoBackToMain);
            Controls.Add(btnClear);
            Controls.Add(btnCalculateTotalPrice);
            Controls.Add(btnSellPerfume);
            Controls.Add(btnPerfumeryInfo);
            Controls.Add(btnAddPerfume);
            Controls.Add(btnAddPerfumery);
            Controls.Add(listBoxPerfumeries);
            Controls.Add(txtPrice);
            Controls.Add(txtBrand);
            Controls.Add(txtName);
            Controls.Add(lblPrice);
            Controls.Add(lblBrand);
            Controls.Add(lblName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Perfumery";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblBrand;
        private Label lblPrice;
        private TextBox txtName;
        private TextBox txtBrand;
        private TextBox txtPrice;
        private ListBox listBoxPerfumeries;
        private Button btnAddPerfumery;
        private Button btnAddPerfume;
        private Button btnPerfumeryInfo;
        private Button btnSellPerfume;
        private Button btnCalculateTotalPrice;
        private Button btnClear;
        private Button btnGoBackToMain;
        private ListBox listBoxPerfumes;
        private Label labelRezult;
        private Button btnClearItems;
        private Button btnCalculatePrice;
        private Button btnExit;
        private Button btnSell;
        private Label lblResults;
    }
}
