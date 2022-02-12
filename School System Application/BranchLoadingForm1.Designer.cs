namespace School_System_Application
{
    partial class BranchLoadingForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BranchLoadingForm1));
            this.FormElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ProgressCircule = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.ProgressCirculeTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // FormElipse
            // 
            this.FormElipse.ElipseRadius = 80;
            this.FormElipse.TargetControl = this;
            // 
            // ProgressCircule
            // 
            this.ProgressCircule.Animated = true;
            this.ProgressCircule.AnimationSpeed = 0.8F;
            this.ProgressCircule.BackColor = System.Drawing.Color.Transparent;
            this.ProgressCircule.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.ProgressCircule.FillOffset = 15;
            this.ProgressCircule.FillThickness = 5;
            this.ProgressCircule.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgressCircule.ForeColor = System.Drawing.Color.White;
            this.ProgressCircule.Location = new System.Drawing.Point(455, 296);
            this.ProgressCircule.Maximum = 350;
            this.ProgressCircule.Name = "ProgressCircule";
            this.ProgressCircule.ProgressColor = System.Drawing.Color.White;
            this.ProgressCircule.ProgressColor2 = System.Drawing.Color.White;
            this.ProgressCircule.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.ProgressCircule.ProgressOffset = 10;
            this.ProgressCircule.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.ProgressCircule.ProgressThickness = 21;
            this.ProgressCircule.ShadowDecoration.BorderRadius = 150;
            this.ProgressCircule.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.ProgressCircule.ShadowDecoration.Depth = 40;
            this.ProgressCircule.ShadowDecoration.Enabled = true;
            this.ProgressCircule.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ProgressCircule.ShadowDecoration.Parent = this.ProgressCircule;
            this.ProgressCircule.ShowPercentage = true;
            this.ProgressCircule.Size = new System.Drawing.Size(311, 293);
            this.ProgressCircule.TabIndex = 0;
            this.ProgressCircule.UseTransparentBackground = true;
            // 
            // ProgressCirculeTimer
            // 
            this.ProgressCirculeTimer.Interval = 20;
            this.ProgressCirculeTimer.Tick += new System.EventHandler(this.ProgressCirculeTimer_Tick);
            // 
            // BranchLoadingForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(1220, 1000);
            this.Controls.Add(this.ProgressCircule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BranchLoadingForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading";
            this.Load += new System.EventHandler(this.BranchLoadingForm1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse FormElipse;
        private Guna.UI2.WinForms.Guna2CircleProgressBar ProgressCircule;
        private System.Windows.Forms.Timer ProgressCirculeTimer;
    }
}