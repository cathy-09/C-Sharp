namespace MyBookstore
{
    partial class TeenagersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeenagersForm));
            labelTextTeens = new Label();
            checkedListBoxRomance = new CheckedListBox();
            buttonFinalizeOrder = new Button();
            labelUser = new Label();
            SuspendLayout();
            // 
            // labelTextTeens
            // 
            labelTextTeens.AutoSize = true;
            labelTextTeens.BackColor = Color.White;
            labelTextTeens.Font = new Font("Corbel", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelTextTeens.Location = new Point(12, 39);
            labelTextTeens.Name = "labelTextTeens";
            labelTextTeens.Size = new Size(538, 78);
            labelTextTeens.TabIndex = 3;
            labelTextTeens.Text = "Здравей! \r\nВ момента предлагаме тези романи:";
            labelTextTeens.TextAlign = ContentAlignment.TopCenter;
            // 
            // checkedListBoxRomance
            // 
            checkedListBoxRomance.Font = new Font("Corbel", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            checkedListBoxRomance.FormattingEnabled = true;
            checkedListBoxRomance.Location = new Point(12, 127);
            checkedListBoxRomance.Name = "checkedListBoxRomance";
            checkedListBoxRomance.Size = new Size(538, 264);
            checkedListBoxRomance.TabIndex = 2;
            // 
            // buttonFinalizeOrder
            // 
            buttonFinalizeOrder.BackColor = Color.Lavender;
            buttonFinalizeOrder.Font = new Font("Corbel", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFinalizeOrder.Location = new Point(12, 397);
            buttonFinalizeOrder.Name = "buttonFinalizeOrder";
            buttonFinalizeOrder.Size = new Size(538, 41);
            buttonFinalizeOrder.TabIndex = 7;
            buttonFinalizeOrder.Text = "Финализирай поръчка";
            buttonFinalizeOrder.UseVisualStyleBackColor = false;
            buttonFinalizeOrder.Click += buttonFinalizeOrder_Click;
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.BackColor = Color.White;
            labelUser.Font = new Font("Corbel", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelUser.ForeColor = SystemColors.MenuHighlight;
            labelUser.Location = new Point(12, 9);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(106, 26);
            labelUser.TabIndex = 9;
            labelUser.Text = "Username";
            // 
            // TeenagersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(562, 446);
            Controls.Add(labelUser);
            Controls.Add(buttonFinalizeOrder);
            Controls.Add(labelTextTeens);
            Controls.Add(checkedListBoxRomance);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TeenagersForm";
            Text = "TeenagersForm";
            Load += TeenagersForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTextTeens;
        private CheckedListBox checkedListBoxRomance;
        private Button buttonFinalizeOrder;
        private Label labelUser;
    }
}