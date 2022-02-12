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
    public partial class TeacherDeleteForm : Form
    {
        // make object from the main function class
        MainFunctions_Class mc;
        public TeacherDeleteForm()
        {
            InitializeComponent();
            // initialize the main functions class object with new reference 
            mc = new MainFunctions_Class();
        }

        /// <summary>
        /// This function is to set the parent and the transperent of the text box 
        /// </summary>
        private void SetControls()
        {
            // set the parent of the controls as the picture box 
            BarCodeIDTextBox.Parent = DeleteButton.Parent = BackGroundPictureBox;
            // make the back ground of the controls transperent 
            BarCodeIDTextBox.BackColor = DeleteButton.BackColor = Color.Transparent;
        }

        /// <summary>
        /// This function to check if the Entered Bar Code ID Exists in the data base or not
        /// </summary>
        /// <param name="code"> Teacher BarCode ID we want to check the existence in the data base</param>
        /// <returns> the boolean flag indicates weather the code exists or not </returns>
        private bool CheckBarCodeID(string code)
        {
            // this flag is the return on the function to indicate the existence of Phone
            bool isfound = false;
            // make the connection 
            SqlConnection con = mc.GetConnection();
            // make the sql command 
            SqlCommand cmd = new SqlCommand(@"select BarCodeID from TeacherTable where BarCodeID = @code",
                con);
            // add the sql parameters 
            cmd.Parameters.AddWithValue("@code", code);
            // make the sql data reader 
            SqlDataReader dr = cmd.ExecuteReader();
            // in case there are rows in the sql data reader
            if (dr.HasRows) isfound = true; // turn the flag on (as the input exists in the data base)
            // close the data reader 
            dr.Close();
            // close the connection 
            con.Close();
            return isfound; // return with the flag
        }

        /// <summary>
        /// This function to delete the teacher from the teacher information table
        /// </summary>
        /// <param name="code"> Teacher BarCode ID Used For the Deletion Operation </param>
        private void DeleteTeacherInformation(string code)
        {
            // make the connection 
            SqlConnection con = mc.GetConnection();
            // make the sql command 
            SqlCommand cmd = new SqlCommand("delete from TeacherTable where BarCodeID = @code", con);
            // add the sql command parameters 
            cmd.Parameters.AddWithValue("@code", code);
            // execute the cmd non query operation 
            cmd.ExecuteNonQuery();
            // close the connection 
            con.Close();
        }

        /// <summary>
        /// This function to delete the teacher Attend Infromation Table (For Each Teacher)
        /// </summary>
        /// <param name="code"> Teacher BarCode ID Used For the Deletion Operation </param>
        private void DeleteTeacherAttendTable(string code)
        {
            // make the connection 
            SqlConnection con = mc.GetConnection();
            // make the sql command 
            SqlCommand cmd = new SqlCommand("Drop Table T"+code, con);
            // execute the cmd non query operation 
            cmd.ExecuteNonQuery();
            // close the connection 
            con.Close();
        }

        private void TeacherDeleteForm_Load(object sender, EventArgs e)
        {
            // set the animation of this form using the form transition 
            FormTransition.SetAnimateWindow(this);
            // call this function to set the controls 
            SetControls();
            // make the focus on the code text box 
            BarCodeIDTextBox.Focus();
            BarCodeIDTextBox.Select();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            // close this form
            this.Close();
        }

        private void MinimizationButton_Click(object sender, EventArgs e)
        {
            // set the window state to the minimization state 
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarCodeIDTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            // in case the pressed key is the enter key 
            if (e.KeyValue == (char)Keys.Enter)
                // call the delete click button event 
                DeleteButton_Click(sender, e);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            // take the barcode id with the trim 
            string code = BarCodeIDTextBox.Text.Trim(' ');

            // check if the data is empty 
            if (code == "")
            {
                // call this function to handle the alerts 
                mc.ShowAlertForm(130, "Please Enter Teacher BarCode ID", MainFunctions_Class.alert.error);
                // exit the function 
                return;
            }

            else if (!CheckBarCodeID(code))
            {
                // call this function to handle the alerts 
                mc.ShowAlertForm(130, "  Worng BarCode ID, Try Again", MainFunctions_Class.alert.error);
                // exit the function 
                return;
            }

            // This means the barcode id is right so now let's delete from the data base 

            // call this function to delete the teacher from the infromation table
            DeleteTeacherInformation(code);
            // call this function to delete the teacher from the 
            DeleteTeacherAttendTable(code);

            // make the text box string to empyt 
            BarCodeIDTextBox.Text = string.Empty;
            // call this fucntion to handle the success alert 
            mc.ShowAlertForm(160, "           Teacher has been\n         Deleted Successfully",
                MainFunctions_Class.alert.success, ref BarCodeIDTextBox, true);
        }
    }
}
