namespace School_System_Application
{
    partial class SchoolControlsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchoolControlsForm));
            this.FormDrag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.LogOutButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.OptionsLabel = new System.Windows.Forms.Label();
            this.AboutButton = new Guna.UI2.WinForms.Guna2Button();
            this.BenefitsButton = new Guna.UI2.WinForms.Guna2Button();
            this.MinimizationButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.CloseButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.ClassesButton = new Guna.UI2.WinForms.Guna2Button();
            this.StudentsButton = new Guna.UI2.WinForms.Guna2Button();
            this.TeachersButton = new Guna.UI2.WinForms.Guna2Button();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.FormTransition = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.FormElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.BannerPictureBox = new System.Windows.Forms.PictureBox();
            this.FormsPanel = new System.Windows.Forms.Panel();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BannerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FormDrag
            // 
            this.FormDrag.TargetControl = this.HeaderPanel;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.HeaderPanel.Controls.Add(this.LogOutButton);
            this.HeaderPanel.Controls.Add(this.OptionsLabel);
            this.HeaderPanel.Controls.Add(this.AboutButton);
            this.HeaderPanel.Controls.Add(this.BenefitsButton);
            this.HeaderPanel.Controls.Add(this.MinimizationButton);
            this.HeaderPanel.Controls.Add(this.CloseButton);
            this.HeaderPanel.Controls.Add(this.ClassesButton);
            this.HeaderPanel.Controls.Add(this.StudentsButton);
            this.HeaderPanel.Controls.Add(this.TeachersButton);
            this.HeaderPanel.Controls.Add(this.LogoPictureBox);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1220, 94);
            this.HeaderPanel.TabIndex = 1;
            // 
            // LogOutButton
            // 
            this.LogOutButton.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("LogOutButton.CheckedState.Image")));
            this.LogOutButton.CheckedState.ImageSize = new System.Drawing.Size(23, 23);
            this.LogOutButton.CheckedState.Parent = this.LogOutButton;
            this.LogOutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOutButton.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("LogOutButton.HoverState.Image")));
            this.LogOutButton.HoverState.ImageSize = new System.Drawing.Size(23, 23);
            this.LogOutButton.HoverState.Parent = this.LogOutButton;
            this.LogOutButton.Image = ((System.Drawing.Image)(resources.GetObject("LogOutButton.Image")));
            this.LogOutButton.ImageSize = new System.Drawing.Size(23, 23);
            this.LogOutButton.Location = new System.Drawing.Point(1047, 8);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.PressedState.Parent = this.LogOutButton;
            this.LogOutButton.Size = new System.Drawing.Size(56, 76);
            this.LogOutButton.TabIndex = 15;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // OptionsLabel
            // 
            this.OptionsLabel.AutoSize = true;
            this.OptionsLabel.Font = new System.Drawing.Font("Algerian", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.OptionsLabel.Location = new System.Drawing.Point(98, 25);
            this.OptionsLabel.Name = "OptionsLabel";
            this.OptionsLabel.Size = new System.Drawing.Size(182, 45);
            this.OptionsLabel.TabIndex = 14;
            this.OptionsLabel.Text = "Options";
            // 
            // AboutButton
            // 
            this.AboutButton.Animated = true;
            this.AboutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AboutButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.AboutButton.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.AboutButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.AboutButton.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.AboutButton.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.AboutButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.AboutButton.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.AboutButton.CheckedState.Parent = this.AboutButton;
            this.AboutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AboutButton.CustomImages.Parent = this.AboutButton;
            this.AboutButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.AboutButton.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutButton.ForeColor = System.Drawing.Color.White;
            this.AboutButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.AboutButton.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.AboutButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.AboutButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.AboutButton.HoverState.Parent = this.AboutButton;
            this.AboutButton.Location = new System.Drawing.Point(887, 8);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.AboutButton.PressedDepth = 0;
            this.AboutButton.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.AboutButton.ShadowDecoration.Parent = this.AboutButton;
            this.AboutButton.Size = new System.Drawing.Size(167, 76);
            this.AboutButton.TabIndex = 13;
            this.AboutButton.Text = "About Us";
            this.AboutButton.CheckedChanged += new System.EventHandler(this.AboutButton_CheckedChanged);
            // 
            // BenefitsButton
            // 
            this.BenefitsButton.Animated = true;
            this.BenefitsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BenefitsButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.BenefitsButton.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.BenefitsButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BenefitsButton.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.BenefitsButton.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.BenefitsButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.BenefitsButton.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.BenefitsButton.CheckedState.Parent = this.BenefitsButton;
            this.BenefitsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BenefitsButton.CustomImages.Parent = this.BenefitsButton;
            this.BenefitsButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.BenefitsButton.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BenefitsButton.ForeColor = System.Drawing.Color.White;
            this.BenefitsButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.BenefitsButton.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.BenefitsButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.BenefitsButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.BenefitsButton.HoverState.Parent = this.BenefitsButton;
            this.BenefitsButton.Location = new System.Drawing.Point(729, 8);
            this.BenefitsButton.Name = "BenefitsButton";
            this.BenefitsButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.BenefitsButton.PressedDepth = 0;
            this.BenefitsButton.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.BenefitsButton.ShadowDecoration.Parent = this.BenefitsButton;
            this.BenefitsButton.Size = new System.Drawing.Size(167, 76);
            this.BenefitsButton.TabIndex = 12;
            this.BenefitsButton.Text = "Benefits";
            this.BenefitsButton.CheckedChanged += new System.EventHandler(this.BenefitsButton_CheckedChanged);
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
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ClassesButton
            // 
            this.ClassesButton.Animated = true;
            this.ClassesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClassesButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.ClassesButton.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.ClassesButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ClassesButton.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.ClassesButton.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.ClassesButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.ClassesButton.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.ClassesButton.CheckedState.Parent = this.ClassesButton;
            this.ClassesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClassesButton.CustomImages.Parent = this.ClassesButton;
            this.ClassesButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.ClassesButton.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassesButton.ForeColor = System.Drawing.Color.White;
            this.ClassesButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.ClassesButton.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.ClassesButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.ClassesButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.ClassesButton.HoverState.Parent = this.ClassesButton;
            this.ClassesButton.Location = new System.Drawing.Point(601, 8);
            this.ClassesButton.Name = "ClassesButton";
            this.ClassesButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.ClassesButton.PressedDepth = 0;
            this.ClassesButton.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.ClassesButton.ShadowDecoration.Parent = this.ClassesButton;
            this.ClassesButton.Size = new System.Drawing.Size(139, 76);
            this.ClassesButton.TabIndex = 9;
            this.ClassesButton.Text = "Classes";
            this.ClassesButton.CheckedChanged += new System.EventHandler(this.ClassesButton_CheckedChanged);
            // 
            // StudentsButton
            // 
            this.StudentsButton.Animated = true;
            this.StudentsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.StudentsButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.StudentsButton.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.StudentsButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.StudentsButton.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.StudentsButton.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.StudentsButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.StudentsButton.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.StudentsButton.CheckedState.Parent = this.StudentsButton;
            this.StudentsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StudentsButton.CustomImages.Parent = this.StudentsButton;
            this.StudentsButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.StudentsButton.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentsButton.ForeColor = System.Drawing.Color.White;
            this.StudentsButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.StudentsButton.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.StudentsButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.StudentsButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.StudentsButton.HoverState.Parent = this.StudentsButton;
            this.StudentsButton.Location = new System.Drawing.Point(446, 8);
            this.StudentsButton.Name = "StudentsButton";
            this.StudentsButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.StudentsButton.PressedDepth = 0;
            this.StudentsButton.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.StudentsButton.ShadowDecoration.Parent = this.StudentsButton;
            this.StudentsButton.Size = new System.Drawing.Size(166, 76);
            this.StudentsButton.TabIndex = 8;
            this.StudentsButton.Text = "Students";
            this.StudentsButton.CheckedChanged += new System.EventHandler(this.StudentsButton_CheckedChanged);
            // 
            // TeachersButton
            // 
            this.TeachersButton.Animated = true;
            this.TeachersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TeachersButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.TeachersButton.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.TeachersButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.TeachersButton.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.TeachersButton.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.TeachersButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.TeachersButton.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.TeachersButton.CheckedState.Parent = this.TeachersButton;
            this.TeachersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TeachersButton.CustomImages.Parent = this.TeachersButton;
            this.TeachersButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.TeachersButton.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeachersButton.ForeColor = System.Drawing.Color.White;
            this.TeachersButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.TeachersButton.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.TeachersButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.TeachersButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.TeachersButton.HoverState.Parent = this.TeachersButton;
            this.TeachersButton.Location = new System.Drawing.Point(284, 8);
            this.TeachersButton.Name = "TeachersButton";
            this.TeachersButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.TeachersButton.PressedDepth = 0;
            this.TeachersButton.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.TeachersButton.ShadowDecoration.Parent = this.TeachersButton;
            this.TeachersButton.Size = new System.Drawing.Size(174, 76);
            this.TeachersButton.TabIndex = 7;
            this.TeachersButton.Text = "Teachers";
            this.TeachersButton.CheckedChanged += new System.EventHandler(this.TeachersButton_CheckedChanged);
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPictureBox.Image")));
            this.LogoPictureBox.Location = new System.Drawing.Point(4, 3);
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
            // BannerPictureBox
            // 
            this.BannerPictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.BannerPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("BannerPictureBox.Image")));
            this.BannerPictureBox.Location = new System.Drawing.Point(0, 94);
            this.BannerPictureBox.Name = "BannerPictureBox";
            this.BannerPictureBox.Size = new System.Drawing.Size(1220, 400);
            this.BannerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BannerPictureBox.TabIndex = 7;
            this.BannerPictureBox.TabStop = false;
            // 
            // FormsPanel
            // 
            this.FormsPanel.BackColor = System.Drawing.Color.Black;
            this.FormsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormsPanel.Location = new System.Drawing.Point(0, 494);
            this.FormsPanel.Name = "FormsPanel";
            this.FormsPanel.Size = new System.Drawing.Size(1220, 606);
            this.FormsPanel.TabIndex = 9;
            // 
            // SchoolControlsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1220, 1100);
            this.Controls.Add(this.FormsPanel);
            this.Controls.Add(this.BannerPictureBox);
            this.Controls.Add(this.HeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SchoolControlsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controls Form";
            this.Load += new System.EventHandler(this.SchoolControlsForm_Load);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BannerPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DragControl FormDrag;
        private Guna.UI2.WinForms.Guna2AnimateWindow FormTransition;
        private Bunifu.Framework.UI.BunifuElipse FormElipse;
        private System.Windows.Forms.Panel HeaderPanel;
        private Guna.UI2.WinForms.Guna2ImageButton MinimizationButton;
        private Guna.UI2.WinForms.Guna2ImageButton CloseButton;
        private Guna.UI2.WinForms.Guna2Button ClassesButton;
        private Guna.UI2.WinForms.Guna2Button StudentsButton;
        private Guna.UI2.WinForms.Guna2Button TeachersButton;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private Guna.UI2.WinForms.Guna2Button AboutButton;
        private Guna.UI2.WinForms.Guna2Button BenefitsButton;
        private System.Windows.Forms.Label OptionsLabel;
        private System.Windows.Forms.PictureBox BannerPictureBox;
        private System.Windows.Forms.Panel FormsPanel;
        private Guna.UI2.WinForms.Guna2ImageButton LogOutButton;
    }
}