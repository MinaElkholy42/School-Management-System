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
    public partial class TeachersOptionsForm : Form
    {
        // make object from the main functions class 
        MainFunctions_Class mc;
        public TeachersOptionsForm()
        {
            InitializeComponent();
            // initialize the object from the main functions class 
            mc = new MainFunctions_Class();
        }

        private void AddTeacherButton_Click(object sender, EventArgs e)
        {
            // this flag to indicate if the form is opened or not
            bool opened = false;
            // call this function to check if the form is already opened
            mc.CheckOpenedForm("TeacherAddForm", ref opened);
            // in case the form is closed (the flag still false) 
            if(!opened)
            {
                // make object from the desired form 
                TeacherAddForm tf = new TeacherAddForm();
                // make the form on the top level 
                tf.TopLevel = true;
                // show the desired form 
                tf.Show();
            }
        }

        private void DeleteTeacherButton_Click(object sender, EventArgs e)
        {
            // this flag to indicate if the form is opened or not
            bool opened = false;
            // call this function to check if the form is already opened
            mc.CheckOpenedForm("TeacherDeleteForm", ref opened);
            // in case the form is closed (the flag still false) 
            if (!opened)
            {
                // make object from the desired form 
                TeacherDeleteForm tf = new TeacherDeleteForm();
                // make the form on the top level 
                tf.TopLevel = true;
                // show the desired form 
                tf.Show();
            }
        }

        private void UpdateTeacherButton_Click(object sender, EventArgs e)
        {

        }

        private void AttendanceButton_Click(object sender, EventArgs e)
        {
            // this flag to indicate if the form is opened or not
            bool opened = false;
            // call this function to check if the form is already opened
            mc.CheckOpenedForm("TeacherAttendanceRecord", ref opened);
            // in case the form is closed (the flag still false) 
            if (!opened)
            {
                // make object from the desired form 
                TeacherAttendanceRecord tf = new TeacherAttendanceRecord();
                // make the form on the top level 
                tf.TopLevel = true;
                // show the desired form 
                tf.Show();
            }
        }

        private void LeaveButton_Click(object sender, EventArgs e)
        {
            // this flag to indicate if the form is opened or not
            bool opened = false;
            // call this function to check if the form is already opened
            mc.CheckOpenedForm("TeacherLeaveForm", ref opened);
            // in case the form is closed (the flag still false) 
            if (!opened)
            {
                // make object from the desired form 
                TeacherLeaveForm tf = new TeacherLeaveForm();
                // make the form on the top level 
                tf.TopLevel = true;
                // show the desired form 
                tf.Show();
            }
        }

        private void ReportsButton_Click(object sender, EventArgs e)
        {
            // this flag to indicate if the form is opened or not
            bool opened = false;
            // call this function to check if the form is already opened
            mc.CheckOpenedForm("TeacherReportForm", ref opened);
            // in case the form is closed (the flag still false) 
            if (!opened)
            {
                // make object from the desired form 
                TeacherReportForm tf = new TeacherReportForm();
                // make the form on the top level 
                tf.TopLevel = true;
                // show the desired form 
                tf.Show();
            }
        }

        private void TeacherDataButton_Click(object sender, EventArgs e)
        {

        }

        private void PDFButton_Click(object sender, EventArgs e)
        {

        }
    }
}
