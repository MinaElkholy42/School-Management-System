namespace School_System_Application
{
    partial class TeacherReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherReportForm));
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.OptionsLabel = new System.Windows.Forms.Label();
            this.MinimizationButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.CloseButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.FormDrag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.FormTransition = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.FormElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.BackGroundPictureBox = new System.Windows.Forms.PictureBox();
            this.TeachersReportDGV = new System.Windows.Forms.DataGridView();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackGroundPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeachersReportDGV)).BeginInit();
            this.SuspendLayout();
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
            this.HeaderPanel.TabIndex = 3;
            // 
            // OptionsLabel
            // 
            this.OptionsLabel.AutoSize = true;
            this.OptionsLabel.Font = new System.Drawing.Font("Algerian", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.OptionsLabel.Location = new System.Drawing.Point(344, 25);
            this.OptionsLabel.Name = "OptionsLabel";
            this.OptionsLabel.Size = new System.Drawing.Size(499, 45);
            this.OptionsLabel.TabIndex = 14;
            this.OptionsLabel.Text = "Teachers Report View";
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
            // FormDrag
            // 
            this.FormDrag.TargetControl = this.HeaderPanel;
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
            this.BackGroundPictureBox.Size = new System.Drawing.Size(1220, 1006);
            this.BackGroundPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackGroundPictureBox.TabIndex = 4;
            this.BackGroundPictureBox.TabStop = false;
            // 
            // TeachersReportDGV
            // 
            this.TeachersReportDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeachersReportDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TeachersReportDGV.Location = new System.Drawing.Point(0, 94);
            this.TeachersReportDGV.Name = "TeachersReportDGV";
            this.TeachersReportDGV.RowTemplate.Height = 24;
            this.TeachersReportDGV.Size = new System.Drawing.Size(1220, 1006);
            this.TeachersReportDGV.TabIndex = 5;
            // 
            // TeacherReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 1100);
            this.Controls.Add(this.TeachersReportDGV);
            this.Controls.Add(this.BackGroundPictureBox);
            this.Controls.Add(this.HeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TeacherReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teahcers Report";
            this.Load += new System.EventHandler(this.TeacherReportForm_Load);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackGroundPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeachersReportDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label OptionsLabel;
        private Guna.UI2.WinForms.Guna2ImageButton MinimizationButton;
        private Guna.UI2.WinForms.Guna2ImageButton CloseButton;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private Guna.UI2.WinForms.Guna2DragControl FormDrag;
        private Guna.UI2.WinForms.Guna2AnimateWindow FormTransition;
        private Bunifu.Framework.UI.BunifuElipse FormElipse;
        private System.Windows.Forms.PictureBox BackGroundPictureBox;
        private System.Windows.Forms.DataGridView TeachersReportDGV;
    }
}