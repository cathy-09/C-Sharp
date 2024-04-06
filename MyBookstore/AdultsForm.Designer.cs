namespace MyBookstore
{
    partial class AdultsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdultsForm));
            labelTextAdults = new Label();
            checkedListBoxScience = new CheckedListBox();
            buttonFinalizeOrder = new Button();
            labelUser = new Label();
            SuspendLayout();
            // 
            // labelTextAdults
            // 
            labelTextAdults.AutoSize = true;
            labelTextAdults.BackColor = Color.White;
            labelTextAdults.Font = new Font("Corbel", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelTextAdults.Location = new Point(8, 40);
            labelTextAdults.Name = "labelTextAdults";
            labelTextAdults.Size = new Size(621, 78);
            labelTextAdults.TabIndex = 5;
            labelTextAdults.Text = "Здравей! \r\nВ момента предлагаме тези научни книги:";
            labelTextAdults.TextAlign = ContentAlignment.TopCenter;
            // 
            // checkedListBoxScience
            // 
            checkedListBoxScience.Font = new Font("Corbel", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            checkedListBoxScience.FormattingEnabled = true;
            checkedListBoxScience.Location = new Point(8, 128);
            checkedListBoxScience.Name = "checkedListBoxScience";
            checkedListBoxScience.Size = new Size(621, 264);
            checkedListBoxScience.TabIndex = 4;
            // 
            // buttonFinalizeOrder
            // 
            buttonFinalizeOrder.BackColor = Color.Lavender;
            buttonFinalizeOrder.Font = new Font("Corbel", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFinalizeOrder.Location = new Point(9, 400);
            buttonFinalizeOrder.Name = "buttonFinalizeOrder";
            buttonFinalizeOrder.Size = new Size(620, 41);
            buttonFinalizeOrder.TabIndex = 6;
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
            labelUser.Location = new Point(8, 9);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(106, 26);
            labelUser.TabIndex = 7;
            labelUser.Text = "Username";
            // 
            // AdultsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(641, 452);
            Controls.Add(labelUser);
            Controls.Add(buttonFinalizeOrder);
            Controls.Add(labelTextAdults);
            Controls.Add(checkedListBoxScience);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdultsForm";
            Text = "AdultsForm";
            Load += AdultsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTextAdults;
        private CheckedListBox checkedListBoxScience;
        private Button buttonFinalizeOrder;
        private Label labelUser;
    }
}