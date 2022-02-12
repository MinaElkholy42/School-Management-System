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
    public partial class TeacherReportForm : Form
    {
        public TeacherReportForm()
        {
            InitializeComponent();
        }

        private void TeacherReportForm_Load(object sender, EventArgs e)
        {
            // make the form transition using the form trainstion 
            FormTransition.SetAnimateWindow(this); 
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            // close the current form only 
            this.Close();
        }

        private void MinimizationButton_Click(object sender, EventArgs e)
        {
            // make the form minmized (down the all forms in the taskbar) using the window state 
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
