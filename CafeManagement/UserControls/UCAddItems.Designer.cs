
namespace CafeManagement.UserControls
{
    partial class UCAddItems
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAIAddItem = new Guna.UI.WinForms.GunaButton();
            this.txtAIItemName = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtAIPrice = new Guna.UI.WinForms.GunaLineTextBox();
            this.cmbAICategory = new Guna.UI.WinForms.GunaComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Peru;
            this.label1.Location = new System.Drawing.Point(215, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add new Items";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(179, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(179, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Item Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(179, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price";
            // 
            // btnAIAddItem
            // 
            this.btnAIAddItem.AnimationHoverSpeed = 0.07F;
            this.btnAIAddItem.AnimationSpeed = 0.03F;
            this.btnAIAddItem.BaseColor = System.Drawing.Color.DarkRed;
            this.btnAIAddItem.BorderColor = System.Drawing.Color.Black;
            this.btnAIAddItem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAIAddItem.FocusedColor = System.Drawing.Color.Empty;
            this.btnAIAddItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAIAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAIAddItem.Image = null;
            this.btnAIAddItem.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAIAddItem.Location = new System.Drawing.Point(277, 411);
            this.btnAIAddItem.Name = "btnAIAddItem";
            this.btnAIAddItem.OnHoverBaseColor = System.Drawing.Color.IndianRed;
            this.btnAIAddItem.OnHoverBorderColor = System.Drawing.Color.IndianRed;
            this.btnAIAddItem.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAIAddItem.OnHoverImage = null;
            this.btnAIAddItem.OnPressedColor = System.Drawing.Color.Red;
            this.btnAIAddItem.Size = new System.Drawing.Size(160, 42);
            this.btnAIAddItem.TabIndex = 4;
            this.btnAIAddItem.Text = "Add Item";
            this.btnAIAddItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAIAddItem.Click += new System.EventHandler(this.btnAIAddItem_Click);
            // 
            // txtAIItemName
            // 
            this.txtAIItemName.BackColor = System.Drawing.Color.Bisque;
            this.txtAIItemName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAIItemName.FocusedLineColor = System.Drawing.Color.Red;
            this.txtAIItemName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAIItemName.ForeColor = System.Drawing.Color.Black;
            this.txtAIItemName.LineColor = System.Drawing.Color.IndianRed;
            this.txtAIItemName.Location = new System.Drawing.Point(179, 240);
            this.txtAIItemName.Name = "txtAIItemName";
            this.txtAIItemName.PasswordChar = '\0';
            this.txtAIItemName.SelectedText = "";
            this.txtAIItemName.Size = new System.Drawing.Size(336, 32);
            this.txtAIItemName.TabIndex = 6;
            // 
            // txtAIPrice
            // 
            this.txtAIPrice.BackColor = System.Drawing.Color.Bisque;
            this.txtAIPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAIPrice.FocusedLineColor = System.Drawing.Color.Red;
            this.txtAIPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAIPrice.ForeColor = System.Drawing.Color.Black;
            this.txtAIPrice.LineColor = System.Drawing.Color.IndianRed;
            this.txtAIPrice.Location = new System.Drawing.Point(179, 333);
            this.txtAIPrice.Name = "txtAIPrice";
            this.txtAIPrice.PasswordChar = '\0';
            this.txtAIPrice.SelectedText = "";
            this.txtAIPrice.Size = new System.Drawing.Size(336, 32);
            this.txtAIPrice.TabIndex = 7;
            // 
            // cmbAICategory
            // 
            this.cmbAICategory.BackColor = System.Drawing.Color.Transparent;
            this.cmbAICategory.BaseColor = System.Drawing.Color.Bisque;
            this.cmbAICategory.BorderColor = System.Drawing.Color.IndianRed;
            this.cmbAICategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAICategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAICategory.FocusedColor = System.Drawing.Color.Empty;
            this.cmbAICategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAICategory.ForeColor = System.Drawing.Color.Black;
            this.cmbAICategory.FormattingEnabled = true;
            this.cmbAICategory.Items.AddRange(new object[] {
            "Beverages",
            "Starters",
            "Chats",
            "South Indian",
            "North Indian",
            "Chinese",
            "Deserts"});
            this.cmbAICategory.Location = new System.Drawing.Point(179, 152);
            this.cmbAICategory.Name = "cmbAICategory";
            this.cmbAICategory.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbAICategory.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbAICategory.Size = new System.Drawing.Size(336, 30);
            this.cmbAICategory.TabIndex = 8;
            // 
            // UCAddItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.Controls.Add(this.cmbAICategory);
            this.Controls.Add(this.txtAIPrice);
            this.Controls.Add(this.txtAIItemName);
            this.Controls.Add(this.btnAIAddItem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.Name = "UCAddItems";
            this.Size = new System.Drawing.Size(712, 511);
            this.Leave += new System.EventHandler(this.UCAddItems_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaButton btnAIAddItem;
        private Guna.UI.WinForms.GunaLineTextBox txtAIItemName;
        private Guna.UI.WinForms.GunaLineTextBox txtAIPrice;
        private Guna.UI.WinForms.GunaComboBox cmbAICategory;
    }
}
