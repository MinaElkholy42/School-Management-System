namespace School_System_Application
{
    partial class RecoverAccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecoverAccountForm));
            this.CodeTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.NameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.RecoverButton = new Guna.UI2.WinForms.Guna2Button();
            this.ErrorLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // CodeTextBox
            // 
            this.CodeTextBox.Animated = true;
            this.CodeTextBox.BorderColor = System.Drawing.Color.Gray;
            this.CodeTextBox.BorderRadius = 28;
            this.CodeTextBox.BorderThickness = 2;
            this.CodeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CodeTextBox.DefaultText = "";
            this.CodeTextBox.DisabledState.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CodeTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.CodeTextBox.DisabledState.ForeColor = System.Drawing.Color.White;
            this.CodeTextBox.DisabledState.Parent = this.CodeTextBox;
            this.CodeTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CodeTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(48)))), ((int)(((byte)(72)))));
            this.CodeTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.CodeTextBox.FocusedState.Parent = this.CodeTextBox;
            this.CodeTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeTextBox.ForeColor = System.Drawing.Color.White;
            this.CodeTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.CodeTextBox.HoverState.Parent = this.CodeTextBox;
            this.CodeTextBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("CodeTextBox.IconLeft")));
            this.CodeTextBox.IconLeftOffset = new System.Drawing.Point(15, 0);
            this.CodeTextBox.IconLeftSize = new System.Drawing.Size(35, 35);
            this.CodeTextBox.Location = new System.Drawing.Point(287, 98);
            this.CodeTextBox.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.CodeTextBox.Name = "CodeTextBox";
            this.CodeTextBox.PasswordChar = '*';
            this.CodeTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CodeTextBox.PlaceholderText = "Enter Authontication Code";
            this.CodeTextBox.SelectedText = "";
            this.CodeTextBox.ShadowDecoration.Parent = this.CodeTextBox;
            this.CodeTextBox.Size = new System.Drawing.Size(647, 75);
            this.CodeTextBox.TabIndex = 3;
            this.CodeTextBox.TextOffset = new System.Drawing.Point(15, 0);
            this.CodeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Animated = true;
            this.NameTextBox.BorderColor = System.Drawing.Color.Gray;
            this.NameTextBox.BorderRadius = 28;
            this.NameTextBox.BorderThickness = 2;
            this.NameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameTextBox.DefaultText = "";
            this.NameTextBox.DisabledState.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.NameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.NameTextBox.DisabledState.ForeColor = System.Drawing.Color.White;
            this.NameTextBox.DisabledState.Parent = this.NameTextBox;
            this.NameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NameTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(48)))), ((int)(((byte)(72)))));
            this.NameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.NameTextBox.FocusedState.Parent = this.NameTextBox;
            this.NameTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.ForeColor = System.Drawing.Color.White;
            this.NameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.NameTextBox.HoverState.Parent = this.NameTextBox;
            this.NameTextBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("NameTextBox.IconLeft")));
            this.NameTextBox.IconLeftOffset = new System.Drawing.Point(15, 0);
            this.NameTextBox.IconLeftSize = new System.Drawing.Size(35, 35);
            this.NameTextBox.Location = new System.Drawing.Point(287, 1);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.PasswordChar = '\0';
            this.NameTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NameTextBox.PlaceholderText = "Enter HR Name";
            this.NameTextBox.SelectedText = "";
            this.NameTextBox.ShadowDecoration.Parent = this.NameTextBox;
            this.NameTextBox.Size = new System.Drawing.Size(647, 75);
            this.NameTextBox.TabIndex = 2;
            this.NameTextBox.TextOffset = new System.Drawing.Point(15, 0);
            this.NameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // RecoverButton
            // 
            this.RecoverButton.Animated = true;
            this.RecoverButton.BackColor = System.Drawing.Color.Transparent;
            this.RecoverButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(48)))), ((int)(((byte)(72)))));
            this.RecoverButton.BorderRadius = 20;
            this.RecoverButton.BorderThickness = 3;
            this.RecoverButton.CheckedState.Parent = this.RecoverButton;
            this.RecoverButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RecoverButton.CustomImages.Parent = this.RecoverButton;
            this.RecoverButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(48)))), ((int)(((byte)(72)))));
            this.RecoverButton.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecoverButton.ForeColor = System.Drawing.Color.White;
            this.RecoverButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.RecoverButton.HoverState.ForeColor = System.Drawing.Color.Black;
            this.RecoverButton.HoverState.Parent = this.RecoverButton;
            this.RecoverButton.Location = new System.Drawing.Point(429, 273);
            this.RecoverButton.Name = "RecoverButton";
            this.RecoverButton.PressedDepth = 80;
            this.RecoverButton.ShadowDecoration.BorderRadius = 20;
            this.RecoverButton.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.RecoverButton.ShadowDecoration.Depth = 70;
            this.RecoverButton.ShadowDecoration.Enabled = true;
            this.RecoverButton.ShadowDecoration.Parent = this.RecoverButton;
            this.RecoverButton.Size = new System.Drawing.Size(363, 63);
            this.RecoverButton.TabIndex = 5;
            this.RecoverButton.TabStop = false;
            this.RecoverButton.Text = "Recover";
            this.RecoverButton.Click += new System.EventHandler(this.RecoverButton_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = false;
            this.ErrorLabel.BackColor = System.Drawing.Color.Transparent;
            this.ErrorLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.ErrorLabel.Location = new System.Drawing.Point(182, 196);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(866, 43);
            this.ErrorLabel.TabIndex = 6;
            this.ErrorLabel.TabStop = false;
            this.ErrorLabel.Text = "Wrong Name or Authontication Code, Please Try Again";
            this.ErrorLabel.Visible = false;
            // 
            // RecoverAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(48)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(1220, 656);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.RecoverButton);
            this.Controls.Add(this.CodeTextBox);
            this.Controls.Add(this.NameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RecoverAccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recover Account";
            this.Load += new System.EventHandler(this.RecoverAccountForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox CodeTextBox;
        private Guna.UI2.WinForms.Guna2TextBox NameTextBox;
        private Guna.UI2.WinForms.Guna2Button RecoverButton;
        private Guna.UI2.WinForms.Guna2HtmlLabel ErrorLabel;
    }
}