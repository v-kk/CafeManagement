
namespace CafeManagement.UserControls
{
    partial class UCUpdateItems
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUISearch = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUIItemName = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtUIPrice = new Guna.UI.WinForms.GunaLineTextBox();
            this.btnUIUpdateItems = new Guna.UI.WinForms.GunaButton();
            this.txtUICategory = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Items";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(460, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search Items";
            // 
            // txtUISearch
            // 
            this.txtUISearch.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtUISearch.BorderColor = System.Drawing.Color.Bisque;
            this.txtUISearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUISearch.FocusedBaseColor = System.Drawing.Color.White;
            this.txtUISearch.FocusedBorderColor = System.Drawing.Color.Maroon;
            this.txtUISearch.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUISearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUISearch.Location = new System.Drawing.Point(463, 74);
            this.txtUISearch.Name = "txtUISearch";
            this.txtUISearch.PasswordChar = '\0';
            this.txtUISearch.SelectedText = "";
            this.txtUISearch.Size = new System.Drawing.Size(221, 35);
            this.txtUISearch.TabIndex = 2;
            this.txtUISearch.TextChanged += new System.EventHandler(this.txtUISearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Item Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(254, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(502, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Price";
            // 
            // txtUIItemName
            // 
            this.txtUIItemName.BackColor = System.Drawing.Color.Linen;
            this.txtUIItemName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUIItemName.FocusedLineColor = System.Drawing.Color.Red;
            this.txtUIItemName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUIItemName.LineColor = System.Drawing.Color.Firebrick;
            this.txtUIItemName.Location = new System.Drawing.Point(29, 384);
            this.txtUIItemName.Name = "txtUIItemName";
            this.txtUIItemName.PasswordChar = '\0';
            this.txtUIItemName.SelectedText = "";
            this.txtUIItemName.Size = new System.Drawing.Size(182, 32);
            this.txtUIItemName.TabIndex = 7;
            // 
            // txtUIPrice
            // 
            this.txtUIPrice.BackColor = System.Drawing.Color.Linen;
            this.txtUIPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUIPrice.FocusedLineColor = System.Drawing.Color.Red;
            this.txtUIPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUIPrice.LineColor = System.Drawing.Color.Firebrick;
            this.txtUIPrice.Location = new System.Drawing.Point(505, 384);
            this.txtUIPrice.Name = "txtUIPrice";
            this.txtUIPrice.PasswordChar = '\0';
            this.txtUIPrice.SelectedText = "";
            this.txtUIPrice.Size = new System.Drawing.Size(179, 32);
            this.txtUIPrice.TabIndex = 8;
            // 
            // btnUIUpdateItems
            // 
            this.btnUIUpdateItems.AnimationHoverSpeed = 0.07F;
            this.btnUIUpdateItems.AnimationSpeed = 0.03F;
            this.btnUIUpdateItems.BaseColor = System.Drawing.Color.Firebrick;
            this.btnUIUpdateItems.BorderColor = System.Drawing.Color.Firebrick;
            this.btnUIUpdateItems.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUIUpdateItems.FocusedColor = System.Drawing.Color.Empty;
            this.btnUIUpdateItems.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUIUpdateItems.ForeColor = System.Drawing.Color.White;
            this.btnUIUpdateItems.Image = null;
            this.btnUIUpdateItems.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUIUpdateItems.Location = new System.Drawing.Point(289, 434);
            this.btnUIUpdateItems.Name = "btnUIUpdateItems";
            this.btnUIUpdateItems.OnHoverBaseColor = System.Drawing.Color.IndianRed;
            this.btnUIUpdateItems.OnHoverBorderColor = System.Drawing.Color.IndianRed;
            this.btnUIUpdateItems.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUIUpdateItems.OnHoverImage = null;
            this.btnUIUpdateItems.OnPressedColor = System.Drawing.Color.Red;
            this.btnUIUpdateItems.Size = new System.Drawing.Size(128, 42);
            this.btnUIUpdateItems.TabIndex = 10;
            this.btnUIUpdateItems.Text = "Update Item";
            this.btnUIUpdateItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUIUpdateItems.Click += new System.EventHandler(this.btnUIUpdateItems_Click);
            // 
            // txtUICategory
            // 
            this.txtUICategory.BackColor = System.Drawing.Color.Linen;
            this.txtUICategory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUICategory.FocusedLineColor = System.Drawing.Color.Red;
            this.txtUICategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUICategory.LineColor = System.Drawing.Color.Firebrick;
            this.txtUICategory.Location = new System.Drawing.Point(257, 384);
            this.txtUICategory.Name = "txtUICategory";
            this.txtUICategory.PasswordChar = '\0';
            this.txtUICategory.SelectedText = "";
            this.txtUICategory.Size = new System.Drawing.Size(193, 32);
            this.txtUICategory.TabIndex = 11;
            // 
            // gunaDataGridView1
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridView1.BackgroundColor = System.Drawing.Color.Linen;
            this.gunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gunaDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.gunaDataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gunaDataGridView1.EnableHeadersVisualStyles = false;
            this.gunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.Location = new System.Drawing.Point(29, 126);
            this.gunaDataGridView1.Name = "gunaDataGridView1";
            this.gunaDataGridView1.RowHeadersVisible = false;
            this.gunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView1.Size = new System.Drawing.Size(655, 215);
            this.gunaDataGridView1.TabIndex = 12;
            this.gunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.Linen;
            this.gunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Height = 21;
            this.gunaDataGridView1.ThemeStyle.ReadOnly = false;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDataGridView1_CellClick);
            // 
            // UCUpdateItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.Controls.Add(this.gunaDataGridView1);
            this.Controls.Add(this.txtUICategory);
            this.Controls.Add(this.btnUIUpdateItems);
            this.Controls.Add(this.txtUIPrice);
            this.Controls.Add(this.txtUIItemName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUISearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UCUpdateItems";
            this.Size = new System.Drawing.Size(712, 511);
            this.Load += new System.EventHandler(this.UCUpdateItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox txtUISearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaLineTextBox txtUIItemName;
        private Guna.UI.WinForms.GunaLineTextBox txtUIPrice;
        private Guna.UI.WinForms.GunaButton btnUIUpdateItems;
        private Guna.UI.WinForms.GunaLineTextBox txtUICategory;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridView1;
    }
}
