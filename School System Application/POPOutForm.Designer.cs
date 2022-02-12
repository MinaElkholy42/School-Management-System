namespace School_System_Application
{
    partial class POPOutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POPOutForm));
            this.Label1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.HeaderLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.HeaderAlertLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.HeaderLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Label2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.FormDrag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.FormTransition = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.FormElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.CloseButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = false;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.Label1.Location = new System.Drawing.Point(292, 80);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(475, 43);
            this.Label1.TabIndex = 14;
            this.Label1.TabStop = false;
            this.Label1.Text = "Prince Of Persia The Darkness";
            this.Label1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // HeaderLabel1
            // 
            this.HeaderLabel1.AutoSize = false;
            this.HeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.HeaderLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel1.ForeColor = System.Drawing.Color.White;
            this.HeaderLabel1.Location = new System.Drawing.Point(22, 80);
            this.HeaderLabel1.Name = "HeaderLabel1";
            this.HeaderLabel1.Size = new System.Drawing.Size(181, 43);
            this.HeaderLabel1.TabIndex = 13;
            this.HeaderLabel1.TabStop = false;
            this.HeaderLabel1.Text = "Name : ";
            this.HeaderLabel1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // HeaderAlertLabel
            // 
            this.HeaderAlertLabel.AutoSize = false;
            this.HeaderAlertLabel.BackColor = System.Drawing.Color.Transparent;
            this.HeaderAlertLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderAlertLabel.ForeColor = System.Drawing.Color.White;
            this.HeaderAlertLabel.Location = new System.Drawing.Point(292, 11);
            this.HeaderAlertLabel.Name = "HeaderAlertLabel";
            this.HeaderAlertLabel.Size = new System.Drawing.Size(216, 43);
            this.HeaderAlertLabel.TabIndex = 15;
            this.HeaderAlertLabel.TabStop = false;
            this.HeaderAlertLabel.Text = "Recover Data";
            this.HeaderAlertLabel.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // HeaderLabel2
            // 
            this.HeaderLabel2.AutoSize = false;
            this.HeaderLabel2.BackColor = System.Drawing.Color.Transparent;
            this.HeaderLabel2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel2.ForeColor = System.Drawing.Color.White;
            this.HeaderLabel2.Location = new System.Drawing.Point(22, 141);
            this.HeaderLabel2.Name = "HeaderLabel2";
            this.HeaderLabel2.Size = new System.Drawing.Size(181, 43);
            this.HeaderLabel2.TabIndex = 16;
            this.HeaderLabel2.TabStop = false;
            this.HeaderLabel2.Text = "Code : ";
            this.HeaderLabel2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // Label2
            // 
            this.Label2.AutoSize = false;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.Label2.Location = new System.Drawing.Point(292, 141);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(475, 43);
            this.Label2.TabIndex = 17;
            this.Label2.TabStop = false;
            this.Label2.Text = "123456";
            this.Label2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // FormDrag
            // 
            this.FormDrag.TargetControl = this;
            // 
            // FormTransition
            // 
            this.FormTransition.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_HOR_NEGATIVE;
            this.FormTransition.Interval = 600;
            // 
            // FormElipse
            // 
            this.FormElipse.ElipseRadius = 80;
            this.FormElipse.TargetControl = this;
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
            this.CloseButton.Location = new System.Drawing.Point(732, 2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.PressedState.Parent = this.CloseButton;
            this.CloseButton.Size = new System.Drawing.Size(56, 62);
            this.CloseButton.TabIndex = 18;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // POPOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(48)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(800, 213);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.HeaderLabel2);
            this.Controls.Add(this.HeaderAlertLabel);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.HeaderLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "POPOutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PopOut Data";
            this.Load += new System.EventHandler(this.POPOutForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel Label1;
        private Guna.UI2.WinForms.Guna2HtmlLabel HeaderLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel HeaderAlertLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel HeaderLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel Label2;
        private Guna.UI2.WinForms.Guna2DragControl FormDrag;
        private Guna.UI2.WinForms.Guna2AnimateWindow FormTransition;
        private Bunifu.Framework.UI.BunifuElipse FormElipse;
        private Guna.UI2.WinForms.Guna2ImageButton CloseButton;
    }
}