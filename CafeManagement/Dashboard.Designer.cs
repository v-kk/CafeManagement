
namespace CafeManagement
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            Guna.UI.Animation.Animation animation3 = new Guna.UI.Animation.Animation();
            Guna.UI.Animation.Animation animation2 = new Guna.UI.Animation.Animation();
            Guna.UI.Animation.Animation animation4 = new Guna.UI.Animation.Animation();
            Guna.UI.Animation.Animation animation1 = new Guna.UI.Animation.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new Guna.UI.WinForms.GunaCircleButton();
            this.gunaButton5 = new Guna.UI.WinForms.GunaButton();
            this.btnRemoveItems = new Guna.UI.WinForms.GunaButton();
            this.btnUpdateItems = new Guna.UI.WinForms.GunaButton();
            this.btnAddItems = new Guna.UI.WinForms.GunaButton();
            this.btnPlaceOrder = new Guna.UI.WinForms.GunaButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gunaTransition1 = new Guna.UI.WinForms.GunaTransition(this.components);
            this.ucUpdateItems1 = new CafeManagement.UserControls.UCUpdateItems();
            this.ucRemoveItems1 = new CafeManagement.UserControls.UCRemoveItems();
            this.ucPlaceOrder1 = new CafeManagement.UserControls.UCPlaceOrder();
            this.ucAddItems1 = new CafeManagement.UserControls.UCAddItems();
            this.ucWelcome1 = new CafeManagement.UserControls.UCWelcome();
            this.gunaTransition2 = new Guna.UI.WinForms.GunaTransition(this.components);
            this.gunaTransition3 = new Guna.UI.WinForms.GunaTransition(this.components);
            this.gunaTransition4 = new Guna.UI.WinForms.GunaTransition(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.gunaButton5);
            this.panel1.Controls.Add(this.btnRemoveItems);
            this.panel1.Controls.Add(this.btnUpdateItems);
            this.panel1.Controls.Add(this.btnAddItems);
            this.panel1.Controls.Add(this.btnPlaceOrder);
            this.gunaTransition4.SetDecoration(this.panel1, Guna.UI.Animation.DecorationType.None);
            this.gunaTransition1.SetDecoration(this.panel1, Guna.UI.Animation.DecorationType.None);
            this.gunaTransition2.SetDecoration(this.panel1, Guna.UI.Animation.DecorationType.None);
            this.gunaTransition3.SetDecoration(this.panel1, Guna.UI.Animation.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 511);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.AnimationHoverSpeed = 0.07F;
            this.btnExit.AnimationSpeed = 0.03F;
            this.btnExit.BaseColor = System.Drawing.Color.Firebrick;
            this.btnExit.BorderColor = System.Drawing.Color.Black;
            this.gunaTransition4.SetDecoration(this.btnExit, Guna.UI.Animation.DecorationType.None);
            this.gunaTransition2.SetDecoration(this.btnExit, Guna.UI.Animation.DecorationType.None);
            this.gunaTransition1.SetDecoration(this.btnExit, Guna.UI.Animation.DecorationType.None);
            this.gunaTransition3.SetDecoration(this.btnExit, Guna.UI.Animation.DecorationType.None);
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExit.FocusedColor = System.Drawing.Color.Empty;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = null;
            this.btnExit.ImageSize = new System.Drawing.Size(52, 52);
            this.btnExit.Location = new System.Drawing.Point(4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBaseColor = System.Drawing.Color.IndianRed;
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExit.OnHoverImage = null;
            this.btnExit.OnPressedColor = System.Drawing.Color.Black;
            this.btnExit.Size = new System.Drawing.Size(25, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "X";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gunaButton5
            // 
            this.gunaButton5.AnimationHoverSpeed = 0.07F;
            this.gunaButton5.AnimationSpeed = 0.03F;
            this.gunaButton5.BackColor = System.Drawing.Color.LightCoral;
            this.gunaButton5.BaseColor = System.Drawing.Color.Firebrick;
            this.gunaButton5.BorderColor = System.Drawing.Color.Black;
            this.gunaTransition4.SetDecoration(this.gunaButton5, Guna.UI.Animation.DecorationType.None);
            this.gunaTransition2.SetDecoration(this.gunaButton5, Guna.UI.Animation.DecorationType.None);
            this.gunaTransition1.SetDecoration(this.gunaButton5, Guna.UI.Animation.DecorationType.None);
            this.gunaTransition3.SetDecoration(this.gunaButton5, Guna.UI.Animation.DecorationType.None);
            this.gunaButton5.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton5.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton5.Font = new System.Drawing.Font("Sitka Text", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton5.ForeColor = System.Drawing.Color.White;
            this.gunaButton5.Image = null;
            this.gunaButton5.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton5.Location = new System.Drawing.Point(111, 467);
            this.gunaButton5.Name = "gunaButton5";
            this.gunaButton5.OnHoverBaseColor = System.Drawing.Color.IndianRed;
            this.gunaButton5.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton5.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton5.OnHoverImage = null;
            this.gunaButton5.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton5.Size = new System.Drawing.Size(104, 30);
            this.gunaButton5.TabIndex = 4;
            this.gunaButton5.Text = "Log Out";
            this.gunaButton5.Click += new System.EventHandler(this.gunaButton5_Click);
            // 
            // btnRemoveItems
            // 
            this.btnRemoveItems.AnimationHoverSpeed = 0.07F;
            this.btnRemoveItems.AnimationSpeed = 0.03F;
            this.btnRemoveItems.BackColor = System.Drawing.Color.LightCoral;
            this.btnRemoveItems.BaseColor = System.Drawing.Color.IndianRed;
            this.btnRemoveItems.BorderColor = System.Drawing.Color.Black;
            this.gunaTransition4.SetDecoration(this.btnRemoveItems, Guna.UI.Animation.DecorationType.None);
            this.gunaTransition2.SetDecoration(this.btnRemoveItems, Guna.UI.Animation.DecorationType.None);
            this.gunaTransition1.SetDecoration(this.btnRemoveItems, Guna.UI.Animation.DecorationType.None);
            this.gunaTransition3.SetDecoration(this.btnRemoveItems, Guna.UI.Animation.DecorationType.None);
            this.btnRemoveItems.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRemoveItems.FocusedColor = System.Drawing.Color.Empty;
            this.btnRemoveItems.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItems.ForeColor = System.Drawing.Color.White;
            this.btnRemoveItems.Image = null;
            this.btnRemoveItems.ImageSize = new System.Drawing.Size(20, 20);
            this.btnRemoveItems.Location = new System.Drawing.Point(55, 270);
            this.btnRemoveItems.Name = "btnRemoveItems";
            this.btnRemoveItems.OnHoverBaseColor = System.Drawing.Color.Goldenrod;
            this.btnRemoveItems.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRemoveItems.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRemoveItems.OnHoverImage = null;
            this.btnRemoveItems.OnPressedColor = System.Drawing.Color.Red;
            this.btnRemoveItems.Size = new System.Drawing.Size(160, 42);
            this.btnRemoveItems.TabIndex = 3;
            this.btnRemoveItems.Text = "Remove Items";
            this.btnRemoveItems.Click += new System.EventHandler(this.btnRemoveItems_Click);
            // 
            // btnUpdateItems
            // 
            this.btnUpdateItems.AnimationHoverSpeed = 0.07F;
            this.btnUpdateItems.AnimationSpeed = 0.03F;
            this.btnUpdateItems.BackColor = System.Drawing.Color.LightCoral;
            this.btnUpdateItems.BaseColor = System.Drawing.Color.IndianRed;
            this.btnUpdateItems.BorderColor = System.Drawing.Color.Black;
            this.gunaTransition4.SetDecoration(this.btnUpdateItems, Guna.UI.Animation.DecorationType.None);
            this.gunaTransition2.SetDecoration(this.btnUpdateItems, Guna.UI.Animation.DecorationType.None);
            this.gunaTransition1.SetDecoration(this.btnUpdateItems, Guna.UI.Animation.DecorationType.None);
            this.gunaTransition3.SetDecoration(this.btnUpdateItems, Guna.UI.Animation.DecorationType.None);
            this.btnUpdateItems.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdateItems.FocusedColor = System.Drawing.Color.Empty;
            this.btnUpdateItems.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateItems.ForeColor = System.Drawing.Color.White;
            this.btnUpdateItems.Image = null;
            this.btnUpdateItems.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUpdateItems.Location = new System.Drawing.Point(55, 212);
            this.btnUpdateItems.Name = "btnUpdateItems";
            this.btnUpdateItems.OnHoverBaseColor = System.Drawing.Color.Goldenrod;
            this.btnUpdateItems.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUpdateItems.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpdateItems.OnHoverImage = null;
            this.btnUpdateItems.OnPressedColor = System.Drawing.Color.Red;
            this.btnUpdateItems.Size = new System.Drawing.Size(160, 42);
            this.btnUpdateItems.TabIndex = 2;
            this.btnUpdateItems.Text = "Update Items";
            this.btnUpdateItems.Click += new System.EventHandler(this.btnUpdateItems_Click);
            // 
            // btnAddItems
            // 
            this.btnAddItems.AnimationHoverSpeed = 0.07F;
            this.btnAddItems.AnimationSpeed = 0.03F;
            this.btnAddItems.BackColor = System.Drawing.Color.LightCoral;
            this.btnAddItems.BaseColor = System.Drawing.Color.IndianRed;
            this.btnAddItems.BorderColor = System.Drawing.Color.Black;
            this.gunaTransition4.SetDecoration(this.btnAddItems, Guna.UI.Animation.DecorationType.None);
            this.gunaTransition2.SetDecoration(this.btnAddItems, Guna.UI.Animation.DecorationType.None);
            this.gunaTransition1.SetDecoration(this.btnAddItems, Guna.UI.Animation.DecorationType.None);
            this.gunaTransition3.SetDecoration(this.btnAddItems, Guna.UI.Animation.DecorationType.None);
            this.btnAddItems.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddItems.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddItems.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItems.ForeColor = System.Drawing.Color.White;
            this.btnAddItems.Image = null;
            this.btnAddItems.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddItems.Location = new System.Drawing.Point(55, 152);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.OnHoverBaseColor = System.Drawing.Color.Goldenrod;
            this.btnAddItems.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddItems.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddItems.OnHoverImage = null;
            this.btnAddItems.OnPressedColor = System.Drawing.Color.Red;
            this.btnAddItems.Size = new System.Drawing.Size(160, 42);
            this.btnAddItems.TabIndex = 1;
            this.btnAddItems.Text = "Add Items";
            this.btnAddItems.Click += new System.EventHandler(this.btnAddItems_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.AnimationHoverSpeed = 0.07F;
            this.btnPlaceOrder.AnimationSpeed = 0.03F;
            this.btnPlaceOrder.BackColor = System.Drawing.Color.White;
            this.btnPlaceOrder.BaseColor = System.Drawing.Color.IndianRed;
            this.btnPlaceOrder.BorderColor = System.Drawing.Color.Black;
            this.gunaTransition4.SetDecoration(this.btnPlaceOrder, Guna.UI.Animation.DecorationType.None);
            this.gunaTransition2.SetDecoration(this.btnPlaceOrder, Guna.UI.Animation.DecorationType.None);
            this.gunaTransition1.SetDecoration(this.btnPlaceOrder, Guna.UI.Animation.DecorationType.None);
            this.gunaTransition3.SetDecoration(this.btnPlaceOrder, Guna.UI.Animation.DecorationType.None);
            this.btnPlaceOrder.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPlaceOrder.FocusedColor = System.Drawing.Color.Empty;
            this.btnPlaceOrder.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.ForeColor = System.Drawing.Color.White;
            this.btnPlaceOrder.Image = null;
            this.btnPlaceOrder.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPlaceOrder.Location = new System.Drawing.Point(55, 87);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.OnHoverBaseColor = System.Drawing.Color.Goldenrod;
            this.btnPlaceOrder.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPlaceOrder.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPlaceOrder.OnHoverImage = null;
            this.btnPlaceOrder.OnPressedColor = System.Drawing.Color.Red;
            this.btnPlaceOrder.Size = new System.Drawing.Size(160, 42);
            this.btnPlaceOrder.TabIndex = 0;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.ucUpdateItems1);
            this.panel2.Controls.Add(this.ucRemoveItems1);
            this.panel2.Controls.Add(this.ucPlaceOrder1);
            this.panel2.Controls.Add(this.ucAddItems1);
            this.panel2.Controls.Add(this.ucWelcome1);
            this.gunaTransition4.SetDecoration(this.panel2, Guna.UI.Animation.DecorationType.None);
            this.gunaTransition1.SetDecoration(this.panel2, Guna.UI.Animation.DecorationType.None);
            this.gunaTransition2.SetDecoration(this.panel2, Guna.UI.Animation.DecorationType.None);
            this.gunaTransition3.SetDecoration(this.panel2, Guna.UI.Animation.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(205, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(712, 511);
            this.panel2.TabIndex = 1;
            // 
            // gunaTransition1
            // 
            this.gunaTransition1.AnimationType = Guna.UI.Animation.AnimationType.HorizSlide;
            this.gunaTransition1.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.gunaTransition1.DefaultAnimation = animation3;
            // 
            // ucUpdateItems1
            // 
            this.ucUpdateItems1.BackColor = System.Drawing.Color.Bisque;
            this.gunaTransition3.SetDecoration(this.ucUpdateItems1, Guna.UI.Animation.DecorationType.None);
            this.gunaTransition1.SetDecoration(this.ucUpdateItems1, Guna.UI.Animation.DecorationType.None);
            this.gunaTransition2.SetDecoration(this.ucUpdateItems1, Guna.UI.Animation.DecorationType.None);
            this.gunaTransition4.SetDecoration(this.ucUpdateItems1, Guna.UI.Animation.DecorationType.None);
            this.ucUpdateItems1.Location = new System.Drawing.Point(0, 0);
            this.ucUpdateItems1.Name = "ucUpdateItems1";
            this.ucUpdateItems1.Size = new System.Drawing.Size(712, 511);
            this.ucUpdateItems1.TabIndex = 4;
            // 
            // ucRemoveItems1
            // 
            this.ucRemoveItems1.BackColor = System.Drawing.Color.Bisque;
            this.gunaTransition3.SetDecoration(this.ucRemoveItems1, Guna.UI.Animation.DecorationType.None);
            this.gunaTransition1.SetDecoration(this.ucRemoveItems1, Guna.UI.Animation.DecorationType.None);
            this.gunaTransition2.SetDecoration(this.ucRemoveItems1, Guna.UI.Animation.DecorationType.None);
            this.gunaTransition4.SetDecoration(this.ucRemoveItems1, Guna.UI.Animation.DecorationType.None);
            this.ucRemoveItems1.Location = new System.Drawing.Point(0, 0);
            this.ucRemoveItems1.Name = "ucRemoveItems1";
            this.ucRemoveItems1.Size = new System.Drawing.Size(712, 511);
            this.ucRemoveItems1.TabIndex = 3;
            // 
            // ucPlaceOrder1
            // 
            this.ucPlaceOrder1.BackColor = System.Drawing.Color.Bisque;
            this.gunaTransition3.SetDecoration(this.ucPlaceOrder1, Guna.UI.Animation.DecorationType.None);
            this.gunaTransition1.SetDecoration(this.ucPlaceOrder1, Guna.UI.Animation.DecorationType.None);
            this.gunaTransition2.SetDecoration(this.ucPlaceOrder1, Guna.UI.Animation.DecorationType.None);
            this.gunaTransition4.SetDecoration(this.ucPlaceOrder1, Guna.UI.Animation.DecorationType.None);
            this.ucPlaceOrder1.Location = new System.Drawing.Point(0, 0);
            this.ucPlaceOrder1.Name = "ucPlaceOrder1";
            this.ucPlaceOrder1.Size = new System.Drawing.Size(712, 511);
            this.ucPlaceOrder1.TabIndex = 2;
            // 
            // ucAddItems1
            // 
            this.ucAddItems1.BackColor = System.Drawing.Color.Bisque;
            this.gunaTransition3.SetDecoration(this.ucAddItems1, Guna.UI.Animation.DecorationType.None);
            this.gunaTransition1.SetDecoration(this.ucAddItems1, Guna.UI.Animation.DecorationType.None);
            this.gunaTransition2.SetDecoration(this.ucAddItems1, Guna.UI.Animation.DecorationType.None);
            this.gunaTransition4.SetDecoration(this.ucAddItems1, Guna.UI.Animation.DecorationType.None);
            this.ucAddItems1.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.ucAddItems1.Location = new System.Drawing.Point(0, 0);
            this.ucAddItems1.Name = "ucAddItems1";
            this.ucAddItems1.Size = new System.Drawing.Size(712, 511);
            this.ucAddItems1.TabIndex = 1;
            // 
            // ucWelcome1
            // 
            this.ucWelcome1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gunaTransition3.SetDecoration(this.ucWelcome1, Guna.UI.Animation.DecorationType.None);
            this.gunaTransition1.SetDecoration(this.ucWelcome1, Guna.UI.Animation.DecorationType.None);
            this.gunaTransition2.SetDecoration(this.ucWelcome1, Guna.UI.Animation.DecorationType.None);
            this.gunaTransition4.SetDecoration(this.ucWelcome1, Guna.UI.Animation.DecorationType.None);
            this.ucWelcome1.Location = new System.Drawing.Point(0, 0);
            this.ucWelcome1.Name = "ucWelcome1";
            this.ucWelcome1.Size = new System.Drawing.Size(712, 511);
            this.ucWelcome1.TabIndex = 0;
            // 
            // gunaTransition2
            // 
            this.gunaTransition2.AnimationType = Guna.UI.Animation.AnimationType.HorizSlide;
            this.gunaTransition2.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.gunaTransition2.DefaultAnimation = animation2;
            // 
            // gunaTransition3
            // 
            this.gunaTransition3.AnimationType = Guna.UI.Animation.AnimationType.HorizSlide;
            this.gunaTransition3.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.gunaTransition3.DefaultAnimation = animation4;
            // 
            // gunaTransition4
            // 
            this.gunaTransition4.AnimationType = Guna.UI.Animation.AnimationType.HorizSlide;
            this.gunaTransition4.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.gunaTransition4.DefaultAnimation = animation1;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(929, 535);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.gunaTransition2.SetDecoration(this, Guna.UI.Animation.DecorationType.None);
            this.gunaTransition1.SetDecoration(this, Guna.UI.Animation.DecorationType.None);
            this.gunaTransition4.SetDecoration(this, Guna.UI.Animation.DecorationType.None);
            this.gunaTransition3.SetDecoration(this, Guna.UI.Animation.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaCircleButton btnExit;
        private Guna.UI.WinForms.GunaButton gunaButton5;
        private Guna.UI.WinForms.GunaButton btnRemoveItems;
        private Guna.UI.WinForms.GunaButton btnUpdateItems;
        private Guna.UI.WinForms.GunaButton btnAddItems;
        private Guna.UI.WinForms.GunaButton btnPlaceOrder;
        private UserControls.UCWelcome ucWelcome1;
        private UserControls.UCAddItems ucAddItems1;
        private UserControls.UCUpdateItems ucUpdateItems1;
        private UserControls.UCRemoveItems ucRemoveItems1;
        private UserControls.UCPlaceOrder ucPlaceOrder1;
        private Guna.UI.WinForms.GunaTransition gunaTransition1;
        private Guna.UI.WinForms.GunaTransition gunaTransition4;
        private Guna.UI.WinForms.GunaTransition gunaTransition2;
        private Guna.UI.WinForms.GunaTransition gunaTransition3;
    }
}