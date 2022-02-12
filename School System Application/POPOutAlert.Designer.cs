namespace School_System_Application
{
    partial class POPOutAlert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POPOutAlert));
            this.FormElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.FormTransition = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.FormDrag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.AlertPictureBox = new System.Windows.Forms.PictureBox();
            this.CloseButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.AlertLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AlertPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FormElipse
            // 
            this.FormElipse.ElipseRadius = 80;
            this.FormElipse.TargetControl = this;
            // 
            // FormTransition
            // 
            this.FormTransition.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_HOR_NEGATIVE;
            this.FormTransition.Interval = 600;
            // 
            // FormDrag
            // 
            this.FormDrag.TargetControl = this;
            // 
            // AlertPictureBox
            // 
            this.AlertPictureBox.Image = global::School_System_Application.Properties.Resources.Error_1;
            this.AlertPictureBox.Location = new System.Drawing.Point(13, 14);
            this.AlertPictureBox.Name = "AlertPictureBox";
            this.AlertPictureBox.Size = new System.Drawing.Size(65, 68);
            this.AlertPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AlertPictureBox.TabIndex = 20;
            this.AlertPictureBox.TabStop = false;
            // 
            // CloseButton
            // 
            this.CloseButton.CheckedState.ImageSize = new System.Drawing.Size(23, 23);
            this.CloseButton.CheckedState.Parent = this.CloseButton;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.HoverState.ImageSize = new System.Drawing.Size(23, 23);
            this.CloseButton.HoverState.Parent = this.CloseButton;
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.ImageSize = new System.Drawing.Size(25, 25);
            this.CloseButton.Location = new System.Drawing.Point(584, 16);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.PressedState.Parent = this.CloseButton;
            this.CloseButton.Size = new System.Drawing.Size(50, 52);
            this.CloseButton.TabIndex = 19;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // AlertLabel
            // 
            this.AlertLabel.AutoSize = true;
            this.AlertLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.AlertLabel.ForeColor = System.Drawing.Color.White;
            this.AlertLabel.Location = new System.Drawing.Point(77, 72);
            this.AlertLabel.Name = "AlertLabel";
            this.AlertLabel.Size = new System.Drawing.Size(250, 41);
            this.AlertLabel.TabIndex = 22;
            this.AlertLabel.Text = "This is Our Label";
            // 
            // POPOutAlert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(650, 197);
            this.Controls.Add(this.AlertLabel);
            this.Controls.Add(this.AlertPictureBox);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "POPOutAlert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PopOut Alert";
            this.Load += new System.EventHandler(this.POPOutAlert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AlertPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse FormElipse;
        private Guna.UI2.WinForms.Guna2AnimateWindow FormTransition;
        private Guna.UI2.WinForms.Guna2DragControl FormDrag;
        private Guna.UI2.WinForms.Guna2ImageButton CloseButton;
        private System.Windows.Forms.PictureBox AlertPictureBox;
        private System.Windows.Forms.Label AlertLabel;
    }
}