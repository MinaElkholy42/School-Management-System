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
    public partial class SchoolControlsForm : Form
    {
        // make object from the main functions class 
        MainFunctions_Class mc;
        // make this panel for the under line of the button border 
        Panel downpanel;
        // this flag to indicate weather to load the branch loading form with the log in or not
        bool branchformflag;
        // this object form will indicate which current child form we want to open 
        Form currentchildform;

        // paramatrized Constructor
        public SchoolControlsForm(bool flag)
        {
            InitializeComponent();

            // initialize the object of Main funciton Class
            mc = new MainFunctions_Class();

            // initialize the downpanel of the buttons 
            downpanel = new Panel();
            // make new reference for the size of the panel 
            downpanel.Size = new Size();
            // add the downpanel to the header panel 
            HeaderPanel.Controls.Add(downpanel);

            // assign the loading branch form flag
            branchformflag = flag;

            // initialize the current child form with new form 
            currentchildform = new Form();
        }

        /// <summary>
        /// This function to open the child form we want using the button
        /// </summary>
        /// <param name="childform"> The form we want to open </param>
        public void OpenChildForm(Form childform)
        {
            // check if the child form is already opened 
            if (currentchildform.Name == "TeachersOptionsForm" || currentchildform.Name == "StudentsOptionsForm" ||
                currentchildform.Name == "ClassesOptionsForm" || currentchildform.Name == "BenifitsOptionsForm"
                 || currentchildform.Name == "AboutUsForm") // close the child form 
                currentchildform.Close();
            // assign the new current child form 
            currentchildform = childform;

            // make the top level disapled for the child form 
            childform.TopLevel = false;
            // make the child form with no borders 
            childform.FormBorderStyle = FormBorderStyle.None;
            // make the child form fill the panel 
            childform.Dock = DockStyle.Fill;

            // add the child form to the controls of the panel 
            FormsPanel.Controls.Add(childform);
            // make the current run control is the child form 
            FormsPanel.Tag = childform;

            // make the form show on the panel and bring it on the front of all other controls 
            childform.BringToFront();
            childform.Show();
        }

        private void SchoolControlsForm_Load(object sender, EventArgs e)
        {
            // set the animations of the from using the form animator 
            FormTransition.SetAnimateWindow(this);
            // make the teachers button checked 
            TeachersButton.Checked = true;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            // exit the application 
            Application.Exit();
        }

        private void MinimizationButton_Click(object sender, EventArgs e)
        {
            // make the window state of the form down in the task bar 
            WindowState = FormWindowState.Minimized;
        }


        private void LogOutButton_Click(object sender, EventArgs e)
        {
            // make object from the main personal form 
            MainPersonalForm mf = new MainPersonalForm(false);
            // hide the current from 
            this.Hide();
            // make the mf form on the top level 
            mf.TopLevel = true;
            // show the main personal form 
            mf.Show();
        }

        private void TeachersButton_CheckedChanged(object sender, EventArgs e)
        {
            // case the button is checked 
            if (TeachersButton.Checked)
            {
                // call this fucntion to set the down panel of the button
                mc.SetButtonPanel(TeachersButton.Location.X + 16, TeachersButton.Height - 10, ref downpanel, 100);
                // check if the loading branch form flag 
                if (branchformflag)
                    // call this function to load the branch loading form
                    mc.OpenBranchLoadingForm1(this.Location.X, this.Location.Y);
                branchformflag = true; // make the flag true for the next step 
                // open the child log in form by calling this function
                OpenChildForm(new TeachersOptionsForm());
            }
        }

        private void StudentsButton_CheckedChanged(object sender, EventArgs e)
        {
            // case the button is checked 
            if (StudentsButton.Checked)
            {
                // call this fucntion to set the down panel of the button
                mc.SetButtonPanel(StudentsButton.Location.X + 12, StudentsButton.Height - 10, ref downpanel, 100);
                // call this function to load the branch loading form
                mc.OpenBranchLoadingForm1(this.Location.X, this.Location.Y);
                // open the child log in form by calling this function
                OpenChildForm(new StudentsOptionsForm());
            }
        }

        private void ClassesButton_CheckedChanged(object sender, EventArgs e)
        {
            // case the button is checked 
            if (ClassesButton.Checked)
            {
                // call this fucntion to set the down panel of the button
                mc.SetButtonPanel(ClassesButton.Location.X + 12, ClassesButton.Height - 10, ref downpanel, 83);
                // call this function to load the branch loading form
                mc.OpenBranchLoadingForm1(this.Location.X, this.Location.Y);
                // open the child log in form by calling this function
                OpenChildForm(new ClassesOptionsForm());
            }
        }

        private void BenefitsButton_CheckedChanged(object sender, EventArgs e)
        {
            // case the button is checked 
            if (BenefitsButton.Checked)
            {
                // call this fucntion to set the down panel of the button
                mc.SetButtonPanel(BenefitsButton.Location.X + 15, BenefitsButton.Height - 10, ref downpanel, 96);
                // call this function to load the branch loading form
                mc.OpenBranchLoadingForm1(this.Location.X, this.Location.Y);
                // open the child log in form by calling this function
                OpenChildForm(new BenifitsOptionsForm());
            }
        }

        private void AboutButton_CheckedChanged(object sender, EventArgs e)
        {
            // case the button is checked 
            if (AboutButton.Checked)
            {
                // call this fucntion to set the down panel of the button
                mc.SetButtonPanel(AboutButton.Location.X + 9, AboutButton.Height - 10, ref downpanel, 108);
                // call this function to load the branch loading form
                mc.OpenBranchLoadingForm1(this.Location.X, this.Location.Y);
                // open the child log in form by calling this function
                OpenChildForm(new AboutUsForm());
            }
        }
    }
}
