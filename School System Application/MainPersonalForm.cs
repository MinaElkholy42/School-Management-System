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
    public partial class MainPersonalForm : Form
    {
        // make object from the main functions class 
        MainFunctions_Class mc;
        // make this panel for the under line of the button border 
        Panel downpanel;
        // this integer is the original x axis of the Header label 
        int xlabel;
        // this flag to indicate weather to load the branch loading form with the log in or not
        bool branchformflag;
        // this object form will indicate which current child form we want to open 
        Form currentchildform;
        // make object to hold the main personal form 
        Form ThisForm;
        public MainPersonalForm(bool flag)
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

            // initialize the integer of the x position of the label 
            xlabel = 373;

            // assign the loading branch form flag
            branchformflag = flag;

            // initialize the current child form with new form 
            currentchildform = new Form();

            // assign the current form to this object for the log in form
            ThisForm = this; 
        }

        /// <summary>
        /// This function to open the child form we want using the button
        /// </summary>
        /// <param name="childform"> The form we want to open </param>
        public void OpenChildForm(Form childform)
        {
            // check if the child form is already opened 
            if (currentchildform.Name == "LogInForm" || currentchildform.Name == "RecoverAccountForm" ||
                currentchildform.Name == "SignUpForm") // close the child form 
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

        private void MainPersonalForm_Load(object sender, EventArgs e)
        {
            // set the animations of the from using the form animator 
            FormTransition.SetAnimateWindow(this);

            // call this function to make the labels transparent in the cuurent form
            mc.MakeLabelTranspaernt(ref HeaderLabel, ref BannerPictureBox);

            // make the login button form checked 
            LoginFormButton.Checked = true;

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

        private void LoginFormButton_CheckedChanged(object sender, EventArgs e)
        {
            // case the button is checked 
            if (LoginFormButton.Checked)
            {
                // call this fucntion to set the down panel of the button
                mc.SetButtonPanel(LoginFormButton.Location.X + 5, LoginFormButton.Height - 10, ref downpanel, 67);
                // call this function to set the text of the label inside the picture box 
                mc.SetLabels(ref HeaderLabel, "Account LogIn", xlabel - 10);
                // check if the loading branch form flag 
                if (branchformflag)
                    // call this function to load the branch loading form
                    mc.OpenBranchLoadingForm1(this.Location.X, this.Location.Y);
                branchformflag = true; // make the flag true for the next step 

                // open the child log in form by calling this function
                OpenChildForm(new LogInForm(ref HeaderLabel, ref ThisForm));
            }
        }

        private void SignUpForm_CheckedChanged(object sender, EventArgs e)
        {
            // case the button is checked 
            if (SignUpForm.Checked)
            {
                // call this fucntion to set the down panel of the button
                mc.SetButtonPanel(SignUpForm.Location.X + 15, SignUpForm.Height - 10, ref downpanel, 90);
                // call this function to set the text of the label inside the picture box 
                mc.SetLabels(ref HeaderLabel, "Account Sign Up", xlabel - 20);
                // call this function to load the branch loading form
                mc.OpenBranchLoadingForm1(this.Location.X, this.Location.Y);
                // open the sign up form by calling this function
                OpenChildForm(new SignUpForm(ref HeaderLabel, ref LoginFormButton));
            }
        }

        private void ForgetAccountForm_CheckedChanged(object sender, EventArgs e)
        {
            // case the button is checked 
            if (ForgetAccountForm.Checked)
            {
                // call this fucntion to set the down panel of the button
                mc.SetButtonPanel(ForgetAccountForm.Location.X + 5, ForgetAccountForm.Height - 10, ref downpanel, 170);
                // call this function to set the text of the label inside the picture box 
                mc.SetLabels(ref HeaderLabel, "Account Recovery", xlabel - 40);
                // call this function to load the branch loading form
                mc.OpenBranchLoadingForm1(this.Location.X, this.Location.Y);
                // open the sign up form by calling this function
                OpenChildForm(new RecoverAccountForm());
            }
        }
    }
}
