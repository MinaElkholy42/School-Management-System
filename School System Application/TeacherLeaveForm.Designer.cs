namespace School_System_Application
{
    partial class TeacherLeaveForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherLeaveForm));
            this.FormDrag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.OptionsLabel = new System.Windows.Forms.Label();
            this.MinimizationButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.CloseButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.FormTransition = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.FormElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.BackGroundPictureBox = new System.Windows.Forms.PictureBox();
            this.BarCodeIDTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.RecordButton = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.ErrorLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackGroundPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FormDrag
            // 
            this.FormDrag.TargetControl = this.HeaderPanel;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.HeaderPanel.Controls.Add(this.OptionsLabel);
            this.HeaderPanel.Controls.Add(this.MinimizationButton);
            this.HeaderPanel.Controls.Add(this.CloseButton);
            this.HeaderPanel.Controls.Add(this.LogoPictureBox);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1220, 94);
            this.HeaderPanel.TabIndex = 7;
            // 
            // OptionsLabel
            // 
            this.OptionsLabel.AutoSize = true;
            this.OptionsLabel.Font = new System.Drawing.Font("Algerian", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.OptionsLabel.Location = new System.Drawing.Point(355, 25);
            this.OptionsLabel.Name = "OptionsLabel";
            this.OptionsLabel.Size = new System.Drawing.Size(510, 45);
            this.OptionsLabel.TabIndex = 14;
            this.OptionsLabel.Text = "Record Teacher Leave";
            // 
            // MinimizationButton
            // 
            this.MinimizationButton.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("MinimizationButton.CheckedState.Image")));
            this.MinimizationButton.CheckedState.ImageSize = new System.Drawing.Size(23, 23);
            this.MinimizationButton.CheckedState.Parent = this.MinimizationButton;
            this.MinimizationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizationButton.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("MinimizationButton.HoverState.Image")));
            this.MinimizationButton.HoverState.ImageSize = new System.Drawing.Size(23, 23);
            this.MinimizationButton.HoverState.Parent = this.MinimizationButton;
            this.MinimizationButton.Image = ((System.Drawing.Image)(resources.GetObject("MinimizationButton.Image")));
            this.MinimizationButton.ImageSize = new System.Drawing.Size(23, 23);
            this.MinimizationButton.Location = new System.Drawing.Point(1096, 8);
            this.MinimizationButton.Name = "MinimizationButton";
            this.MinimizationButton.PressedState.Parent = this.MinimizationButton;
            this.MinimizationButton.Size = new System.Drawing.Size(56, 76);
            this.MinimizationButton.TabIndex = 11;
            this.MinimizationButton.TabStop = false;
            this.MinimizationButton.Click += new System.EventHandler(this.MinimizationButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.CheckedState.Image")));
            this.CloseButton.CheckedState.ImageSize = new System.Drawing.Size(23, 23);
            this.CloseButton.CheckedState.Parent = this.CloseButton;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.HoverState.Image")));
            this.CloseButton.HoverState.ImageSize = new System.Drawing.Size(23, 23);
            this.CloseButton.HoverState.Parent = this.CloseButton;
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.ImageSize = new System.Drawing.Size(23, 23);
            this.CloseButton.Location = new System.Drawing.Point(1147, 8);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.PressedState.Parent = this.CloseButton;
            this.CloseButton.Size = new System.Drawing.Size(56, 76);
            this.CloseButton.TabIndex = 10;
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPictureBox.Image")));
            this.LogoPictureBox.Location = new System.Drawing.Point(24, 3);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(90, 90);
            this.LogoPictureBox.TabIndex = 0;
            this.LogoPictureBox.TabStop = false;
            // 
            // FormTransition
            // 
            this.FormTransition.Interval = 460;
            // 
            // FormElipse
            // 
            this.FormElipse.ElipseRadius = 80;
            this.FormElipse.TargetControl = this;
            // 
            // BackGroundPictureBox
            // 
            this.BackGroundPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackGroundPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("BackGroundPictureBox.Image")));
            this.BackGroundPictureBox.Location = new System.Drawing.Point(0, 94);
            this.BackGroundPictureBox.Name = "BackGroundPictureBox";
            this.BackGroundPictureBox.Size = new System.Drawing.Size(1220, 450);
            this.BackGroundPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackGroundPictureBox.TabIndex = 8;
            this.BackGroundPictureBox.TabStop = false;
            // 
            // BarCodeIDTextBox
            // 
            this.BarCodeIDTextBox.Animated = true;
            this.BarCodeIDTextBox.BorderColor = System.Drawing.Color.Gray;
            this.BarCodeIDTextBox.BorderRadius = 28;
            this.BarCodeIDTextBox.BorderThickness = 2;
            this.BarCodeIDTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BarCodeIDTextBox.DefaultText = "";
            this.BarCodeIDTextBox.DisabledState.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BarCodeIDTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.BarCodeIDTextBox.DisabledState.ForeColor = System.Drawing.Color.White;
            this.BarCodeIDTextBox.DisabledState.Parent = this.BarCodeIDTextBox;
            this.BarCodeIDTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BarCodeIDTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BarCodeIDTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.BarCodeIDTextBox.FocusedState.Parent = this.BarCodeIDTextBox;
            this.BarCodeIDTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarCodeIDTextBox.ForeColor = System.Drawing.Color.White;
            this.BarCodeIDTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.BarCodeIDTextBox.HoverState.Parent = this.BarCodeIDTextBox;
            this.BarCodeIDTextBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("BarCodeIDTextBox.IconLeft")));
            this.BarCodeIDTextBox.IconLeftOffset = new System.Drawing.Point(15, 0);
            this.BarCodeIDTextBox.IconLeftSize = new System.Drawing.Size(35, 35);
            this.BarCodeIDTextBox.Location = new System.Drawing.Point(383, 132);
            this.BarCodeIDTextBox.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.BarCodeIDTextBox.Name = "BarCodeIDTextBox";
            this.BarCodeIDTextBox.PasswordChar = '*';
            this.BarCodeIDTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BarCodeIDTextBox.PlaceholderText = "Enter BarCode";
            this.BarCodeIDTextBox.SelectedText = "";
            this.BarCodeIDTextBox.ShadowDecoration.Parent = this.BarCodeIDTextBox;
            this.BarCodeIDTextBox.Size = new System.Drawing.Size(454, 75);
            this.BarCodeIDTextBox.TabIndex = 9;
            this.BarCodeIDTextBox.TextOffset = new System.Drawing.Point(15, 0);
            this.BarCodeIDTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BarCodeIDTextBox_KeyDown);
            // 
            // RecordButton
            // 
            this.RecordButton.Animated = true;
            this.RecordButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.RecordButton.BorderRadius = 30;
            this.RecordButton.BorderThickness = 3;
            this.RecordButton.CheckedState.Parent = this.RecordButton;
            this.RecordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RecordButton.CustomImages.Parent = this.RecordButton;
            this.RecordButton.FillColor = System.Drawing.Color.Transparent;
            this.RecordButton.FillColor2 = System.Drawing.Color.Transparent;
            this.RecordButton.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordButton.ForeColor = System.Drawing.Color.White;
            this.RecordButton.HoverState.FillColor = System.Drawing.Color.Black;
            this.RecordButton.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.RecordButton.HoverState.Parent = this.RecordButton;
            this.RecordButton.ImageSize = new System.Drawing.Size(40, 40);
            this.RecordButton.Location = new System.Drawing.Point(442, 235);
            this.RecordButton.Name = "RecordButton";
            this.RecordButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.RecordButton.PressedDepth = 100;
            this.RecordButton.ShadowDecoration.Parent = this.RecordButton;
            this.RecordButton.Size = new System.Drawing.Size(336, 87);
            this.RecordButton.TabIndex = 69;
            this.RecordButton.TabStop = false;
            this.RecordButton.Text = "Record Leave";
            this.RecordButton.Click += new System.EventHandler(this.RecordButton_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = false;
            this.ErrorLabel.BackColor = System.Drawing.Color.Transparent;
            this.ErrorLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.ErrorLabel.Location = new System.Drawing.Point(391, 389);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(535, 43);
            this.ErrorLabel.TabIndex = 70;
            this.ErrorLabel.TabStop = false;
            this.ErrorLabel.Text = "Can Not Record Leave Now !";
            this.ErrorLabel.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.ErrorLabel.Visible = false;
            // 
            // TeacherLeaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 544);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.RecordButton);
            this.Controls.Add(this.BarCodeIDTextBox);
            this.Controls.Add(this.BackGroundPictureBox);
            this.Controls.Add(this.HeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TeacherLeaveForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Record Leave";
            this.Load += new System.EventHandler(this.TeacherLeaveForm_Load);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackGroundPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl FormDrag;
        private Guna.UI2.WinForms.Guna2AnimateWindow FormTransition;
        private Bunifu.Framework.UI.BunifuElipse FormElipse;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label OptionsLabel;
        private Guna.UI2.WinForms.Guna2ImageButton MinimizationButton;
        private Guna.UI2.WinForms.Guna2ImageButton CloseButton;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.PictureBox BackGroundPictureBox;
        private Guna.UI2.WinForms.Guna2TextBox BarCodeIDTextBox;
        private Guna.UI2.WinForms.Guna2GradientTileButton RecordButton;
        private Guna.UI2.WinForms.Guna2HtmlLabel ErrorLabel;
    }
}