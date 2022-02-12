namespace School_System_Application
{
    partial class temp
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
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(temp));
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.OptionsLabel = new System.Windows.Forms.Label();
            this.MinimizationButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.CloseButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.FormTransition = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.FormDrag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.FormElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.AttendanceButton = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.PasswordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.HalfHourTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.HeaderPanel.Controls.Add(this.OptionsLabel);
            this.HeaderPanel.Controls.Add(this.MinimizationButton);
            this.HeaderPanel.Controls.Add(this.CloseButton);
            this.HeaderPanel.Controls.Add(this.LogoPictureBox);
            this.guna2Transition1.SetDecoration(this.HeaderPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1220, 94);
            this.HeaderPanel.TabIndex = 2;
            // 
            // OptionsLabel
            // 
            this.OptionsLabel.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.OptionsLabel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.OptionsLabel.Font = new System.Drawing.Font("Algerian", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.OptionsLabel.Location = new System.Drawing.Point(350, 20);
            this.OptionsLabel.Name = "OptionsLabel";
            this.OptionsLabel.Size = new System.Drawing.Size(480, 45);
            this.OptionsLabel.TabIndex = 14;
            this.OptionsLabel.Text = "Add Teacher Control";
            // 
            // MinimizationButton
            // 
            this.MinimizationButton.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("MinimizationButton.CheckedState.Image")));
            this.MinimizationButton.CheckedState.ImageSize = new System.Drawing.Size(23, 23);
            this.MinimizationButton.CheckedState.Parent = this.MinimizationButton;
            this.MinimizationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.MinimizationButton, Guna.UI2.AnimatorNS.DecorationType.None);
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
            // 
            // CloseButton
            // 
            this.CloseButton.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.CheckedState.Image")));
            this.CloseButton.CheckedState.ImageSize = new System.Drawing.Size(23, 23);
            this.CloseButton.CheckedState.Parent = this.CloseButton;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.CloseButton, Guna.UI2.AnimatorNS.DecorationType.None);
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
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // LogoPictureBox
            // 
            this.guna2Transition1.SetDecoration(this.LogoPictureBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.LogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPictureBox.Image")));
            this.LogoPictureBox.Location = new System.Drawing.Point(12, 4);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(90, 90);
            this.LogoPictureBox.TabIndex = 0;
            this.LogoPictureBox.TabStop = false;
            // 
            // FormTransition
            // 
            this.FormTransition.Interval = 460;
            // 
            // FormDrag
            // 
            this.FormDrag.TargetControl = this.HeaderPanel;
            // 
            // FormElipse
            // 
            this.FormElipse.ElipseRadius = 80;
            this.FormElipse.TargetControl = this;
            // 
            // AttendanceButton
            // 
            this.AttendanceButton.Animated = true;
            this.AttendanceButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.AttendanceButton.BorderRadius = 40;
            this.AttendanceButton.BorderThickness = 3;
            this.AttendanceButton.CheckedState.Parent = this.AttendanceButton;
            this.AttendanceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AttendanceButton.CustomImages.Parent = this.AttendanceButton;
            this.guna2Transition1.SetDecoration(this.AttendanceButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.AttendanceButton.FillColor = System.Drawing.Color.Black;
            this.AttendanceButton.FillColor2 = System.Drawing.Color.Black;
            this.AttendanceButton.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendanceButton.ForeColor = System.Drawing.Color.White;
            this.AttendanceButton.HoverState.FillColor = System.Drawing.Color.Black;
            this.AttendanceButton.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.AttendanceButton.HoverState.Parent = this.AttendanceButton;
            this.AttendanceButton.Image = ((System.Drawing.Image)(resources.GetObject("AttendanceButton.Image")));
            this.AttendanceButton.ImageSize = new System.Drawing.Size(40, 40);
            this.AttendanceButton.Location = new System.Drawing.Point(367, 540);
            this.AttendanceButton.Name = "AttendanceButton";
            this.AttendanceButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.AttendanceButton.PressedDepth = 100;
            this.AttendanceButton.ShadowDecoration.Parent = this.AttendanceButton;
            this.AttendanceButton.Size = new System.Drawing.Size(397, 122);
            this.AttendanceButton.TabIndex = 5;
            this.AttendanceButton.Text = "Attendance Registration";
            this.AttendanceButton.TextOffset = new System.Drawing.Point(0, -5);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Animated = true;
            this.PasswordTextBox.BorderColor = System.Drawing.Color.Gray;
            this.PasswordTextBox.BorderRadius = 28;
            this.PasswordTextBox.BorderThickness = 2;
            this.PasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.PasswordTextBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.PasswordTextBox.DefaultText = "";
            this.PasswordTextBox.DisabledState.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.PasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.White;
            this.PasswordTextBox.DisabledState.Parent = this.PasswordTextBox;
            this.PasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PasswordTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.PasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.PasswordTextBox.FocusedState.Parent = this.PasswordTextBox;
            this.PasswordTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.ForeColor = System.Drawing.Color.White;
            this.PasswordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.PasswordTextBox.HoverState.Parent = this.PasswordTextBox;
            this.PasswordTextBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("PasswordTextBox.IconLeft")));
            this.PasswordTextBox.IconLeftOffset = new System.Drawing.Point(15, 0);
            this.PasswordTextBox.IconLeftSize = new System.Drawing.Size(35, 35);
            this.PasswordTextBox.Location = new System.Drawing.Point(252, 377);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PasswordTextBox.PlaceholderText = "Enter Password";
            this.PasswordTextBox.SelectedText = "";
            this.PasswordTextBox.ShadowDecoration.Parent = this.PasswordTextBox;
            this.PasswordTextBox.Size = new System.Drawing.Size(647, 75);
            this.PasswordTextBox.TabIndex = 6;
            this.PasswordTextBox.TextOffset = new System.Drawing.Point(15, 0);
            // 
            // HalfHourTimer
            // 
            this.HalfHourTimer.Tick += new System.EventHandler(this.HalfHourTimer_Tick);
            // 
            // pictureBox1
            // 
            this.guna2Transition1.SetDecoration(this.pictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1220, 1006);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Rotate;
            this.guna2Transition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(50);
            animation1.RotateCoeff = 1F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.guna2Transition1.DefaultAnimation = animation1;
            // 
            // pictureBox2
            // 
            this.guna2Transition1.SetDecoration(this.pictureBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pictureBox2.Location = new System.Drawing.Point(771, 138);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(322, 187);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.guna2Transition1.SetDecoration(this.button1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.button1.Location = new System.Drawing.Point(301, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // temp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1220, 1100);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.AttendanceButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.HeaderPanel);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "temp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "temp";
            this.Load += new System.EventHandler(this.temp_Load);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label OptionsLabel;
        private Guna.UI2.WinForms.Guna2ImageButton MinimizationButton;
        private Guna.UI2.WinForms.Guna2ImageButton CloseButton;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private Guna.UI2.WinForms.Guna2AnimateWindow FormTransition;
        private Guna.UI2.WinForms.Guna2DragControl FormDrag;
        private Bunifu.Framework.UI.BunifuElipse FormElipse;
        private Guna.UI2.WinForms.Guna2GradientTileButton AttendanceButton;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTextBox;
        private System.Windows.Forms.Timer HalfHourTimer;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}