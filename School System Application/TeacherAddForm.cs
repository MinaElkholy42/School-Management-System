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
using System.Text.RegularExpressions;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
namespace School_System_Application
{
    public partial class TeacherAddForm : Form
    {
        // make list of all Days, HoursCome, MinutesCome, ZonesCome, HoursLeave, MinutesLeave and ZonesLeave 
        //  combobox controls 
        List<Guna2ComboBox> listdays, listhourscome, listminutescome, listzonescome, listhoursleave, listminutesleave
            , listzonesleave;
        // this is object from the Main Functions Class of the application 
        MainFunctions_Class mc;
        // this variable will hold the number of the appeard rows in the attend and leave of each teacher 
        int teacherrows;
        // this flag to indicate weather to make focus on the text box or not
        bool focusflag;
        public TeacherAddForm()
        {
            InitializeComponent();
            // intialize the controls lists 
            listdays = new List<Guna2ComboBox>();
            listhourscome = new List<Guna2ComboBox>();
            listminutescome = new List<Guna2ComboBox>();
            listzonescome = new List<Guna2ComboBox>();
            listhoursleave = new List<Guna2ComboBox>();
            listminutesleave = new List<Guna2ComboBox>();
            listzonesleave = new List<Guna2ComboBox>();

            // initialize the obejct of the Main Functions Class 
            mc = new MainFunctions_Class();
            // initialize the variable of appeard rows of teachers with 1 (defaule) 
            teacherrows = 1;
            // initialize the flag with true (there is focus)
            focusflag = true;
        }

        /// <summary>
        /// This function to make the strings from the lists valid of days, attend time and leave time 
        /// </summary>
        /// <param name="attenddaysstring"> The string of Attend Days of Teacher </param>
        /// <param name="attendtimestring"> The string of Attend Time of Teacher </param>
        /// <param name="leavetimestring">  The string of Leave Time of Teacher </param>
        /// <param name="days"> List of All Days The Teacher will Attend </param>
        /// <param name="attendtime"> List of the Attend Time of the Teacher </param>
        /// <param name="leavetime"> List of the Leave Time of the Teacher </param>
        private void MakeStringsFromLists(ref string attenddaysstring, ref string attendtimestring, ref
            string leavetimestring, string[] days, string[] attendtime, string[] leavetime)
        {
            // loop on the days the teacher will attend (teacher rows represent it) 
            for(int i =0; i<teacherrows; ++i)
            {
                // add the day from the list to the string 
                attenddaysstring += days[i];
                // add the attend time from the list to the string 
                attendtimestring += attendtime[i];
                // add the leave time from the list to the string 
                leavetimestring += leavetime[i];
                // in case this is not the last day 
                if(i != teacherrows-1)
                {
                    // add  character comma (,) to all the strings of days, leave and attend times
                    attenddaysstring += ",";
                    leavetimestring += ",";
                    attendtimestring += ",";
                }
            }
        }

        /// <summary>
        /// This function To insert the data in the TeacherTable
        /// </summary>
        /// <param name="name"> Teacher Name </param>
        /// <param name="salary"> Theacher Main Salary </param>
        /// <param name="phone"> Teacher Mobile Phone Number </param>
        /// <param name="age"> Teahcer Age </param>
        /// <param name="id"> Tecaher 14 ID Number </param>
        /// <param name="address"> Teacher Address </param>
        /// <param name="code"> Teacher BarCode ID Number </param>
        /// <param name="subject"> The Subject Teacher Teach </param>
        /// <param name="college"> The Colleage The Teacher Learn From </param>
        /// <param name="daysstring"> The string of Attend Days of the Teacher </param>
        /// <param name="attendtimestring"> The string of Attend Time of The Teacher </param>
        /// <param name="leavetimestring"> The string of Leave Time of the Teahcer </param>
        private void InsertTeacherData(string name, int salary, string phone, int age, string id, 
            string address, string code, string subject ,string college, string daysstring, 
            string attendtimestring , string leavetimestring)
        {
            // make the connection 
            SqlConnection con = mc.GetConnection();
            // make the sql command 
            SqlCommand cmd = new SqlCommand(@"insert into TeacherTable values(@name, @salary, @phone
                                                , @age, @id, @address, @code, @subject, @college, 
                                               @days, @attend, @leave)", con);
            // add the sql parameters 
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@salary", salary);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@age", age);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@code", code);
            cmd.Parameters.AddWithValue("@subject", subject);
            cmd.Parameters.AddWithValue("@college", college);
            cmd.Parameters.AddWithValue("@days", daysstring);
            cmd.Parameters.AddWithValue("@attend", attendtimestring);
            cmd.Parameters.AddWithValue("@leave", leavetimestring);
            // execute the sql command non query 
            cmd.ExecuteNonQuery();
            // close the connection 
            con.Close(); 
        }

        /// <summary>
        /// This function to create table for teacher to track his attendence to the school
        /// </summary>
        /// <param name="code"></param>
        private void CreateTeacherTable(string code)
        {
            // make the connection 
            SqlConnection con = mc.GetConnection();
            // make the sql command 
            SqlCommand cmd = new SqlCommand(@"Create Table T"+ code + @" (DayNow int Not Null,
               MonthNow int Not Null,
               YearNow int Not Null,
               AttendTime varchar(20) Not Null, 
               LeaveTime varchar(20) Not Null,
               Primary key(DayNow, MonthNow, YearNow))", con);
            // execute the sql command non query 
            cmd.ExecuteNonQuery();
            // Close the conneciton 
            con.Close();
        }


        /// <summary>
        /// This function to check if the phone, ID and Code in the database before or not
        /// </summary>
        /// <param name="input"> The Entered Phone or ID or Code we want to check Existence</param>
        /// <returns> retrun flag indicates weather the phone or ID or Code in the database before or not </returns>
        private bool CheckExistence(string input)
        {
            // this flag is the return on the function to indicate the existence of Phone
            bool isfound = false;
            // make the connection 
            SqlConnection con = mc.GetConnection();
            // make the sql command 
            SqlCommand cmd = new SqlCommand(@"select Phone from TeacherTable where Phone = @phone  or ID = @id
                                                 or BarCodeID = @code", con);
            // add the sql parameters 
            cmd.Parameters.AddWithValue("@phone", input);
            cmd.Parameters.AddWithValue("@id", input);
            cmd.Parameters.AddWithValue("@code", input);
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
        /// This function to indicate when the enter key pressed
        /// </summary>
        private void KeyDownFunction(object sender, KeyEventArgs e)
        {
            // in case the down key is the enter key 
            if (e.KeyValue == (char)Keys.Enter) // call the click event of the button 
                InsertButton_Click(sender, e);
        }

        private void BarCodeIDTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            // if the entered  key is the enter key 
            if (e.KeyValue == (char)Keys.Enter)
            {
                // make the select and focus on the next text box
                SubjectTextBox.Focus();
                SubjectTextBox.Select();
            }
        }

        /// <summary>
        /// This function to fill the lists of controls of days, minutes, hours and zones
        /// </summary>
        private void FillControlLists()
        {
            // fill the days list 
            listdays.Add(DayComboBox1);
            listdays.Add(DayComboBox2);
            listdays.Add(DayComboBox3);
            listdays.Add(DayComboBox4);
            listdays.Add(DayComboBox5);
            listdays.Add(DayComboBox6);

            // fill the hours come list 
            listhourscome.Add(HoursComeComboBox1);
            listhourscome.Add(HoursComeComboBox2);
            listhourscome.Add(HoursComeComboBox3);
            listhourscome.Add(HoursComeComboBox4);
            listhourscome.Add(HoursComeComboBox5);
            listhourscome.Add(HoursComeComboBox6);

            // fill the minutes come list 
            listminutescome.Add(MinutesComeComboBox1);
            listminutescome.Add(MinutesComeComboBox2);
            listminutescome.Add(MinutesComeComboBox3);
            listminutescome.Add(MinutesComeComboBox4);
            listminutescome.Add(MinutesComeComboBox5);
            listminutescome.Add(MinutesComeComboBox6);

            // fill the zone come list 
            listzonescome.Add(ZoneComeComboBox1);
            listzonescome.Add(ZoneComeComboBox2);
            listzonescome.Add(ZoneComeComboBox3);
            listzonescome.Add(ZoneComeComboBox4);
            listzonescome.Add(ZoneComeComboBox5);
            listzonescome.Add(ZoneComeComboBox6);

            // fill the hours leave list 
            listhoursleave.Add(HoursLeaveComboBox1);
            listhoursleave.Add(HoursLeaveComboBox2);
            listhoursleave.Add(HoursLeaveComboBox3);
            listhoursleave.Add(HoursLeaveComboBox4);
            listhoursleave.Add(HoursLeaveComboBox5);
            listhoursleave.Add(HoursLeaveComboBox6);

            // fill the minutes leave list 
            listminutesleave.Add(MinutesLeaveComboBox1);
            listminutesleave.Add(MinutesLeaveComboBox2);
            listminutesleave.Add(MinutesLeaveComboBox3);
            listminutesleave.Add(MinutesLeaveComboBox4);
            listminutesleave.Add(MinutesLeaveComboBox5);
            listminutesleave.Add(MinutesLeaveComboBox6);

            // fill the zones leave list 
            listzonesleave.Add(ZoneLeaveComboBox1);
            listzonesleave.Add(ZoneLeaveComboBox2);
            listzonesleave.Add(ZoneLeaveComboBox3);
            listzonesleave.Add(ZoneLeaveComboBox4);
            listzonesleave.Add(ZoneLeaveComboBox5);
            listzonesleave.Add(ZoneLeaveComboBox6);
        }

        

        /// <summary>
        /// This function to fill the items of the second combobox according to the first combobox items
        /// </summary>
        /// <param name="combobox1"> First ComboBox </param>
        /// <param name="combobox2"> Second ComboBox </param>
        /// <param name="n"> Number Of Rows to indicate weather the combobox row is shown or not </param>
        private void ChangeComboBoxItems(ref Guna2ComboBox combobox1, ref Guna2ComboBox combobox2, int n)
        {
            // get the original item in the combo box
            var originalitem = combobox2.SelectedItem;
            // clear the items in the days combo box 2 
            combobox2.Items.Clear();
            // loop on each item in the combo box of days 1 
            foreach (var item in combobox1.Items)
            {
                // if the item is not the selected item add it in the days combo box 2 
                if (item.ToString() != combobox1.SelectedItem.ToString()) combobox2.Items.Add(item);
            }
            // if the teachers row is n or more 
            if (teacherrows >= n)
            {
                // take the index of the original item 
                int originalindex = combobox2.Items.IndexOf(originalitem);
                // in case found (not -1) 
                if (originalindex != -1) combobox2.StartIndex = originalindex;
                // else (not found) 
                else combobox2.StartIndex = 0;
            }
            else combobox2.StartIndex = -1; // else then it is hidden 
        }

        /// <summary>
        /// This function to return each thing to its original in the form
        /// </summary>
        /// <param name="sender"> the object which send the action </param>
        /// <param name="e"> Event Action Argument </param>
        private void BackToOriginal(object sender, EventArgs e)
        {
            // make the textboxes with empty string 
            NameTextBox.Text = IDTextBox.Text = BarCodeIDTextBox.Text = AgeTextBox.Text =
                SalaryTextBox.Text = SubjectTextBox.Text = QualificationTextBox.Text = PhoneTextBox.Text
                = AddressTextBox.Text = string.Empty;
            // loop on the number of appeard rows until it reaches 1
            while (teacherrows != 1)
                // call the decrease button function
                DecreaseButton_Click(sender, e);
            // make the first row all in the start index of zero 
            DayComboBox1.StartIndex = HoursComeComboBox1.StartIndex = MinutesComeComboBox1.StartIndex =
                ZoneComeComboBox1.StartIndex = HoursLeaveComboBox1.StartIndex =
                MinutesLeaveComboBox1.StartIndex = ZoneLeaveComboBox1.StartIndex = 0;


            /////////////////////// LIMIT NUMBER IS 50 ////////////////////

            // call this function to check the availablity to add more teahcers 
            mc.GetTeacherAddValue(50);
            // check the limit number of teachers 
            if (MainFunctions_Class.GetTeacherFlag())
            {
                // call this function to hide the main controls
                ShowHideMainControls(false);
                // call this function to handle the error label
                mc.ShowErrorLabel(ref ErrorLabel, 226, 300,
                    @"&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Can not Add More Teachers<br>
                      Please Contact Us For More Information", 100, 500);
                // make this flag to true (as no focus on the text box) 
                focusflag = false; // no focus
            }
            else
            {
                // call this function to hide the main controls
                ShowHideMainControls(true);
                // make the label invisible 
                ErrorLabel.Visible = false;
                focusflag = true; // there is focus
            }
        }

        /// <summary>
        /// This function to hide the controls in the form and show the label of no more teachers to add
        /// </summary>
        private void ShowHideMainControls(bool value)
        {
            // Hide the text boxes 
            NameTextBox.Visible = IDTextBox.Visible = BarCodeIDTextBox.Visible = AgeTextBox.Visible =
                SalaryTextBox.Visible = SubjectTextBox.Visible =
                QualificationTextBox.Visible = PhoneTextBox.Visible = AddressTextBox.Visible = value;

            // loop on each list of the combo boxes to hide them 
            for (int i = 0; i < teacherrows; ++i) // make each current combo box of come and leave and day invisible
                listdays[i].Visible = listminutescome[i].Visible = listhourscome[i].Visible =
                    listzonescome[i].Visible = listminutesleave[i].Visible = listhoursleave[i].Visible =
                    listzonesleave[i].Visible = value;
            // hide the three main buttion 
            InsertButton.Visible = AddButton.Visible = DecreaseButton.Visible = value;
            // Hide labels 
            AttendLabel1.Visible = LeaveLabel1.Visible = value;
            if (!value)
            {
                // make the focus and select on the form 
                this.Focus();
                this.Select();
            }
        }

        /// <summary>
        /// This function to set the main beginning of the controls
        /// </summary>
        private void SetControls()
        {

            // make the start index of the combo box one 
            DayComboBox1.StartIndex = 0;

            // make the text boxes and buttons parent is the picture box 
            NameTextBox.Parent = AgeTextBox.Parent = AddressTextBox.Parent
                = PhoneTextBox.Parent = BarCodeIDTextBox.Parent
                = SalaryTextBox.Parent = QualificationTextBox.Parent =
                SubjectTextBox.Parent = IDTextBox.Parent = InsertButton.Parent =

                DayComboBox1.Parent = AttendLabel1.Parent = HoursComeComboBox1.Parent = MinutesComeComboBox1.Parent
                = ZoneComeComboBox1.Parent = LeaveLabel1.Parent = HoursLeaveComboBox1.Parent =
                MinutesLeaveComboBox1.Parent = ZoneLeaveComboBox1.Parent = AddButton.Parent = DecreaseButton.Parent =

                 DayComboBox2.Parent = HoursComeComboBox2.Parent = MinutesComeComboBox2.Parent
                = ZoneComeComboBox2.Parent = HoursLeaveComboBox2.Parent =
                MinutesLeaveComboBox2.Parent = ZoneLeaveComboBox2.Parent =

                DayComboBox3.Parent = HoursComeComboBox3.Parent = MinutesComeComboBox3.Parent
                = ZoneComeComboBox3.Parent = HoursLeaveComboBox3.Parent =
                MinutesLeaveComboBox3.Parent = ZoneLeaveComboBox3.Parent =

                DayComboBox4.Parent = HoursComeComboBox4.Parent = MinutesComeComboBox4.Parent
                = ZoneComeComboBox4.Parent = HoursLeaveComboBox4.Parent =
                MinutesLeaveComboBox4.Parent = ZoneLeaveComboBox4.Parent =

                 DayComboBox5.Parent = HoursComeComboBox5.Parent = MinutesComeComboBox5.Parent
                = ZoneComeComboBox5.Parent = HoursLeaveComboBox5.Parent =
                MinutesLeaveComboBox5.Parent = ZoneLeaveComboBox5.Parent =

                DayComboBox6.Parent = HoursComeComboBox6.Parent = MinutesComeComboBox6.Parent
                = ZoneComeComboBox6.Parent = HoursLeaveComboBox6.Parent =
                MinutesLeaveComboBox6.Parent = ZoneLeaveComboBox6.Parent

                 = BackGroundPictureBox;

            // make the back color of all text boxes transparent and buttons
            NameTextBox.BackColor = AgeTextBox.BackColor = AddressTextBox.BackColor
                = PhoneTextBox.BackColor = BarCodeIDTextBox.BackColor
                 = SalaryTextBox.BackColor = QualificationTextBox.BackColor
                  = SubjectTextBox.BackColor = IDTextBox.BackColor = InsertButton.BackColor =

                  DayComboBox1.BackColor = AttendLabel1.BackColor = HoursComeComboBox1.BackColor =
                  MinutesComeComboBox1.BackColor = ZoneComeComboBox1.BackColor = LeaveLabel1.BackColor =
                  HoursLeaveComboBox1.BackColor = MinutesLeaveComboBox1.BackColor = AddButton.BackColor
                 = DecreaseButton.BackColor = ZoneLeaveComboBox1.BackColor =

                  DayComboBox2.BackColor = HoursComeComboBox2.BackColor = MinutesComeComboBox2.BackColor =
                  ZoneComeComboBox2.BackColor = HoursLeaveComboBox2.BackColor = MinutesLeaveComboBox2.BackColor =
                   ZoneLeaveComboBox2.BackColor =

                   DayComboBox3.BackColor = HoursComeComboBox3.BackColor = MinutesComeComboBox3.BackColor =
                  ZoneComeComboBox3.BackColor = HoursLeaveComboBox3.BackColor = MinutesLeaveComboBox3.BackColor =
                   ZoneLeaveComboBox3.BackColor =

                   DayComboBox4.BackColor = HoursComeComboBox4.BackColor = MinutesComeComboBox4.BackColor =
                  ZoneComeComboBox4.BackColor = HoursLeaveComboBox4.BackColor = MinutesLeaveComboBox4.BackColor =
                   ZoneLeaveComboBox4.BackColor =

                   DayComboBox5.BackColor = HoursComeComboBox5.BackColor = MinutesComeComboBox5.BackColor =
                  ZoneComeComboBox5.BackColor = HoursLeaveComboBox5.BackColor = MinutesLeaveComboBox5.BackColor =
                   ZoneLeaveComboBox5.BackColor =

                   DayComboBox6.BackColor = HoursComeComboBox6.BackColor = MinutesComeComboBox6.BackColor =
                  ZoneComeComboBox6.BackColor = HoursLeaveComboBox6.BackColor = MinutesLeaveComboBox6.BackColor =
                   ZoneLeaveComboBox6.BackColor =

                   Color.Transparent;

            // make the error label parent is the picture box 
            ErrorLabel.Parent = BackGroundPictureBox;
            // make the background of the label transparent 
            ErrorLabel.BackColor = Color.Transparent;

        }

        private void TeacherAddForm_Load(object sender, EventArgs e)
        {
            // make the tranistion of this form using form tranistion 
            FormTransition.SetAnimateWindow(this);
            // call this function to fill the lists of the controls 
            FillControlLists();
            // call this function to set the controls
            SetControls();

            /////////////////////// LIMIT NUMBER IS 50 ////////////////////

            // call this function to check the availablity to add more teahcers 
            mc.GetTeacherAddValue(50);
            // check the limit number of teachers 
            if (MainFunctions_Class.GetTeacherFlag())
            {
                // call this function to hide the main controls
                ShowHideMainControls(false);
                // call this function to handle the error label
                mc.ShowErrorLabel(ref ErrorLabel, 226, 300,
                    @"&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Can not Add More Teachers<br>
                      Please Contact Us For More Information", 100, 500);
                // exit the function 
                return;
            }

            // set the maximum length of the text box to 25 characters 
            NameTextBox.Focus();
            NameTextBox.Select();
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

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            // to set the main of the controls
            SetControls();
            // call this function to back to the original state 
            BackToOriginal(sender, e);

            // if there is focus (can add more)
            if (focusflag)
            {
                // make focus on the name text box 
                NameTextBox.Focus();
                NameTextBox.Select();
            }

            // make those variables to get the x and y coordinates 
            int x = 0, y = 0;
            // call this function to get the x and y coordinates of the add teachers form 
            mc.SetBranchLoadingFormPosition("TeacherAddForm", ref x, ref y);
            // call this function to get the branch loading form 
            mc.OpenBranchLoadingForm1(x, y);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // check the number of appears rows 

            // in case there is only one row
            if(teacherrows == 1)
            {
                // make the comboboxes in the first original state 
                DayComboBox2.StartIndex = HoursComeComboBox2.StartIndex = MinutesComeComboBox2.StartIndex =
                    ZoneComeComboBox2.StartIndex = HoursLeaveComboBox2.StartIndex = MinutesLeaveComboBox2.StartIndex =
                    ZoneLeaveComboBox2.StartIndex = 0;
                // show the Second row
                DayComboBox2.Visible = HoursComeComboBox2.Visible = MinutesComeComboBox2.Visible =
                    ZoneComeComboBox2.Visible = HoursLeaveComboBox2.Visible = MinutesLeaveComboBox2.Visible =
                    ZoneLeaveComboBox2.Visible = true;
                // show the decreament button 
                DecreaseButton.Visible = true;
            }
            
            // in case there are two rows
            else if (teacherrows == 2)
            {
                // make the comboboxes in the first original state 
                DayComboBox3.StartIndex = HoursComeComboBox3.StartIndex = MinutesComeComboBox3.StartIndex =
                    ZoneComeComboBox3.StartIndex = HoursLeaveComboBox3.StartIndex = MinutesLeaveComboBox3.StartIndex =
                    ZoneLeaveComboBox3.StartIndex = 0;
                // show the Third row
                DayComboBox3.Visible = HoursComeComboBox3.Visible = MinutesComeComboBox3.Visible =
                    ZoneComeComboBox3.Visible = HoursLeaveComboBox3.Visible = MinutesLeaveComboBox3.Visible =
                    ZoneLeaveComboBox3.Visible = true;   
            }

            // in case there are three rows
            else if (teacherrows == 3)
            {
                // make the comboboxes in the first original state 
                DayComboBox4.StartIndex = HoursComeComboBox4.StartIndex = MinutesComeComboBox4.StartIndex =
                    ZoneComeComboBox4.StartIndex = HoursLeaveComboBox4.StartIndex = MinutesLeaveComboBox4.StartIndex =
                    ZoneLeaveComboBox4.StartIndex = 0;
                // show the Fourth row
                DayComboBox4.Visible = HoursComeComboBox4.Visible = MinutesComeComboBox4.Visible =
                    ZoneComeComboBox4.Visible = HoursLeaveComboBox4.Visible = MinutesLeaveComboBox4.Visible =
                    ZoneLeaveComboBox4.Visible = true;
            }

            // in case there are four rows
            else if (teacherrows == 4)
            {
                // make the comboboxes in the first original state 
                DayComboBox5.StartIndex = HoursComeComboBox5.StartIndex = MinutesComeComboBox5.StartIndex =
                    ZoneComeComboBox5.StartIndex = HoursLeaveComboBox5.StartIndex = MinutesLeaveComboBox5.StartIndex =
                    ZoneLeaveComboBox5.StartIndex = 0;
                // show the Fifth row
                DayComboBox5.Visible = HoursComeComboBox5.Visible = MinutesComeComboBox5.Visible =
                    ZoneComeComboBox5.Visible = HoursLeaveComboBox5.Visible = MinutesLeaveComboBox5.Visible =
                    ZoneLeaveComboBox5.Visible = true;
            }

            // in case there are four rows
            else if (teacherrows == 5)
            {
                // make the comboboxes in the first original state 
                DayComboBox6.StartIndex = HoursComeComboBox6.StartIndex = MinutesComeComboBox6.StartIndex =
                    ZoneComeComboBox6.StartIndex = HoursLeaveComboBox6.StartIndex = MinutesLeaveComboBox6.StartIndex =
                    ZoneLeaveComboBox6.StartIndex = 0;
                // show the sixth row
                DayComboBox6.Visible = HoursComeComboBox6.Visible = MinutesComeComboBox6.Visible =
                    ZoneComeComboBox6.Visible = HoursLeaveComboBox6.Visible = MinutesLeaveComboBox6.Visible =
                    ZoneLeaveComboBox6.Visible = true;
                // hide the add rows button 
                AddButton.Visible = false;
            }

            teacherrows++; // increament the number of appeard rows
        }

        private void DecreaseButton_Click(object sender, EventArgs e)
        {
            // check the number of appears rows 

            // in case there are six rows
            if (teacherrows == 6)
            {
                // make the comboboxes in the first original state 
                DayComboBox6.StartIndex = HoursComeComboBox6.StartIndex = MinutesComeComboBox6.StartIndex =
                    ZoneComeComboBox6.StartIndex = HoursLeaveComboBox6.StartIndex = MinutesLeaveComboBox6.StartIndex =
                    ZoneLeaveComboBox6.StartIndex = -1;

                // Hide the Sixth row
                DayComboBox6.Visible = HoursComeComboBox6.Visible = MinutesComeComboBox6.Visible =
                    ZoneComeComboBox6.Visible = HoursLeaveComboBox6.Visible = MinutesLeaveComboBox6.Visible =
                    ZoneLeaveComboBox6.Visible = false;
                // show the Add button 
                AddButton.Visible = true;
            }

            // in case there are five rows
            else if (teacherrows == 5)
            {
                // make the comboboxes in the first original state 
                DayComboBox5.StartIndex = HoursComeComboBox5.StartIndex = MinutesComeComboBox5.StartIndex =
                    ZoneComeComboBox5.StartIndex = HoursLeaveComboBox5.StartIndex = MinutesLeaveComboBox5.StartIndex =
                    ZoneLeaveComboBox5.StartIndex = -1;
                // Hide the Fifth Row
                DayComboBox5.Visible = HoursComeComboBox5.Visible = MinutesComeComboBox5.Visible =
                    ZoneComeComboBox5.Visible = HoursLeaveComboBox5.Visible = MinutesLeaveComboBox5.Visible =
                    ZoneLeaveComboBox5.Visible = false;
            }

            // in case there are four rows
            else if (teacherrows == 4)
            {
                // make the comboboxes in the first original state 
                DayComboBox5.StartIndex = HoursComeComboBox5.StartIndex = MinutesComeComboBox5.StartIndex =
                    ZoneComeComboBox5.StartIndex = HoursLeaveComboBox5.StartIndex = MinutesLeaveComboBox5.StartIndex =
                    ZoneLeaveComboBox5.StartIndex = -1;
                // Hide the Fourth row
                DayComboBox4.Visible = HoursComeComboBox4.Visible = MinutesComeComboBox4.Visible =
                    ZoneComeComboBox4.Visible = HoursLeaveComboBox4.Visible = MinutesLeaveComboBox4.Visible =
                    ZoneLeaveComboBox4.Visible = false;
            }

            // in case there are three rows
            else if (teacherrows == 3)
            {
                // make the comboboxes in the first original state 
                DayComboBox3.StartIndex = HoursComeComboBox3.StartIndex = MinutesComeComboBox3.StartIndex =
                    ZoneComeComboBox3.StartIndex = HoursLeaveComboBox3.StartIndex = MinutesLeaveComboBox3.StartIndex =
                    ZoneLeaveComboBox3.StartIndex = -1;
                // show the Third row
                DayComboBox3.Visible = HoursComeComboBox3.Visible = MinutesComeComboBox3.Visible =
                    ZoneComeComboBox3.Visible = HoursLeaveComboBox3.Visible = MinutesLeaveComboBox3.Visible =
                    ZoneLeaveComboBox3.Visible = false;
            }

            // in case there are tow rows
            else if (teacherrows == 2)
            {
                // make the comboboxes in the first original state 
                DayComboBox2.StartIndex = HoursComeComboBox2.StartIndex = MinutesComeComboBox2.StartIndex =
                    ZoneComeComboBox2.StartIndex = HoursLeaveComboBox2.StartIndex = MinutesLeaveComboBox2.StartIndex =
                    ZoneLeaveComboBox2.StartIndex = -1;
                // Hide the Second row
                DayComboBox2.Visible = HoursComeComboBox2.Visible = MinutesComeComboBox2.Visible =
                    ZoneComeComboBox2.Visible = HoursLeaveComboBox2.Visible = MinutesLeaveComboBox2.Visible =
                    ZoneLeaveComboBox2.Visible = false;
                // Hide the Decrement Button of Rows 
                DecreaseButton.Visible = false;
            }

            teacherrows--; // Decreament the number of appeard rows
        }

        private void DayComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // call this function to handle the items in the combo box 2 
            ChangeComboBoxItems(ref DayComboBox1, ref DayComboBox2, 2);
        }

        private void DayComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // call this function to handle the items in the combo box 3 
            ChangeComboBoxItems(ref DayComboBox2, ref DayComboBox3, 3);
        }

        private void DayComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            // call this function to handle the items in the combo box 4 
            ChangeComboBoxItems(ref DayComboBox3, ref DayComboBox4, 4);
        }

        private void DayComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            // call this function to handle the items in the combo box 5 
            ChangeComboBoxItems(ref DayComboBox4, ref DayComboBox5, 5);
        }

        private void DayComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            // call this function to handle the items in the combo box 6 
            ChangeComboBoxItems(ref DayComboBox5, ref DayComboBox6, 6);
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            // Take the entered Main data  
            string name = NameTextBox.Text.Trim(' ');
            string salarystring = SalaryTextBox.Text.Trim(' ');
            string phone = PhoneTextBox.Text.Trim(' ');
            string agestring = AgeTextBox.Text.Trim(' ');
            string id = IDTextBox.Text.Trim(' ');
            string code = BarCodeIDTextBox.Text.Trim(' ');
            string address = AddressTextBox.Text.Trim(' ');
            string subject = SubjectTextBox.Text.Trim(' ');
            string college = QualificationTextBox.Text.Trim(' ');

            // This flag to indicates the validation of the time in the shown rows for the teachers 
            bool validtime = true;
            // This string will hold the time error output 
            string errortimemessage = "";
            // make a list of the days of teacher , time to attend and the time to leave according to the shown
            string[] days = new string[6] { string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty };
            string[] attendtime = new string[6] { string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty };
            string[] leavetime = new string[6] { string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty };

            // take the input of the days, attend time and the leave time 

            // loop on the number of the rows shown 
            for (int i = 0; i < teacherrows; ++i)
            {
                // take the day from the combo box 
                days[i] = listdays[i].SelectedItem.ToString();

                // take the attend time as a compination of hours, minutes and zone 
                attendtime[i] = listhourscome[i].SelectedItem.ToString() + " : " + listminutescome[i].SelectedItem.ToString()
                    + " " + listzonescome[i].SelectedItem.ToString();

                // take the leave time as a compination of hours, minutes and zone 
                leavetime[i] = listhoursleave[i].SelectedItem.ToString() + " : " + listminutesleave[i].SelectedItem.ToString() +
                    " " + listzonesleave[i].SelectedItem.ToString();
            }

            /////////////////////// HANDLE ERROS OF INPUT SECTION ///////////////////////////////////////////// 
            /////////////////////// HANDLE ERROS OF INPUT SECTION /////////////////////////////////////////////

            // Check empty input 
            if (name == "" || salarystring == "" || phone == "" || agestring == "" || id == "" || code == ""
                 || address == "" || college == "" || subject == "")
            {
                // call this function to handle the error alert 
                mc.ShowAlertForm(130, "   Please Fill All Previous Data", MainFunctions_Class.alert.error);
                // exit the function 
                return;
            }

            // check the validation of the name 
            else if (!mc.NameFormat.IsMatch(name))
            {
                // call this function to handle the error alert 
                mc.ShowAlertForm(200, "     Name Must Contain Only\n        Alphabet Letters,And\n" +
                    "   At Least 3 Characters Length", MainFunctions_Class.alert.error);
                // exit the function 
                return;
            }


            // check that the salary only contains digits without spaces 
            else if (!Regex.IsMatch(salarystring, "^[0-9]+$"))
            {
                // call this function to handle the error alert 
                mc.ShowAlertForm(160, " Salary Must Contain Digits Only\n             WithOut Spaces",
                    MainFunctions_Class.alert.error);
                // exit the function 
                return;
            }

            // take the salary as integer 
            int salary = Convert.ToInt32(salarystring);

            // check the amount of the salary 
            if (salary < 300)
            {
                // call this function to handle the error alert 
                mc.ShowAlertForm(130, "Salary Must Be Not Less Than 300",
                    MainFunctions_Class.alert.error);
                // exit the function 
                return;
            }

            // check the format of the Entered Phone Number 
            else if (!mc.PhonNumberFormat.IsMatch(phone))
            {
                // call this function to handle the error alert
                mc.ShowAlertForm(160, "   Phone Number Must Contain\n Only 11 Digits WithOut Spaces"
                    , MainFunctions_Class.alert.error);
                // exit the function 
                return;
            }

            // check the existence of the Phon Number in the data base 
            else if (CheckExistence(phone))
            {
                // call this function to handle the error alert 
                mc.ShowAlertForm(160, "The Phone Number is Used Before\n     Please Enter Another One",
                    MainFunctions_Class.alert.error);
                // exit the function 
                return;
            }

            // check the format of the age 
            else if (!Regex.IsMatch(agestring, "^[0-9]+$"))
            {
                // call this function to handle the error alert 
                mc.ShowAlertForm(160, "  Age Must Contain Digits Only\n             WithOut Spaces",
                    MainFunctions_Class.alert.error);
                // exit the function 
                return;
            }

            // take the age as integer number 
            int age = Convert.ToInt32(agestring); 

            // Check the range of the age 
            if (!(age >= 18 && age <= 65))
            {
                // call this function to handle the error alert 
                mc.ShowAlertForm(160, "Teacher Must Be Between the ages\n                 Of 18 to 65",
                    MainFunctions_Class.alert.error);
                // exit the function 
                return;
            }

            // check the format of the ID of the teacher 
            else if (!Regex.IsMatch(id, "^[0-9]{14}$"))
            {
                // call this function to handle the error alert 
                mc.ShowAlertForm(160, "         ID Must Be 14 Digits\n             WithOut Spaces",
                    MainFunctions_Class.alert.error);
                // exit the function 
                return;
            }

            // check the exitence of the ID in the database 
            else if (CheckExistence(id))
            {
                // call this function to handle the error alert 
                mc.ShowAlertForm(130, " ID Belongs To Another Teacher", MainFunctions_Class.alert.error);
                // exit the function 
                return;
            }

            // check the format of the Address 
            else if (!mc.AddressFormat.IsMatch(address) || address.Length < 20)
            {
                // call this function to handle the error alert 
                mc.ShowAlertForm(200, "    Address Must Be In Format\n  [BlockNumber] [StreetName],\n" +
                    "         [Citizen Name],[City]", MainFunctions_Class.alert.error);
                // exit the function 
                return;
            }

            // check the format of the barcode id 
            else if (!Regex.IsMatch(code, "^[0-9]+$"))
            {
                // call this function to handle the error alert 
                mc.ShowAlertForm(160, "BarCode ID Contains Digits Only\n             WithOut Spaces",
                    MainFunctions_Class.alert.error);
                // exit the function 
                return;
            }

            // check the exitence of the BarCodeID in the database 
            else if (CheckExistence(code))
            {
                // call this function to handle the error alert 
                mc.ShowAlertForm(130, " BarCode ID Belongs To Teacher", MainFunctions_Class.alert.error);
                // exit the function 
                return;
            }

            // check the format of the subject 
            else if(!Regex.IsMatch(subject, "^[A-Za-z]{3,}$"))
            {
                // call this function to handle the error alert 
                mc.ShowAlertForm(200, "Subject Contains Alphabet Letters\n   Only With Length 3 or More\n" +
                    "             WithOut Spaces", MainFunctions_Class.alert.error);
                // exit the function 
                return;
            }

            // check the fromat of the qualification 
            else if (!Regex.IsMatch(college, "^[A-Za-z ]{10,}$"))
            {
                // call this function to handle the error alert 
                mc.ShowAlertForm(160, "College Contains Alphabet Letters\n   Only With Length 10 or More",
                    MainFunctions_Class.alert.error);
                // exit the function 
                return;
            }

            // Now the 9 Inputs are ready check the attend and leave time for each input day in the comboboxes 
            
            // loop on the number of appears rows in the days of the teachers 
            for(int i =0; i<teacherrows; ++i)
            {
                // get the attend time as date time format class 
                DateTime AttendTime = DateTime.Parse(attendtime[i]);
                // get the leave time as date time format class 
                DateTime LeavTime = DateTime.Parse(leavetime[i]);
                // make this temp for the comparation holding the attend time
                DateTime temp = AttendTime;

                // check the attend time not before 7 AM and not after 3 PM 
                if (temp < DateTime.Parse("07:00 AM") || temp > DateTime.Parse("03:00 PM"))
                {
                    // assign the string error 
                    errortimemessage = "  Attend Time Error At Row #" + (i + 1).ToString();
                    // turn the flag off of the time (not valid) 
                    validtime = false;
                    // exit the loop 
                    break;
                }

                // check the Leave time not before 7 AM and not after 3 PM 
                else if (LeavTime < DateTime.Parse("08:00 AM") || LeavTime > DateTime.Parse("06:00 PM"))
                {
                    // assign the string error 
                    errortimemessage = "   Leave Time Error At Row #" + (i + 1).ToString();
                    // turn the flag off of the time (not valid) 
                    validtime = false;
                    // exit the loop 
                    break;
                }

                // in case the leave time is not fit for one class (at least hour) 
                // or the attend time is more than the leave time with the addition of one class time
                else if (temp.AddHours(1) > LeavTime)
                {
                    // assign the string error 
                    errortimemessage = "  Wrong Time Input At Row #" + (i + 1).ToString();
                    // turn the flag off of the time (not valid) 
                    validtime = false;
                    // exit the loop 
                    break;
                }
            }

            // in case the time is not valid 
            if(!validtime)
            {
                // call this function to handle the error alert 
                mc.ShowAlertForm(130, errortimemessage, MainFunctions_Class.alert.error);
                // exit the function 
                return;
            }

            // All Things Are Right Now Time To Insert Data In the Tables 

            // These variables to hold the strings of the days, attend time and leave time strings of the 
            // Teacher 
            string AttendDaysString = "", AttendTimeString = "", LeaveTimeString = "";

            // call this function to make the strings of the days, attend time and leave time 
            MakeStringsFromLists(ref AttendDaysString, ref AttendTimeString, ref LeaveTimeString,
                days, attendtime, leavetime); 

            // call this function to insert the 9 data of the teacher 
            InsertTeacherData(name, salary, phone, age, id, address, code, subject, college
                , AttendDaysString, AttendTimeString, LeaveTimeString);

            // call this function to create a table for the new teacher has been inserted 
            CreateTeacherTable(code);

            // call this function to return all things as before
            BackToOriginal(sender, e);

            // call this fucntion to handle the success alert 
            mc.ShowAlertForm(160, "           Teacher has been\n         Added Successfully",
                MainFunctions_Class.alert.success, ref NameTextBox, focusflag);
        }
    }
}
