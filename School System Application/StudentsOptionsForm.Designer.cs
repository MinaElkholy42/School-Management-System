namespace School_System_Application
{
    partial class StudentsOptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentsOptionsForm));
            this.AddTeacherButton = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.SuspendLayout();
            // 
            // AddTeacherButton
            // 
            this.AddTeacherButton.Animated = true;
            this.AddTeacherButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.AddTeacherButton.BorderRadius = 40;
            this.AddTeacherButton.BorderThickness = 3;
            this.AddTeacherButton.CheckedState.Parent = this.AddTeacherButton;
            this.AddTeacherButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddTeacherButton.CustomImages.Parent = this.AddTeacherButton;
            this.AddTeacherButton.FillColor = System.Drawing.Color.Black;
            this.AddTeacherButton.FillColor2 = System.Drawing.Color.Black;
            this.AddTeacherButton.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTeacherButton.ForeColor = System.Drawing.Color.White;
            this.AddTeacherButton.HoverState.FillColor = System.Drawing.Color.Black;
            this.AddTeacherButton.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.AddTeacherButton.HoverState.Parent = this.AddTeacherButton;
            this.AddTeacherButton.Image = ((System.Drawing.Image)(resources.GetObject("AddTeacherButton.Image")));
            this.AddTeacherButton.ImageSize = new System.Drawing.Size(40, 40);
            this.AddTeacherButton.Location = new System.Drawing.Point(433, 12);
            this.AddTeacherButton.Name = "AddTeacherButton";
            this.AddTeacherButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.AddTeacherButton.PressedDepth = 100;
            this.AddTeacherButton.ShadowDecoration.Parent = this.AddTeacherButton;
            this.AddTeacherButton.Size = new System.Drawing.Size(307, 122);
            this.AddTeacherButton.TabIndex = 1;
            this.AddTeacherButton.Text = "Add Teacher";
            this.AddTeacherButton.TextOffset = new System.Drawing.Point(0, -5);
            // 
            // StudentsOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1220, 606);
            this.Controls.Add(this.AddTeacherButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentsOptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Students Options";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientTileButton AddTeacherButton;
    }
}