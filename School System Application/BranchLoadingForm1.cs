using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_System_Application
{
    public partial class BranchLoadingForm1 : Form
    {
        // thess variables will hold the location of the x axis and the y axis of the form 
        int locationformx, locationformy;
        // default constructor 
        public BranchLoadingForm1()
        {
            InitializeComponent();
        }

        // paramatrized Constructor
        public BranchLoadingForm1(int locationfrom_x, int locationform_y)
        {
            InitializeComponent();
            // assign the x and y coordinates for the form 
            locationformx = locationfrom_x;
            locationformy = locationform_y;
        }


        private void BranchLoadingForm1_Load(object sender, EventArgs e)
        {
            // assign the x and y for the form 
            this.Location = new Point(locationformx, locationformy);
            // make the value of the progress circule to zero 
            ProgressCircule.Value = 0;
            // start the timer of the progress circule 
            ProgressCirculeTimer.Start();
        }

        private void ProgressCirculeTimer_Tick(object sender, EventArgs e)
        {
            // each tick increase the progress bar of the circule by 10 points 
            ProgressCircule.Value += 20; 
            // case we reach the maximum of the value (350) or more 
            if(ProgressCircule.Value >=350)
            {
                // stop the timer 
                ProgressCirculeTimer.Stop();
                // close the current loading form 
                this.Dispose();    
            }
        }
    }
}
