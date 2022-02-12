namespace School_System_Application
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.PasswordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.UserNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.ConfrimPasswordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.NameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.SignUpButton = new Guna.UI2.WinForms.Guna2Button();
            this.ErrorLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PhoneTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.ConfirmButton = new Guna.UI2.WinForms.Guna2Button();
            this.UserNameHeaderLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PasswordHeaderLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PhoneHeaderLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.NameHeaderLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.NameLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PhoneLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.UserNameLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PasswordLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.BackButton = new System.Windows.Forms.LinkLabel();
            this.PopoutTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
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
            this.PasswordTextBox.Location = new System.Drawing.Point(14, 244);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.PasswordTextBox.MaxLength = 25;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PasswordTextBox.PlaceholderText = "Enter Password";
            this.PasswordTextBox.SelectedText = "";
            this.PasswordTextBox.ShadowDecoration.Parent = this.PasswordTextBox;
            this.PasswordTextBox.Size = new System.Drawing.Size(647, 75);
            this.PasswordTextBox.TabIndex = 3;
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
            this.UserNameTextBox.Location = new System.Drawing.Point(14, 161);
            this.UserNameTextBox.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.UserNameTextBox.MaxLength = 25;
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.PasswordChar = '\0';
            this.UserNameTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UserNameTextBox.PlaceholderText = "Enter User Name";
            this.UserNameTextBox.SelectedText = "";
            this.UserNameTextBox.ShadowDecoration.Parent = this.UserNameTextBox;
            this.UserNameTextBox.Size = new System.Drawing.Size(647, 75);
            this.UserNameTextBox.TabIndex = 2;
            this.UserNameTextBox.TextOffset = new System.Drawing.Point(15, 0);
            this.UserNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // ConfrimPasswordTextBox
            // 
            this.ConfrimPasswordTextBox.Animated = true;
            this.ConfrimPasswordTextBox.BorderColor = System.Drawing.Color.Gray;
            this.ConfrimPasswordTextBox.BorderRadius = 28;
            this.ConfrimPasswordTextBox.BorderThickness = 2;
            this.ConfrimPasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ConfrimPasswordTextBox.DefaultText = "";
            this.ConfrimPasswordTextBox.DisabledState.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ConfrimPasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ConfrimPasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.White;
            this.ConfrimPasswordTextBox.DisabledState.Parent = this.ConfrimPasswordTextBox;
            this.ConfrimPasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ConfrimPasswordTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(48)))), ((int)(((byte)(72)))));
            this.ConfrimPasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.ConfrimPasswordTextBox.FocusedState.Parent = this.ConfrimPasswordTextBox;
            this.ConfrimPasswordTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfrimPasswordTextBox.ForeColor = System.Drawing.Color.White;
            this.ConfrimPasswordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.ConfrimPasswordTextBox.HoverState.Parent = this.ConfrimPasswordTextBox;
            this.ConfrimPasswordTextBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("ConfrimPasswordTextBox.IconLeft")));
            this.ConfrimPasswordTextBox.IconLeftOffset = new System.Drawing.Point(15, 0);
            this.ConfrimPasswordTextBox.IconLeftSize = new System.Drawing.Size(35, 35);
            this.ConfrimPasswordTextBox.Location = new System.Drawing.Point(14, 325);
            this.ConfrimPasswordTextBox.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.ConfrimPasswordTextBox.MaxLength = 25;
            this.ConfrimPasswordTextBox.Name = "ConfrimPasswordTextBox";
            this.ConfrimPasswordTextBox.PasswordChar = '*';
            this.ConfrimPasswordTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ConfrimPasswordTextBox.PlaceholderText = "Confirm Password";
            this.ConfrimPasswordTextBox.SelectedText = "";
            this.ConfrimPasswordTextBox.ShadowDecoration.Parent = this.ConfrimPasswordTextBox;
            this.ConfrimPasswordTextBox.Size = new System.Drawing.Size(647, 75);
            this.ConfrimPasswordTextBox.TabIndex = 4;
            this.ConfrimPasswordTextBox.TextOffset = new System.Drawing.Point(15, 0);
            this.ConfrimPasswordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
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
            this.NameTextBox.Location = new System.Drawing.Point(14, 0);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.NameTextBox.MaxLength = 25;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.PasswordChar = '\0';
            this.NameTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NameTextBox.PlaceholderText = "Enter HR Name";
            this.NameTextBox.SelectedText = "";
            this.NameTextBox.ShadowDecoration.Parent = this.NameTextBox;
            this.NameTextBox.Size = new System.Drawing.Size(647, 75);
            this.NameTextBox.TabIndex = 0;
            this.NameTextBox.TextOffset = new System.Drawing.Point(15, 0);
            this.NameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // SignUpButton
            // 
            this.SignUpButton.Animated = true;
            this.SignUpButton.BackColor = System.Drawing.Color.Transparent;
            this.SignUpButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(48)))), ((int)(((byte)(72)))));
            this.SignUpButton.BorderRadius = 20;
            this.SignUpButton.BorderThickness = 3;
            this.SignUpButton.CheckedState.Parent = this.SignUpButton;
            this.SignUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUpButton.CustomImages.Parent = this.SignUpButton;
            this.SignUpButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(48)))), ((int)(((byte)(72)))));
            this.SignUpButton.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpButton.ForeColor = System.Drawing.Color.White;
            this.SignUpButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.SignUpButton.HoverState.ForeColor = System.Drawing.Color.Black;
            this.SignUpButton.HoverState.Parent = this.SignUpButton;
            this.SignUpButton.Location = new System.Drawing.Point(748, 173);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.PressedDepth = 80;
            this.SignUpButton.ShadowDecoration.BorderRadius = 20;
            this.SignUpButton.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.SignUpButton.ShadowDecoration.Depth = 70;
            this.SignUpButton.ShadowDecoration.Enabled = true;
            this.SignUpButton.ShadowDecoration.Parent = this.SignUpButton;
            this.SignUpButton.Size = new System.Drawing.Size(363, 63);
            this.SignUpButton.TabIndex = 5;
            this.SignUpButton.TabStop = false;
            this.SignUpButton.Text = "Register";
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            this.SignUpButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = false;
            this.ErrorLabel.BackColor = System.Drawing.Color.Transparent;
            this.ErrorLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.ErrorLabel.Location = new System.Drawing.Point(708, 259);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(439, 43);
            this.ErrorLabel.TabIndex = 6;
            this.ErrorLabel.TabStop = false;
            this.ErrorLabel.Text = "Please Fill All Previous Data";
            this.ErrorLabel.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.ErrorLabel.Visible = false;
            this.ErrorLabel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Animated = true;
            this.PhoneTextBox.BorderColor = System.Drawing.Color.Gray;
            this.PhoneTextBox.BorderRadius = 28;
            this.PhoneTextBox.BorderThickness = 2;
            this.PhoneTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PhoneTextBox.DefaultText = "";
            this.PhoneTextBox.DisabledState.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PhoneTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.PhoneTextBox.DisabledState.ForeColor = System.Drawing.Color.White;
            this.PhoneTextBox.DisabledState.Parent = this.PhoneTextBox;
            this.PhoneTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PhoneTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(48)))), ((int)(((byte)(72)))));
            this.PhoneTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.PhoneTextBox.FocusedState.Parent = this.PhoneTextBox;
            this.PhoneTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneTextBox.ForeColor = System.Drawing.Color.White;
            this.PhoneTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.PhoneTextBox.HoverState.Parent = this.PhoneTextBox;
            this.PhoneTextBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("PhoneTextBox.IconLeft")));
            this.PhoneTextBox.IconLeftOffset = new System.Drawing.Point(12, 0);
            this.PhoneTextBox.IconLeftSize = new System.Drawing.Size(40, 45);
            this.PhoneTextBox.Location = new System.Drawing.Point(14, 82);
            this.PhoneTextBox.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.PhoneTextBox.MaxLength = 11;
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.PasswordChar = '\0';
            this.PhoneTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PhoneTextBox.PlaceholderText = "Enter HR Phone";
            this.PhoneTextBox.SelectedText = "";
            this.PhoneTextBox.ShadowDecoration.Parent = this.PhoneTextBox;
            this.PhoneTextBox.Size = new System.Drawing.Size(647, 75);
            this.PhoneTextBox.TabIndex = 1;
            this.PhoneTextBox.TextOffset = new System.Drawing.Point(15, 0);
            this.PhoneTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Animated = true;
            this.ConfirmButton.BackColor = System.Drawing.Color.Transparent;
            this.ConfirmButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(48)))), ((int)(((byte)(72)))));
            this.ConfirmButton.BorderRadius = 20;
            this.ConfirmButton.BorderThickness = 3;
            this.ConfirmButton.CheckedState.Parent = this.ConfirmButton;
            this.ConfirmButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConfirmButton.CustomImages.Parent = this.ConfirmButton;
            this.ConfirmButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(48)))), ((int)(((byte)(72)))));
            this.ConfirmButton.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmButton.ForeColor = System.Drawing.Color.White;
            this.ConfirmButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.ConfirmButton.HoverState.ForeColor = System.Drawing.Color.Black;
            this.ConfirmButton.HoverState.Parent = this.ConfirmButton;
            this.ConfirmButton.Location = new System.Drawing.Point(748, 337);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.PressedDepth = 80;
            this.ConfirmButton.ShadowDecoration.BorderRadius = 20;
            this.ConfirmButton.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.ConfirmButton.ShadowDecoration.Depth = 70;
            this.ConfirmButton.ShadowDecoration.Enabled = true;
            this.ConfirmButton.ShadowDecoration.Parent = this.ConfirmButton;
            this.ConfirmButton.Size = new System.Drawing.Size(363, 63);
            this.ConfirmButton.TabIndex = 7;
            this.ConfirmButton.TabStop = false;
            this.ConfirmButton.Text = "Confirm Data";
            this.ConfirmButton.Visible = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // UserNameHeaderLabel
            // 
            this.UserNameHeaderLabel.AutoSize = false;
            this.UserNameHeaderLabel.BackColor = System.Drawing.Color.Transparent;
            this.UserNameHeaderLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameHeaderLabel.ForeColor = System.Drawing.Color.White;
            this.UserNameHeaderLabel.Location = new System.Drawing.Point(72, 549);
            this.UserNameHeaderLabel.Name = "UserNameHeaderLabel";
            this.UserNameHeaderLabel.Size = new System.Drawing.Size(231, 43);
            this.UserNameHeaderLabel.TabIndex = 9;
            this.UserNameHeaderLabel.TabStop = false;
            this.UserNameHeaderLabel.Text = "User Name : ";
            this.UserNameHeaderLabel.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.UserNameHeaderLabel.Visible = false;
            // 
            // PasswordHeaderLabel
            // 
            this.PasswordHeaderLabel.AutoSize = false;
            this.PasswordHeaderLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswordHeaderLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordHeaderLabel.ForeColor = System.Drawing.Color.White;
            this.PasswordHeaderLabel.Location = new System.Drawing.Point(72, 598);
            this.PasswordHeaderLabel.Name = "PasswordHeaderLabel";
            this.PasswordHeaderLabel.Size = new System.Drawing.Size(206, 43);
            this.PasswordHeaderLabel.TabIndex = 10;
            this.PasswordHeaderLabel.TabStop = false;
            this.PasswordHeaderLabel.Text = "Password : ";
            this.PasswordHeaderLabel.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.PasswordHeaderLabel.Visible = false;
            // 
            // PhoneHeaderLabel
            // 
            this.PhoneHeaderLabel.AutoSize = false;
            this.PhoneHeaderLabel.BackColor = System.Drawing.Color.Transparent;
            this.PhoneHeaderLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneHeaderLabel.ForeColor = System.Drawing.Color.White;
            this.PhoneHeaderLabel.Location = new System.Drawing.Point(72, 492);
            this.PhoneHeaderLabel.Name = "PhoneHeaderLabel";
            this.PhoneHeaderLabel.Size = new System.Drawing.Size(160, 43);
            this.PhoneHeaderLabel.TabIndex = 11;
            this.PhoneHeaderLabel.TabStop = false;
            this.PhoneHeaderLabel.Text = "Phone : ";
            this.PhoneHeaderLabel.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.PhoneHeaderLabel.Visible = false;
            // 
            // NameHeaderLabel
            // 
            this.NameHeaderLabel.AutoSize = false;
            this.NameHeaderLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameHeaderLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameHeaderLabel.ForeColor = System.Drawing.Color.White;
            this.NameHeaderLabel.Location = new System.Drawing.Point(72, 443);
            this.NameHeaderLabel.Name = "NameHeaderLabel";
            this.NameHeaderLabel.Size = new System.Drawing.Size(160, 43);
            this.NameHeaderLabel.TabIndex = 8;
            this.NameHeaderLabel.TabStop = false;
            this.NameHeaderLabel.Text = "Name : ";
            this.NameHeaderLabel.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.NameHeaderLabel.Visible = false;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = false;
            this.NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.NameLabel.Location = new System.Drawing.Point(407, 443);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(765, 43);
            this.NameLabel.TabIndex = 12;
            this.NameLabel.TabStop = false;
            this.NameLabel.Text = "Name : ";
            this.NameLabel.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.NameLabel.Visible = false;
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = false;
            this.PhoneLabel.BackColor = System.Drawing.Color.Transparent;
            this.PhoneLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.PhoneLabel.Location = new System.Drawing.Point(407, 492);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(765, 43);
            this.PhoneLabel.TabIndex = 13;
            this.PhoneLabel.TabStop = false;
            this.PhoneLabel.Text = "Name : ";
            this.PhoneLabel.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.PhoneLabel.Visible = false;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = false;
            this.UserNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UserNameLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.UserNameLabel.Location = new System.Drawing.Point(407, 549);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(765, 43);
            this.UserNameLabel.TabIndex = 14;
            this.UserNameLabel.TabStop = false;
            this.UserNameLabel.Text = "Name : ";
            this.UserNameLabel.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.UserNameLabel.Visible = false;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = false;
            this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.PasswordLabel.Location = new System.Drawing.Point(407, 598);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(765, 43);
            this.PasswordLabel.TabIndex = 15;
            this.PasswordLabel.TabStop = false;
            this.PasswordLabel.Text = "Name : ";
            this.PasswordLabel.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.PasswordLabel.Visible = false;
            // 
            // BackButton
            // 
            this.BackButton.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.BackButton.AutoSize = true;
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.LinkColor = System.Drawing.Color.LimeGreen;
            this.BackButton.Location = new System.Drawing.Point(720, 403);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(93, 45);
            this.BackButton.TabIndex = 16;
            this.BackButton.TabStop = true;
            this.BackButton.Text = "Back";
            this.BackButton.Visible = false;
            this.BackButton.VisitedLinkColor = System.Drawing.Color.LimeGreen;
            this.BackButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BackButton_LinkClicked);
            // 
            // PopoutTimer
            // 
            this.PopoutTimer.Interval = 20;
            this.PopoutTimer.Tick += new System.EventHandler(this.PopoutTimer_Tick);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(48)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(1220, 656);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.PhoneHeaderLabel);
            this.Controls.Add(this.PasswordHeaderLabel);
            this.Controls.Add(this.UserNameHeaderLabel);
            this.Controls.Add(this.NameHeaderLabel);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.ConfrimPasswordTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UserNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.Load += new System.EventHandler(this.SignUpForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox PasswordTextBox;
        private Guna.UI2.WinForms.Guna2TextBox UserNameTextBox;
        private Guna.UI2.WinForms.Guna2TextBox ConfrimPasswordTextBox;
        private Guna.UI2.WinForms.Guna2TextBox NameTextBox;
        private Guna.UI2.WinForms.Guna2Button SignUpButton;
        private Guna.UI2.WinForms.Guna2HtmlLabel ErrorLabel;
        private Guna.UI2.WinForms.Guna2TextBox PhoneTextBox;
        private Guna.UI2.WinForms.Guna2Button ConfirmButton;
        private Guna.UI2.WinForms.Guna2HtmlLabel UserNameHeaderLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel PasswordHeaderLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel PhoneHeaderLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel NameHeaderLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel NameLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel PhoneLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel UserNameLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel PasswordLabel;
        private System.Windows.Forms.LinkLabel BackButton;
        private System.Windows.Forms.Timer PopoutTimer;
    }
}