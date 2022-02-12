namespace School_System_Application
{
    partial class ClassesOptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassesOptionsForm));
            this.LeaveButton = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.SuspendLayout();
            // 
            // LeaveButton
            // 
            this.LeaveButton.Animated = true;
            this.LeaveButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.LeaveButton.BorderRadius = 40;
            this.LeaveButton.BorderThickness = 3;
            this.LeaveButton.CheckedState.Parent = this.LeaveButton;
            this.LeaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LeaveButton.CustomImages.Parent = this.LeaveButton;
            this.LeaveButton.FillColor = System.Drawing.Color.Black;
            this.LeaveButton.FillColor2 = System.Drawing.Color.Black;
            this.LeaveButton.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeaveButton.ForeColor = System.Drawing.Color.White;
            this.LeaveButton.HoverState.FillColor = System.Drawing.Color.Black;
            this.LeaveButton.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.LeaveButton.HoverState.Parent = this.LeaveButton;
            this.LeaveButton.Image = ((System.Drawing.Image)(resources.GetObject("LeaveButton.Image")));
            this.LeaveButton.ImageSize = new System.Drawing.Size(40, 40);
            this.LeaveButton.Location = new System.Drawing.Point(369, 12);
            this.LeaveButton.Name = "LeaveButton";
            this.LeaveButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.LeaveButton.PressedDepth = 100;
            this.LeaveButton.ShadowDecoration.Parent = this.LeaveButton;
            this.LeaveButton.Size = new System.Drawing.Size(397, 122);
            this.LeaveButton.TabIndex = 4;
            this.LeaveButton.Text = "Leave Registration";
            this.LeaveButton.TextOffset = new System.Drawing.Point(0, -5);
            // 
            // ClassesOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1220, 606);
            this.Controls.Add(this.LeaveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClassesOptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Classes Options";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientTileButton LeaveButton;
    }
}