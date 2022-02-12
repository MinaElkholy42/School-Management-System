using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
namespace School_System_Application
{
    public partial class POPOutAlert : Form
    {
        // this variable to indicate weather there is focus or not 
        int id ;
        // this text box we want to make focus on 
        Guna2TextBox TextBox;
        // this flag to indicate weather to make the focus or not
        bool focusflag;
        // default constructor
        public POPOutAlert()
        {
            InitializeComponent();
        }

        // paramatrized constructor
        public POPOutAlert(int heigth, string message, MainFunctions_Class.alert alerttype)
        {
            InitializeComponent();
            // assing the heigth of the from 
            this.Height = heigth;
            // assign the message of the label 
            AlertLabel.Text = message;

            // check the type of the alert 
            switch(alerttype)
            {
                // case Error 
                case MainFunctions_Class.alert.error:
                    // make the background of the alert red 
                    this.BackColor = Color.Red;
                    // make the picture box image to error_1 image 
                    AlertPictureBox.Image = Properties.Resources.Error_1;
                    break; // exit the switch 

                // case Success 
                case MainFunctions_Class.alert.success:
                    // make the background of the alert sea green 
                    this.BackColor = Color.SeaGreen;
                    // make the picture box image to rigth_1 image 
                    AlertPictureBox.Image = Properties.Resources.Right_1;
                    break; // exit the switch
            }

            // make the id to 0 (no focus) 
            id = 0;
        }

        // paramatrized constructor
        public POPOutAlert(int heigth, string message, MainFunctions_Class.alert alerttype, 
            ref Guna2TextBox textbox, bool flag)
        {
            InitializeComponent();
            // assing the heigth of the from 
            this.Height = heigth;
            // assign the message of the label 
            AlertLabel.Text = message;

            // check the type of the alert 
            switch (alerttype)
            {
                // case Error 
                case MainFunctions_Class.alert.error:
                    // make the background of the alert red 
                    this.BackColor = Color.Red;
                    // make the picture box image to error_1 image 
                    AlertPictureBox.Image = Properties.Resources.Error_1;
                    break; // exit the switch 

                // case Success 
                case MainFunctions_Class.alert.success:
                    // make the background of the alert sea green 
                    this.BackColor = Color.SeaGreen;
                    // make the picture box image to rigth_1 image 
                    AlertPictureBox.Image = Properties.Resources.Right_1;
                    break; // exit the switch
            }

            // make the id to 1 (focus) 
            id = 1;
            // assign the text box 
            TextBox = textbox;
            // assign the flag to inidcate to do focus or not 
            focusflag = flag;
        }

        private void POPOutAlert_Load(object sender, EventArgs e)
        {
            // make the animation of the form according to the form tranisition 
            FormTransition.SetAnimateWindow(this);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            // in case there is focus 
            if(id == 1 && focusflag)
            {
                // make the focus and select on the text box 
                TextBox.Focus();
                TextBox.Select();
            }
            // close the current form 
            this.Close();
        }
    }
}
