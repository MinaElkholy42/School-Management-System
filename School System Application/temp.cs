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
using System.Data.SqlTypes;
using System.Data.SqlClient;
namespace School_System_Application
{
    public partial class temp : Form
    {
        // this is the first time and the temp we will use later 
        DateTime firsttime;
        public temp()
        {
            InitializeComponent();
        }

        private void HalfHourTimer_Tick(object sender, EventArgs e)
        {
            // each tick take the current time 
            DateTime nexttime = DateTime.Now; 
            // in case the difference in minutes is 30 minute 
            if((nexttime - firsttime).Minutes == 30)
            {
                // do swap between two times 
                firsttime = nexttime;
                // do what do you want nadeen <3  
                MessageBox.Show("Prince of persia"); 
            }
        }

        private void temp_Load(object sender, EventArgs e)
        {
            // start the timer 
            HalfHourTimer.Start();
            // initialize the first time 
            firsttime = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string currentdate = DateTime.Now.ToString("dddd");
            MessageBox.Show(currentdate); 
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
