namespace School_System_Application
{
    partial class IntroductionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntroductionForm));
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.FormTransition = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FormElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ProgressTimer = new System.Windows.Forms.Timer(this.components);
            this.ProgressCircule = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox.Image")));
            this.PictureBox.Location = new System.Drawing.Point(0, 0);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(1327, 549);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            // 
            // FormTransition
            // 
            this.FormTransition.Interval = 460;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 40.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(413, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(741, 75);
            this.label1.TabIndex = 1;
            this.label1.Text = "Application System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 40.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.label2.Location = new System.Drawing.Point(133, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 75);
            this.label2.TabIndex = 2;
            this.label2.Text = "School";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(950, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 38);
            this.label3.TabIndex = 3;
            this.label3.Text = "Created By : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.label4.Location = new System.Drawing.Point(1143, 460);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 38);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mina Lion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.label5.Location = new System.Drawing.Point(1098, 507);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 38);
            this.label5.TabIndex = 6;
            this.label5.Text = "01151188305";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(950, 507);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 38);
            this.label6.TabIndex = 5;
            this.label6.Text = "Contact : ";
            // 
            // FormElipse
            // 
            this.FormElipse.ElipseRadius = 80;
            this.FormElipse.TargetControl = this;
            // 
            // ProgressTimer
            // 
            this.ProgressTimer.Tick += new System.EventHandler(this.ProgressTimer_Tick);
            // 
            // ProgressCircule
            // 
            this.ProgressCircule.AutoStart = true;
            this.ProgressCircule.BackColor = System.Drawing.Color.Transparent;
            this.ProgressCircule.CircleSize = 3F;
            this.ProgressCircule.Location = new System.Drawing.Point(599, 267);
            this.ProgressCircule.Name = "ProgressCircule";
            this.ProgressCircule.NumberOfCircles = 10;
            this.ProgressCircule.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.ProgressCircule.Size = new System.Drawing.Size(133, 133);
            this.ProgressCircule.TabIndex = 7;
            this.ProgressCircule.UseTransparentBackground = true;
            // 
            // IntroductionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1327, 549);
            this.Controls.Add(this.ProgressCircule);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IntroductionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start";
            this.Load += new System.EventHandler(this.IntroductionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2AnimateWindow FormTransition;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuElipse FormElipse;
        private System.Windows.Forms.Timer ProgressTimer;
        private Guna.UI2.WinForms.Guna2WinProgressIndicator ProgressCircule;
    }
}