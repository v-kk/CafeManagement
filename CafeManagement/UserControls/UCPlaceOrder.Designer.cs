
namespace CafeManagement.UserControls
{
    partial class UCPlaceOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cmbPOCategory = new Guna.UI.WinForms.GunaComboBox();
            this.txtPOSearch = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numPOQuantity = new Guna.UI.WinForms.GunaNumeric();
            this.btnPOAddtobag = new Guna.UI.WinForms.GunaButton();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnPORemove = new Guna.UI.WinForms.GunaButton();
            this.btnPOPrint = new Guna.UI.WinForms.GunaButton();
            this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotPrice = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblItemName = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Place Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Search Item";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Linen;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(10, 170);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(147, 328);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // cmbPOCategory
            // 
            this.cmbPOCategory.BackColor = System.Drawing.Color.Transparent;
            this.cmbPOCategory.BaseColor = System.Drawing.Color.Linen;
            this.cmbPOCategory.BorderColor = System.Drawing.Color.IndianRed;
            this.cmbPOCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPOCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPOCategory.FocusedColor = System.Drawing.Color.Empty;
            this.cmbPOCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPOCategory.ForeColor = System.Drawing.Color.Black;
            this.cmbPOCategory.FormattingEnabled = true;
            this.cmbPOCategory.Items.AddRange(new object[] {
            "Beverages",
            "Starters",
            "Chats",
            "South Indian",
            "North Indian",
            "Chinese",
            "Deserts"});
            this.cmbPOCategory.Location = new System.Drawing.Point(10, 70);
            this.cmbPOCategory.Name = "cmbPOCategory";
            this.cmbPOCategory.OnHoverItemBaseColor = System.Drawing.Color.IndianRed;
            this.cmbPOCategory.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbPOCategory.Size = new System.Drawing.Size(147, 26);
            this.cmbPOCategory.TabIndex = 4;
            this.cmbPOCategory.SelectedIndexChanged += new System.EventHandler(this.cmbPOCategory_SelectedIndexChanged);
            // 
            // txtPOSearch
            // 
            this.txtPOSearch.BackColor = System.Drawing.Color.Linen;
            this.txtPOSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPOSearch.FocusedLineColor = System.Drawing.Color.Red;
            this.txtPOSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPOSearch.LineColor = System.Drawing.Color.IndianRed;
            this.txtPOSearch.Location = new System.Drawing.Point(10, 119);
            this.txtPOSearch.Name = "txtPOSearch";
            this.txtPOSearch.PasswordChar = '\0';
            this.txtPOSearch.SelectedText = "";
            this.txtPOSearch.Size = new System.Drawing.Size(147, 30);
            this.txtPOSearch.TabIndex = 5;
            this.txtPOSearch.TextChanged += new System.EventHandler(this.txtPOSearch_TextChanged);
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.Firebrick;
            this.gunaSeparator1.Location = new System.Drawing.Point(177, 213);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(519, 10);
            this.gunaSeparator1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(217, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Item";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(482, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Unit Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(217, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(482, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Total Price";
            // 
            // numPOQuantity
            // 
            this.numPOQuantity.BaseColor = System.Drawing.Color.Linen;
            this.numPOQuantity.BorderColor = System.Drawing.Color.Silver;
            this.numPOQuantity.ButtonColor = System.Drawing.Color.MediumSlateBlue;
            this.numPOQuantity.ButtonForeColor = System.Drawing.Color.White;
            this.numPOQuantity.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPOQuantity.ForeColor = System.Drawing.Color.Black;
            this.numPOQuantity.Location = new System.Drawing.Point(220, 118);
            this.numPOQuantity.Maximum = ((long)(9999999));
            this.numPOQuantity.Minimum = ((long)(0));
            this.numPOQuantity.Name = "numPOQuantity";
            this.numPOQuantity.Size = new System.Drawing.Size(160, 30);
            this.numPOQuantity.TabIndex = 14;
            this.numPOQuantity.Text = "gunaNumeric1";
            this.numPOQuantity.Value = ((long)(0));
            this.numPOQuantity.ValueChanged += new System.EventHandler(this.numPOQuantity_ValueChanged);
            // 
            // btnPOAddtobag
            // 
            this.btnPOAddtobag.AnimationHoverSpeed = 0.07F;
            this.btnPOAddtobag.AnimationSpeed = 0.03F;
            this.btnPOAddtobag.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnPOAddtobag.BorderColor = System.Drawing.Color.Black;
            this.btnPOAddtobag.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPOAddtobag.FocusedColor = System.Drawing.Color.Empty;
            this.btnPOAddtobag.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPOAddtobag.ForeColor = System.Drawing.Color.White;
            this.btnPOAddtobag.Image = null;
            this.btnPOAddtobag.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPOAddtobag.Location = new System.Drawing.Point(379, 178);
            this.btnPOAddtobag.Name = "btnPOAddtobag";
            this.btnPOAddtobag.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnPOAddtobag.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPOAddtobag.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPOAddtobag.OnHoverImage = null;
            this.btnPOAddtobag.OnPressedColor = System.Drawing.Color.Black;
            this.btnPOAddtobag.Size = new System.Drawing.Size(105, 29);
            this.btnPOAddtobag.TabIndex = 15;
            this.btnPOAddtobag.Text = "Add to bag";
            this.btnPOAddtobag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPOAddtobag.Click += new System.EventHandler(this.btnPOAddtobag_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Linux Libertine Display G", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(375, 398);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 22);
            this.label8.TabIndex = 17;
            this.label8.Text = "Grand Total";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.LightSalmon;
            this.lblTotal.Font = new System.Drawing.Font("Linux Libertine Display G", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(389, 430);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(95, 33);
            this.lblTotal.TabIndex = 18;
            this.lblTotal.Text = "Rs.000";
            // 
            // btnPORemove
            // 
            this.btnPORemove.AnimationHoverSpeed = 0.07F;
            this.btnPORemove.AnimationSpeed = 0.03F;
            this.btnPORemove.BaseColor = System.Drawing.Color.IndianRed;
            this.btnPORemove.BorderColor = System.Drawing.Color.IndianRed;
            this.btnPORemove.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPORemove.FocusedColor = System.Drawing.Color.Empty;
            this.btnPORemove.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPORemove.ForeColor = System.Drawing.Color.White;
            this.btnPORemove.Image = null;
            this.btnPORemove.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPORemove.Location = new System.Drawing.Point(177, 456);
            this.btnPORemove.Name = "btnPORemove";
            this.btnPORemove.OnHoverBaseColor = System.Drawing.Color.LightCoral;
            this.btnPORemove.OnHoverBorderColor = System.Drawing.Color.LightCoral;
            this.btnPORemove.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPORemove.OnHoverImage = null;
            this.btnPORemove.OnPressedColor = System.Drawing.Color.Firebrick;
            this.btnPORemove.Size = new System.Drawing.Size(160, 42);
            this.btnPORemove.TabIndex = 19;
            this.btnPORemove.Text = "Remove Item";
            this.btnPORemove.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPORemove.Click += new System.EventHandler(this.btnPORemove_Click);
            // 
            // btnPOPrint
            // 
            this.btnPOPrint.AnimationHoverSpeed = 0.07F;
            this.btnPOPrint.AnimationSpeed = 0.03F;
            this.btnPOPrint.BaseColor = System.Drawing.Color.IndianRed;
            this.btnPOPrint.BorderColor = System.Drawing.Color.IndianRed;
            this.btnPOPrint.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPOPrint.FocusedColor = System.Drawing.Color.Empty;
            this.btnPOPrint.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPOPrint.ForeColor = System.Drawing.Color.White;
            this.btnPOPrint.Image = null;
            this.btnPOPrint.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPOPrint.Location = new System.Drawing.Point(540, 456);
            this.btnPOPrint.Name = "btnPOPrint";
            this.btnPOPrint.OnHoverBaseColor = System.Drawing.Color.LightCoral;
            this.btnPOPrint.OnHoverBorderColor = System.Drawing.Color.LightCoral;
            this.btnPOPrint.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPOPrint.OnHoverImage = null;
            this.btnPOPrint.OnPressedColor = System.Drawing.Color.Firebrick;
            this.btnPOPrint.Size = new System.Drawing.Size(156, 42);
            this.btnPOPrint.TabIndex = 20;
            this.btnPOPrint.Text = "Print Receipt";
            this.btnPOPrint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPOPrint.Click += new System.EventHandler(this.btnPOPrint_Click);
            // 
            // gunaDataGridView1
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.gunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridView1.BackgroundColor = System.Drawing.Color.Linen;
            this.gunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gunaDataGridView1.ColumnHeadersHeight = 25;
            this.gunaDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridView1.DefaultCellStyle = dataGridViewCellStyle9;
            this.gunaDataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gunaDataGridView1.EnableHeadersVisualStyles = false;
            this.gunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.Location = new System.Drawing.Point(177, 229);
            this.gunaDataGridView1.Name = "gunaDataGridView1";
            this.gunaDataGridView1.RowHeadersVisible = false;
            this.gunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView1.Size = new System.Drawing.Size(519, 166);
            this.gunaDataGridView1.TabIndex = 21;
            this.gunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.Linen;
            this.gunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Height = 25;
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
            // Column1
            // 
            this.Column1.HeaderText = "Item Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Unit Price";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price";
            this.Column4.Name = "Column4";
            // 
            // lblTotPrice
            // 
            this.lblTotPrice.AutoSize = true;
            this.lblTotPrice.BackColor = System.Drawing.Color.Bisque;
            this.lblTotPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotPrice.Location = new System.Drawing.Point(484, 119);
            this.lblTotPrice.Name = "lblTotPrice";
            this.lblTotPrice.Size = new System.Drawing.Size(72, 25);
            this.lblTotPrice.TabIndex = 22;
            this.lblTotPrice.Text = "000.00";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitPrice.Location = new System.Drawing.Point(486, 53);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(37, 21);
            this.lblUnitPrice.TabIndex = 23;
            this.lblUnitPrice.Text = "000";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblItemName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(220, 57);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(2, 23);
            this.lblItemName.TabIndex = 24;
            // 
            // UCPlaceOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.lblTotPrice);
            this.Controls.Add(this.gunaDataGridView1);
            this.Controls.Add(this.btnPOPrint);
            this.Controls.Add(this.btnPORemove);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnPOAddtobag);
            this.Controls.Add(this.numPOQuantity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gunaSeparator1);
            this.Controls.Add(this.txtPOSearch);
            this.Controls.Add(this.cmbPOCategory);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UCPlaceOrder";
            this.Size = new System.Drawing.Size(712, 511);
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private Guna.UI.WinForms.GunaComboBox cmbPOCategory;
        private Guna.UI.WinForms.GunaLineTextBox txtPOSearch;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaNumeric numPOQuantity;
        private Guna.UI.WinForms.GunaButton btnPOAddtobag;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotal;
        private Guna.UI.WinForms.GunaButton btnPORemove;
        private Guna.UI.WinForms.GunaButton btnPOPrint;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label lblTotPrice;
        private System.Windows.Forms.Label lblUnitPrice;
        private Guna.UI.WinForms.GunaLabel lblItemName;
    }
}
