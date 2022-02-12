using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
namespace School_System_Application
{
    public partial class IntroductionForm : Form
    {
        // this variabel to indicate the progress of the from
        int progresscount;
        // make object from the main functions class 
        MainFunctions_Class mc;
        public IntroductionForm()
        {
            InitializeComponent();
            // initialize the count of the progress with zero 
            progresscount = 0;
            // initialize the object of Main funciton Class
            mc = new MainFunctions_Class();
        }

        private void IntroductionForm_Load(object sender, EventArgs e)
        {
            // make the top most of this form true to be on all other applications in the desktop 
            this.TopMost = true;
            // set the animation of the window using the form animator
            FormTransition.SetAnimateWindow(this);
            // call this function to make the labels transparent in the cuurent form
            mc.MakeLabelTranspaernt(ref label1, ref PictureBox);
            mc.MakeLabelTranspaernt(ref label2, ref PictureBox);
            mc.MakeLabelTranspaernt(ref label3, ref PictureBox);
            mc.MakeLabelTranspaernt(ref label4, ref PictureBox);
            mc.MakeLabelTranspaernt(ref label5, ref PictureBox);
            mc.MakeLabelTranspaernt(ref label6, ref PictureBox);
            // start the progress  timer now 
            ProgressTimer.Start();
        }

        private void ProgressTimer_Tick(object sender, EventArgs e)
        {
            // increament the progress count by 1 
            progresscount++; 
            // check if we reach the end of the progress of 53
            if(progresscount == 53)
            {
                // stop the timer of the progress
                ProgressTimer.Stop();
                // move to the video form 
                VideoForm vf = new VideoForm(); // make object from the video form
                this.Hide(); // hide the current from 
                vf.TopLevel = true; // make the next form on the top of all current forms
                vf.Show(); // show the next form
            }
        }
    }
}
