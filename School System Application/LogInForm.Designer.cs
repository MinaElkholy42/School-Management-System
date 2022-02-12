namespace School_System_Application
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.ErrorLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LogInButton = new Guna.UI2.WinForms.Guna2Button();
            this.RemeberMeToggleSwitch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.RemeberMeLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ShowPasswordButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.PasswordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.UserNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.SetWordButton = new Guna.UI2.WinForms.Guna2Button();
            this.WordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = false;
            this.ErrorLabel.BackColor = System.Drawing.Color.Transparent;
            this.ErrorLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.ErrorLabel.Location = new System.Drawing.Point(307, 257);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(606, 43);
            this.ErrorLabel.TabIndex = 2;
            this.ErrorLabel.TabStop = false;
            this.ErrorLabel.Text = "Please Fill the User Name and Password";
            this.ErrorLabel.Visible = false;
            this.ErrorLabel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // LogInButton
            // 
            this.LogInButton.Animated = true;
            this.LogInButton.BackColor = System.Drawing.Color.Transparent;
            this.LogInButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(48)))), ((int)(((byte)(72)))));
            this.LogInButton.BorderRadius = 20;
            this.LogInButton.BorderThickness = 3;
            this.LogInButton.CheckedState.Parent = this.LogInButton;
            this.LogInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogInButton.CustomImages.Parent = this.LogInButton;
            this.LogInButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(48)))), ((int)(((byte)(72)))));
            this.LogInButton.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInButton.ForeColor = System.Drawing.Color.White;
            this.LogInButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.LogInButton.HoverState.ForeColor = System.Drawing.Color.Black;
            this.LogInButton.HoverState.Parent = this.LogInButton;
            this.LogInButton.Location = new System.Drawing.Point(429, 334);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.PressedDepth = 80;
            this.LogInButton.ShadowDecoration.BorderRadius = 20;
            this.LogInButton.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.LogInButton.ShadowDecoration.Depth = 70;
            this.LogInButton.ShadowDecoration.Enabled = true;
            this.LogInButton.ShadowDecoration.Parent = this.LogInButton;
            this.LogInButton.Size = new System.Drawing.Size(363, 63);
            this.LogInButton.TabIndex = 4;
            this.LogInButton.TabStop = false;
            this.LogInButton.Text = "LogIn";
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            this.LogInButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // RemeberMeToggleSwitch
            // 
            this.RemeberMeToggleSwitch.Animated = true;
            this.RemeberMeToggleSwitch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.RemeberMeToggleSwitch.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.RemeberMeToggleSwitch.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.RemeberMeToggleSwitch.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RemeberMeToggleSwitch.CheckedState.Parent = this.RemeberMeToggleSwitch;
            this.RemeberMeToggleSwitch.Location = new System.Drawing.Point(684, 199);
            this.RemeberMeToggleSwitch.Name = "RemeberMeToggleSwitch";
            this.RemeberMeToggleSwitch.ShadowDecoration.Parent = this.RemeberMeToggleSwitch;
            this.RemeberMeToggleSwitch.Size = new System.Drawing.Size(80, 26);
            this.RemeberMeToggleSwitch.TabIndex = 5;
            this.RemeberMeToggleSwitch.TabStop = false;
            this.RemeberMeToggleSwitch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RemeberMeToggleSwitch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RemeberMeToggleSwitch.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.RemeberMeToggleSwitch.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.RemeberMeToggleSwitch.UncheckedState.Parent = this.RemeberMeToggleSwitch;
            this.RemeberMeToggleSwitch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // RemeberMeLabel
            // 
            this.RemeberMeLabel.AutoSize = false;
            this.RemeberMeLabel.BackColor = System.Drawing.Color.Transparent;
            this.RemeberMeLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemeberMeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(205)))), ((int)(((byte)(219)))));
            this.RemeberMeLabel.Location = new System.Drawing.Point(456, 189);
            this.RemeberMeLabel.Name = "RemeberMeLabel";
            this.RemeberMeLabel.Size = new System.Drawing.Size(197, 43);
            this.RemeberMeLabel.TabIndex = 6;
            this.RemeberMeLabel.TabStop = false;
            this.RemeberMeLabel.Text = "Remeber Me";
            this.RemeberMeLabel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // ShowPasswordButton
            // 
            this.ShowPasswordButton.CheckedState.Parent = this.ShowPasswordButton;
            this.ShowPasswordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowPasswordButton.HoverState.ImageSize = new System.Drawing.Size(36, 36);
            this.ShowPasswordButton.HoverState.Parent = this.ShowPasswordButton;
            this.ShowPasswordButton.Image = ((System.Drawing.Image)(resources.GetObject("ShowPasswordButton.Image")));
            this.ShowPasswordButton.ImageSize = new System.Drawing.Size(36, 36);
            this.ShowPasswordButton.Location = new System.Drawing.Point(947, 115);
            this.ShowPasswordButton.Name = "ShowPasswordButton";
            this.ShowPasswordButton.PressedState.Parent = this.ShowPasswordButton;
            this.ShowPasswordButton.Size = new System.Drawing.Size(56, 50);
            this.ShowPasswordButton.TabIndex = 3;
            this.ShowPasswordButton.TabStop = false;
            this.ShowPasswordButton.Click += new System.EventHandler(this.ShowPasswordButton_Click);
            this.ShowPasswordButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Animated = true;
            this.PasswordTextBox.BorderColor = System.Drawing.Color.Gray;
            this.PasswordTextBox.BorderRadius = 28;
            this.PasswordTextBox.BorderThickness = 2;
            this.PasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTextBox.DefaultText = "";
            this.PasswordTextBox.DisabledState.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.PasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.White;
            this.PasswordTextBox.DisabledState.Parent = this.PasswordTextBox;
            this.PasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PasswordTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(48)))), ((int)(((byte)(72)))));
            this.PasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.PasswordTextBox.FocusedState.Parent = this.PasswordTextBox;
            this.PasswordTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.ForeColor = System.Drawing.Color.White;
            this.PasswordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.PasswordTextBox.HoverState.Parent = this.PasswordTextBox;
            this.PasswordTextBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("PasswordTextBox.IconLeft")));
            this.PasswordTextBox.IconLeftOffset = new System.Drawing.Point(15, 0);
            this.PasswordTextBox.IconLeftSize = new System.Drawing.Size(35, 35);
            this.PasswordTextBox.Location = new System.Drawing.Point(287, 98);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PasswordTextBox.PlaceholderText = "Enter Password";
            this.PasswordTextBox.SelectedText = "";
            this.PasswordTextBox.ShadowDecoration.Parent = this.PasswordTextBox;
            this.PasswordTextBox.Size = new System.Drawing.Size(647, 75);
            this.PasswordTextBox.TabIndex = 1;
            this.PasswordTextBox.TextOffset = new System.Drawing.Point(15, 0);
            this.PasswordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Animated = true;
            this.UserNameTextBox.BorderColor = System.Drawing.Color.Gray;
            this.UserNameTextBox.BorderRadius = 28;
            this.UserNameTextBox.BorderThickness = 2;
            this.UserNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserNameTextBox.DefaultText = "";
            this.UserNameTextBox.DisabledState.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.UserNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.UserNameTextBox.DisabledState.ForeColor = System.Drawing.Color.White;
            this.UserNameTextBox.DisabledState.Parent = this.UserNameTextBox;
            this.UserNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UserNameTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(48)))), ((int)(((byte)(72)))));
            this.UserNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.UserNameTextBox.FocusedState.Parent = this.UserNameTextBox;
            this.UserNameTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameTextBox.ForeColor = System.Drawing.Color.White;
            this.UserNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.UserNameTextBox.HoverState.Parent = this.UserNameTextBox;
            this.UserNameTextBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("UserNameTextBox.IconLeft")));
            this.UserNameTextBox.IconLeftOffset = new System.Drawing.Point(15, 0);
            this.UserNameTextBox.IconLeftSize = new System.Drawing.Size(35, 35);
            this.UserNameTextBox.Location = new System.Drawing.Point(287, 1);
            this.UserNameTextBox.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.PasswordChar = '\0';
            this.UserNameTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UserNameTextBox.PlaceholderText = "Enter User Name";
            this.UserNameTextBox.SelectedText = "";
            this.UserNameTextBox.ShadowDecoration.Parent = this.UserNameTextBox;
            this.UserNameTextBox.Size = new System.Drawing.Size(647, 75);
            this.UserNameTextBox.TabIndex = 0;
            this.UserNameTextBox.TextOffset = new System.Drawing.Point(15, 0);
            this.UserNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // SetWordButton
            // 
            this.SetWordButton.Animated = true;
            this.SetWordButton.BackColor = System.Drawing.Color.Transparent;
            this.SetWordButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(48)))), ((int)(((byte)(72)))));
            this.SetWordButton.BorderRadius = 20;
            this.SetWordButton.BorderThickness = 3;
            this.SetWordButton.CheckedState.Parent = this.SetWordButton;
            this.SetWordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SetWordButton.CustomImages.Parent = this.SetWordButton;
            this.SetWordButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(48)))), ((int)(((byte)(72)))));
            this.SetWordButton.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetWordButton.ForeColor = System.Drawing.Color.White;
            this.SetWordButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.SetWordButton.HoverState.ForeColor = System.Drawing.Color.Black;
            this.SetWordButton.HoverState.Parent = this.SetWordButton;
            this.SetWordButton.Location = new System.Drawing.Point(429, 334);
            this.SetWordButton.Name = "SetWordButton";
            this.SetWordButton.PressedDepth = 80;
            this.SetWordButton.ShadowDecoration.BorderRadius = 20;
            this.SetWordButton.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.SetWordButton.ShadowDecoration.Depth = 70;
            this.SetWordButton.ShadowDecoration.Enabled = true;
            this.SetWordButton.ShadowDecoration.Parent = this.SetWordButton;
            this.SetWordButton.Size = new System.Drawing.Size(363, 63);
            this.SetWordButton.TabIndex = 7;
            this.SetWordButton.TabStop = false;
            this.SetWordButton.Text = "Set Word";
            this.SetWordButton.Visible = false;
            this.SetWordButton.Click += new System.EventHandler(this.SetWordButton_Click);
            // 
            // WordTextBox
            // 
            this.WordTextBox.Animated = true;
            this.WordTextBox.BorderColor = System.Drawing.Color.Gray;
            this.WordTextBox.BorderRadius = 28;
            this.WordTextBox.BorderThickness = 2;
            this.WordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.WordTextBox.DefaultText = "";
            this.WordTextBox.DisabledState.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.WordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.WordTextBox.DisabledState.ForeColor = System.Drawing.Color.White;
            this.WordTextBox.DisabledState.Parent = this.WordTextBox;
            this.WordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WordTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(48)))), ((int)(((byte)(72)))));
            this.WordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.WordTextBox.FocusedState.Parent = this.WordTextBox;
            this.WordTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WordTextBox.ForeColor = System.Drawing.Color.White;
            this.WordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.WordTextBox.HoverState.Parent = this.WordTextBox;
            this.WordTextBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("WordTextBox.IconLeft")));
            this.WordTextBox.IconLeftOffset = new System.Drawing.Point(15, 0);
            this.WordTextBox.IconLeftSize = new System.Drawing.Size(35, 35);
            this.WordTextBox.Location = new System.Drawing.Point(287, 98);
            this.WordTextBox.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.WordTextBox.Name = "WordTextBox";
            this.WordTextBox.PasswordChar = '*';
            this.WordTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WordTextBox.PlaceholderText = "Enter HR Word";
            this.WordTextBox.SelectedText = "";
            this.WordTextBox.ShadowDecoration.Parent = this.WordTextBox;
            this.WordTextBox.Size = new System.Drawing.Size(647, 75);
            this.WordTextBox.TabIndex = 8;
            this.WordTextBox.TextOffset = new System.Drawing.Point(15, 0);
            this.WordTextBox.Visible = false;
            this.WordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WordTextBox_KeyDown);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(48)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(1220, 656);
            this.Controls.Add(this.RemeberMeLabel);
            this.Controls.Add(this.RemeberMeToggleSwitch);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.ShowPasswordButton);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.WordTextBox);
            this.Controls.Add(this.SetWordButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.LogInForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox UserNameTextBox;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTextBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel ErrorLabel;
        private Guna.UI2.WinForms.Guna2ImageButton ShowPasswordButton;
        private Guna.UI2.WinForms.Guna2Button LogInButton;
        private Guna.UI2.WinForms.Guna2ToggleSwitch RemeberMeToggleSwitch;
        private Guna.UI2.WinForms.Guna2HtmlLabel RemeberMeLabel;
        private Guna.UI2.WinForms.Guna2Button SetWordButton;
        private Guna.UI2.WinForms.Guna2TextBox WordTextBox;
    }
}