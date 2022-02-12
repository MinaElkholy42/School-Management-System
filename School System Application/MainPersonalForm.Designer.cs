namespace School_System_Application
{
    partial class MainPersonalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPersonalForm));
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.MinimizationButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.CloseButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.ForgetAccountForm = new Guna.UI2.WinForms.Guna2Button();
            this.SignUpForm = new Guna.UI2.WinForms.Guna2Button();
            this.LoginFormButton = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.FormElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.FormTransition = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.FormDrag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.BannerPictureBox = new System.Windows.Forms.PictureBox();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.FormsPanel = new System.Windows.Forms.Panel();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BannerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.HeaderPanel.Controls.Add(this.MinimizationButton);
            this.HeaderPanel.Controls.Add(this.CloseButton);
            this.HeaderPanel.Controls.Add(this.ForgetAccountForm);
            this.HeaderPanel.Controls.Add(this.SignUpForm);
            this.HeaderPanel.Controls.Add(this.LoginFormButton);
            this.HeaderPanel.Controls.Add(this.label3);
            this.HeaderPanel.Controls.Add(this.label4);
            this.HeaderPanel.Controls.Add(this.LogoPictureBox);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1220, 94);
            this.HeaderPanel.TabIndex = 0;
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
            // ForgetAccountForm
            // 
            this.ForgetAccountForm.Animated = true;
            this.ForgetAccountForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ForgetAccountForm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.ForgetAccountForm.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.ForgetAccountForm.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ForgetAccountForm.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.ForgetAccountForm.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.ForgetAccountForm.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.ForgetAccountForm.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.ForgetAccountForm.CheckedState.Parent = this.ForgetAccountForm;
            this.ForgetAccountForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForgetAccountForm.CustomImages.Parent = this.ForgetAccountForm;
            this.ForgetAccountForm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.ForgetAccountForm.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgetAccountForm.ForeColor = System.Drawing.Color.White;
            this.ForgetAccountForm.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.ForgetAccountForm.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.ForgetAccountForm.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.ForgetAccountForm.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.ForgetAccountForm.HoverState.Parent = this.ForgetAccountForm;
            this.ForgetAccountForm.Location = new System.Drawing.Point(787, 6);
            this.ForgetAccountForm.Name = "ForgetAccountForm";
            this.ForgetAccountForm.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.ForgetAccountForm.PressedDepth = 0;
            this.ForgetAccountForm.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.ForgetAccountForm.ShadowDecoration.Parent = this.ForgetAccountForm;
            this.ForgetAccountForm.Size = new System.Drawing.Size(236, 76);
            this.ForgetAccountForm.TabIndex = 9;
            this.ForgetAccountForm.Text = "Forgot Account";
            this.ForgetAccountForm.CheckedChanged += new System.EventHandler(this.ForgetAccountForm_CheckedChanged);
            // 
            // SignUpForm
            // 
            this.SignUpForm.Animated = true;
            this.SignUpForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SignUpForm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.SignUpForm.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.SignUpForm.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.SignUpForm.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.SignUpForm.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.SignUpForm.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.SignUpForm.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.SignUpForm.CheckedState.Parent = this.SignUpForm;
            this.SignUpForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUpForm.CustomImages.Parent = this.SignUpForm;
            this.SignUpForm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.SignUpForm.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpForm.ForeColor = System.Drawing.Color.White;
            this.SignUpForm.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.SignUpForm.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.SignUpForm.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.SignUpForm.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.SignUpForm.HoverState.Parent = this.SignUpForm;
            this.SignUpForm.Location = new System.Drawing.Point(614, 6);
            this.SignUpForm.Name = "SignUpForm";
            this.SignUpForm.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.SignUpForm.PressedDepth = 0;
            this.SignUpForm.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.SignUpForm.ShadowDecoration.Parent = this.SignUpForm;
            this.SignUpForm.Size = new System.Drawing.Size(161, 76);
            this.SignUpForm.TabIndex = 8;
            this.SignUpForm.Text = "Register";
            this.SignUpForm.CheckedChanged += new System.EventHandler(this.SignUpForm_CheckedChanged);
            // 
            // LoginFormButton
            // 
            this.LoginFormButton.Animated = true;
            this.LoginFormButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LoginFormButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.LoginFormButton.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.LoginFormButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.LoginFormButton.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.LoginFormButton.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.LoginFormButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.LoginFormButton.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.LoginFormButton.CheckedState.Parent = this.LoginFormButton;
            this.LoginFormButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginFormButton.CustomImages.Parent = this.LoginFormButton;
            this.LoginFormButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.LoginFormButton.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginFormButton.ForeColor = System.Drawing.Color.White;
            this.LoginFormButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.LoginFormButton.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.LoginFormButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.LoginFormButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.LoginFormButton.HoverState.Parent = this.LoginFormButton;
            this.LoginFormButton.Location = new System.Drawing.Point(502, 6);
            this.LoginFormButton.Name = "LoginFormButton";
            this.LoginFormButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.LoginFormButton.PressedDepth = 0;
            this.LoginFormButton.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.LoginFormButton.ShadowDecoration.Parent = this.LoginFormButton;
            this.LoginFormButton.Size = new System.Drawing.Size(103, 76);
            this.LoginFormButton.TabIndex = 7;
            this.LoginFormButton.Text = "LogIn";
            this.LoginFormButton.CheckedChanged += new System.EventHandler(this.LoginFormButton_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(118, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Application System";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Algerian", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.label4.Location = new System.Drawing.Point(174, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 45);
            this.label4.TabIndex = 5;
            this.label4.Text = "School";
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
            // FormElipse
            // 
            this.FormElipse.ElipseRadius = 80;
            this.FormElipse.TargetControl = this;
            // 
            // FormTransition
            // 
            this.FormTransition.Interval = 460;
            // 
            // FormDrag
            // 
            this.FormDrag.TargetControl = this.HeaderPanel;
            // 
            // BannerPictureBox
            // 
            this.BannerPictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.BannerPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("BannerPictureBox.Image")));
            this.BannerPictureBox.Location = new System.Drawing.Point(0, 94);
            this.BannerPictureBox.Name = "BannerPictureBox";
            this.BannerPictureBox.Size = new System.Drawing.Size(1220, 350);
            this.BannerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BannerPictureBox.TabIndex = 6;
            this.BannerPictureBox.TabStop = false;
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Algerian", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.White;
            this.HeaderLabel.Location = new System.Drawing.Point(503, 131);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(308, 42);
            this.HeaderLabel.TabIndex = 7;
            this.HeaderLabel.Text = "Header Label";
            // 
            // FormsPanel
            // 
            this.FormsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(48)))), ((int)(((byte)(72)))));
            this.FormsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormsPanel.Location = new System.Drawing.Point(0, 444);
            this.FormsPanel.Name = "FormsPanel";
            this.FormsPanel.Size = new System.Drawing.Size(1220, 656);
            this.FormsPanel.TabIndex = 8;
            // 
            // MainPersonalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 1100);
            this.Controls.Add(this.FormsPanel);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.BannerPictureBox);
            this.Controls.Add(this.HeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPersonalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainPersonalForm_Load);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BannerPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private Bunifu.Framework.UI.BunifuElipse FormElipse;
        private Guna.UI2.WinForms.Guna2AnimateWindow FormTransition;
        private Guna.UI2.WinForms.Guna2DragControl FormDrag;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button LoginFormButton;
        private Guna.UI2.WinForms.Guna2Button ForgetAccountForm;
        private Guna.UI2.WinForms.Guna2Button SignUpForm;
        private Guna.UI2.WinForms.Guna2ImageButton CloseButton;
        private Guna.UI2.WinForms.Guna2ImageButton MinimizationButton;
        private System.Windows.Forms.Panel FormsPanel;
        private System.Windows.Forms.PictureBox BannerPictureBox;
        public System.Windows.Forms.Label HeaderLabel;
    }
}