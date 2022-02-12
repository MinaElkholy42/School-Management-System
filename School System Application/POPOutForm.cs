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
    public partial class POPOutForm : Form
    {
        // this id to indicate weather to make focus or not 
        int id;
        // this text box we want to make the focus on 
        Guna2TextBox focusedtextbox;
        public POPOutForm()
        {
            InitializeComponent();
        }

        // paramatrized constructor 
        public POPOutForm(string value1, string value2, string value1header, string value2header)
        {
            InitializeComponent();
            // Assign the label 1 header 
            HeaderLabel1.Text = value1header;
            // Assign the label 2 header 
            HeaderLabel2.Text = value2header;
            // Assign the label 1 value 
            Label1.Text = value1;
            // Assign the label 2 value 
            Label2.Text = value2;

            // assign the id to 0 (no focus) 
            id = 0;
        }

        // paramatrized constructor 
        public POPOutForm(string value1, string value2, string value1header, string value2header
            , ref Guna2TextBox textbox)
        {
            InitializeComponent();
            // Assign the label 1 header 
            HeaderLabel1.Text = value1header;
            // Assign the label 2 header 
            HeaderLabel2.Text = value2header;
            // Assign the label 1 value 
            Label1.Text = value1;
            // Assign the label 2 value 
            Label2.Text = value2;

            // assign the id to 1 (there is focus) 
            id = 1;
            // assign the focused text box 
            focusedtextbox = textbox;
        }

        private void POPOutForm_Load(object sender, EventArgs e)
        {
            // set the animation of the form using the form animator 
            FormTransition.SetAnimateWindow(this);
            // set the distance of the value label1 according to the x position and the lenght of the text 
            Label1.Left = Label1.Location.X - Label1.Text.Length ;
            // set the distance of the value label2 according to the x position and the lenght of the text 
            Label2.Left = Label2.Location.X - Label2.Text.Length;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            // if there is focus 
            if(id == 1)
            {
                // make the focus and select on the text box we need 
                focusedtextbox.Focus();
                focusedtextbox.Select();
            }
            //  Close the Alert pop out form 
            this.Close();
        }
    }
}
