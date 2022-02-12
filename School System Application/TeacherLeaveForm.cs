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
    public partial class TeacherLeaveForm : Form
    {
        // make object from the Main functions Class 
        MainFunctions_Class mc;
        public TeacherLeaveForm()
        {
            InitializeComponent();
            // initialzie the object from the main function class 
            mc = new MainFunctions_Class(); 
        }

        /// <summary>
        /// This function is to set the parent and the transperent of the text box 
        /// </summary>
        private void SetControls()
        {
            // set the parent of the controls as the picture box 
            BarCodeIDTextBox.Parent = RecordButton.Parent = ErrorLabel.Parent = BackGroundPictureBox;
            // make the back ground of the controls transperent 
            BarCodeIDTextBox.BackColor = RecordButton.BackColor = ErrorLabel.BackColor = Color.Transparent;
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
        /// This function to get the Teacher Days
        /// </summary>
        /// <param name="days"> array Will Contains The Days that the teacher Attends </param>
        /// <param name="code"> Teacher BarCode ID </param>
        private void GetTeahcerDays(ref string[] days, string code)
        {
            // make the sql connection 
            SqlConnection con = mc.GetConnection();

            SqlCommand cmd = new SqlCommand(@"select AttendDays, BarCodeID from TeacherTable 
                                            where BarCodeID = @code", con);
            // add the sql parameters 
            cmd.Parameters.AddWithValue("@code", code);
            // make the sql data reader 
            SqlDataReader dr = cmd.ExecuteReader();
            // read the first row 
            dr.Read();
            // make array of the split days 
            days = dr[0].ToString().Split(',');
            // close the data reader 
            dr.Close();
            // close the connection 
            con.Close();
        }

        /// <summary>
        /// This function to Check if the teacher reocrded the attendance before
        /// </summary>
        /// <param name="code"> The Teacher BarCode ID </param>
        /// <returns> return if the teacher has recorded the attendance or not </returns>
        private bool CheckAttendanceRecording(string code)
        {
            // this flag to indicate weather the date in the database or not 
            bool isfound = false;
            // make the sql connection 
            SqlConnection con = mc.GetConnection();
            // make the sql command  
            SqlCommand cmd = new SqlCommand("select DayNow, MonthNow, YearNow from T" + code + @"
                                             where DayNow = @d and MonthNow = @m and YearNow = @y", con);
            // add the sql command parameters 
            cmd.Parameters.AddWithValue("@d", DateTime.Now.Day);
            cmd.Parameters.AddWithValue("@m", DateTime.Now.Month);
            cmd.Parameters.AddWithValue("@y", DateTime.Now.Year);
            // make the sql data reader and execute the data reader 
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows) // in case the date exists in the data base 
                isfound = true; // turn the flag on 
            // close the data reader 
            dr.Close();
            // close the connection 
            con.Close();
            return isfound; // return with the flag
        }

        /// <summary>
        /// This function to check if the teacher has recorded the leave time or not 
        /// </summary>
        /// <param name="code"> Teacher BarCode ID </param>
        /// <returns> flag to indicate weather the teacher recorded his attendance or not </returns>
        private bool CheckRecord(string code)
        {
            // this flag to indicate the recording of the leave time 
            bool leave_recorded = false;
            // open the sql connection 
            SqlConnection con = mc.GetConnection();
            // make the sql command 
            SqlCommand cmd = new SqlCommand("select DayNow, MonthNow, YearNow, LeaveTime from T" + code + @"
                                             where DayNow = @d and MonthNow = @m and YearNow = @y", con);
            // add the sql parameters
            cmd.Parameters.AddWithValue("@d", DateTime.Now.Day);
            cmd.Parameters.AddWithValue("@m", DateTime.Now.Month);
            cmd.Parameters.AddWithValue("@y", DateTime.Now.Year);
            // execute the data reader 
            SqlDataReader dr = cmd.ExecuteReader();
            // read the first row (only returned row) 
            dr.Read();
            // check the leave time string
            if (dr[3].ToString() != "Not Recored") leave_recorded = true; // turn the flag on 
            // close the data reader 
            dr.Close();
            // close the connection 
            con.Close(); 
            return leave_recorded; // return with the flag 
        }

        /// <summary>
        /// This function to Record the Teacher Leave time
        /// </summary>
        /// <param name="code"> Teacher BarCode ID </param>
        private void UpdateLeaveTime(string code)
        {
            // open the sql connection 
            SqlConnection con = mc.GetConnection();
            // make the sql command 
            SqlCommand cmd = new SqlCommand("update T"+code +@" set LeaveTime = @leave
                                            Where DayNow = @d and MonthNow = @m and YearNow = @y", con);
            // add the sql paramters 
            cmd.Parameters.AddWithValue("@leave", DateTime.Now.ToString("h : m tt"));
            cmd.Parameters.AddWithValue("@d", DateTime.Now.Day);
            cmd.Parameters.AddWithValue("@m", DateTime.Now.Month);
            cmd.Parameters.AddWithValue("@y", DateTime.Now.Year);
            // execute the non query 
            cmd.ExecuteNonQuery(); 
            // close the sql connection 
            con.Close(); 
        }

        private void TeacherLeaveForm_Load(object sender, EventArgs e)
        {
            // make the form transition using the form animator 
            FormTransition.SetAnimateWindow(this);
            // call this function to set the controls 
            SetControls();
            // make the focus on the Barcode id text box 
            BarCodeIDTextBox.Focus();
            BarCodeIDTextBox.Select();

            
            // Check the time if it accepts to record the Leave 
            if (DateTime.Now < DateTime.Parse("08:00 AM") || DateTime.Now > DateTime.Parse("06:00 PM"))
            {
                // hide the main controls 
                RecordButton.Visible = BarCodeIDTextBox.Visible = false;
                // show the error label 
                ErrorLabel.Visible = true;
                // set the new location of the label 
                ErrorLabel.Location = new Point(288, 160);
                // make the focus on the form itself 
                this.Focus();
                this.Select();
                // exit the function 
                return;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            // close the from 
            this.Close();
        }

        private void MinimizationButton_Click(object sender, EventArgs e)
        {
            // make the form minimized under in the desktop 
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarCodeIDTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            // in case the pressed key is the enter key 
            if (e.KeyValue == (char)Keys.Enter)
                // call the Record click button event 
                RecordButton_Click(sender, e);
        }

        private void RecordButton_Click(object sender, EventArgs e)
        {
            // take the barcode id with the trim 
            string code = BarCodeIDTextBox.Text.Trim(' ');
            // make this flag to indicate if the current day form the teacher attend days list or not
            bool validday = false;

            // check if the data is empty 
            if (code == "")
            {
                // 130, "Please Enter Teacher BarCode ID", MainFunctions_Class.alert.error
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

            // get the current date 
            string currentday = DateTime.Now.ToString("dddd");
            // make array of the days the teacher has to attend from the database
            string[] days = null;
            // get teacher list of days by calling this function 
            GetTeahcerDays(ref days, code);
            // loop on the days of the array 
            foreach (string day in days)
            {
                // in case the current day is the same day from the teacher days 
                if (day == currentday)
                {
                    // make the flag to true 
                    validday = true;
                    // break the loop 
                    break;
                }
            }

            // in case the teacher can not attend in this day 
            if (!validday)
            {
                // call this function to handle the alerts 
                mc.ShowAlertForm(130, "This Teacher Has no Work Today", MainFunctions_Class.alert.error);
                // exit the function 
                return;
            }

            // check if the teacher recorded the attendance today already 
            if (!CheckAttendanceRecording(code))
            {
                // call this function to handle the alerts 
                mc.ShowAlertForm(160, "          Teacher Must First\n       Record his Attendance",
                    MainFunctions_Class.alert.error);
                // exit the function 
                return;
            }

            
            // check if the teacher has recorded leave time before 
            if(CheckRecord(code))
            {
                // call this function to handle the alerts 
                mc.ShowAlertForm(130, "   Teacher had Recorded Leave", MainFunctions_Class.alert.error);
                // exit the function 
                return;
            }

            // NOW THIS MEANS WE CAN RECORD THE LEAVE TIME FOR THE TEACHER // 

            // Call This function to update the leave time of the teahcer for todya
            UpdateLeaveTime(code); 
            // back to the orginal state 
            BarCodeIDTextBox.Text = string.Empty;
            // Handle the Success insert operation Alert (With Sea Green Color)
            mc.ShowAlertForm(130, "     Teacher  Leave  Recorded", MainFunctions_Class.alert.success
                , ref BarCodeIDTextBox, true);
        }
    }
}
