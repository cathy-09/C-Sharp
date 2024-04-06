namespace MyBookstore
{
    partial class ChildrenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChildrenForm));
            checkedListBoxFairyTales = new CheckedListBox();
            labelTextChildren = new Label();
            buttonFinalizeOrder = new Button();
            labelUser = new Label();
            SuspendLayout();
            // 
            // checkedListBoxFairyTales
            // 
            checkedListBoxFairyTales.Font = new Font("Corbel", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            checkedListBoxFairyTales.FormattingEnabled = true;
            checkedListBoxFairyTales.Location = new Point(12, 132);
            checkedListBoxFairyTales.Name = "checkedListBoxFairyTales";
            checkedListBoxFairyTales.Size = new Size(563, 264);
            checkedListBoxFairyTales.TabIndex = 0;
            // 
            // labelTextChildren
            // 
            labelTextChildren.AutoSize = true;
            labelTextChildren.BackColor = Color.White;
            labelTextChildren.Font = new Font("Corbel", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelTextChildren.Location = new Point(12, 44);
            labelTextChildren.Name = "labelTextChildren";
            labelTextChildren.Size = new Size(563, 78);
            labelTextChildren.TabIndex = 1;
            labelTextChildren.Text = "Здравей! \r\nВ момента предлагаме тези приказки:";
            labelTextChildren.TextAlign = ContentAlignment.TopCenter;
            // 
            // buttonFinalizeOrder
            // 
            buttonFinalizeOrder.BackColor = Color.Lavender;
            buttonFinalizeOrder.Font = new Font("Corbel", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFinalizeOrder.Location = new Point(12, 402);
            buttonFinalizeOrder.Name = "buttonFinalizeOrder";
            buttonFinalizeOrder.Size = new Size(566, 41);
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
            labelUser.TabIndex = 8;
            labelUser.Text = "Username";
            // 
            // ChildrenForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(590, 455);
            Controls.Add(labelUser);
            Controls.Add(buttonFinalizeOrder);
            Controls.Add(labelTextChildren);
            Controls.Add(checkedListBoxFairyTales);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ChildrenForm";
            Text = "ChildrenForm";
            Load += ChildrenForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkedListBoxFairyTales;
        private Label labelTextChildren;
        private Button buttonFinalizeOrder;
        private Label labelUser;
    }
}