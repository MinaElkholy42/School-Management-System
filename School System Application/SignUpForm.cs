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
using Guna.UI2.WinForms;
namespace School_System_Application
{
    public partial class SignUpForm : Form
    {
        // make object from the main function class 
        MainFunctions_Class mc;
        // this will hold the header label of the main personal form
        Label HeaderLabel;
        // these are the values of the entered data 
        string username, pass, name, phone, authonticationcode;
        // this button to take the reference of the sent guna2 button 
        Guna2Button loginbutton;
        // this variable hold the progress of the timer 
        int progressvalue;
        public SignUpForm(ref Label label, ref Guna2Button button)
        {
            InitializeComponent();
            // make new reference for the main functions class object 
            mc = new MainFunctions_Class();
            // assign the sent header label of main personal form to the variable by reference
            HeaderLabel = label;
            // initialize the values of the input data 
            username = pass = name = phone = authonticationcode = "";
            // assign the guna2 button 
            loginbutton = button;
            // intialzie the progress value of the timer of pop out alert notification 
            progressvalue = 0;
        }

        /// <summary>
        /// This function to indicate weather the code exists in the database or nots
        /// </summary>
        /// <param name="code"> The sender object from the event </param>
        /// <returns> return the flag to indicate the existence in the data base </returns>
        private bool IndicateCode(string code)
        {
            // this flag will hold the value of found or not found code in the database
            bool findcode = false;
            // make connection 
            SqlConnection con = mc.GetConnection();
            // make the sqlcommand 
            SqlCommand cmd = new SqlCommand(@"select AuthonticationCode from HRTable where 
                                                AuthonticationCode = @code", con);
            // add the sqlparameters 
            cmd.Parameters.AddWithValue("@code", code);
            // execute the data reader 
            SqlDataReader dr = cmd.ExecuteReader();
            // in case the data reader has rows 
            if (dr.HasRows) findcode = true; // turn the flag on
            // close the data reader 
            dr.Close();
            // close the conneciton 
            con.Close();
            return findcode; // return with the flag of the identification 
        }

        /// <summary>
        /// This function to get the HR Authontication Code For the Recovery of the account
        /// </summary>
        private string GetAuthonticationCode()
        {
            string code = ""; // this variabel will hold the authontication code of the Created HR Account
            
            // until we find a unique created code
            while (true)
            {
                // make random object from the random class 
                Random rand = new Random();
                // the length of the code is 6 length 
                for (int i = 0; i <6; ++i)
                    // each time create a random digit and add it to the code 
                    code += rand.Next(0,9).ToString();

                // call this function to indicate weahter the code in the data base before or not 
                if (!IndicateCode(code)) break; // exit the while loop
            }
            return code; // return with the code
        }

        /// <summary>
        /// This function to hide the main controls of the Sign Up Form 
        /// </summary>
        private void HideMainControls()
        {
            // hide all controls in the Form Except the label 
            NameTextBox.Visible = UserNameTextBox.Visible = PasswordTextBox.Visible
                = ConfrimPasswordTextBox.Visible = PhoneTextBox.Visible = SignUpButton.Visible = false;
            // make the focus and select on the from 
            this.Focus();
            this.Select();
        }

        /// <summary>
        /// This fucntion to indicate the pressed key on the keyboard
        /// </summary>
        private void EnterKeyDown(object sender, KeyEventArgs e)
        {
            // if the key down pressed is the enter 
            if (e.KeyValue == (char)Keys.Enter) // call the log in click function 
                SignUpButton_Click(sender, e);
        }

        /// <summary>
        /// This function to check if the user name or phone in the database before or not
        /// </summary>
        /// <param name="input"> The Entered User Name or Phone we want to check Existence</param>
        /// <returns> retrun flag indicates weather the user name in the database before or not s</returns>
        private bool CheckExistence(string input)
        {
            // this flag is the return on the function to indicate the existence of the user name or Phone
            bool isfound = false;
            // make the connection 
            SqlConnection con = mc.GetConnection();
            // make the sql command 
            SqlCommand cmd = new SqlCommand(@"select UserName, Phone from HRTable where Phone = @input 
                                              or UserName = @input", con);
            // add the sql parameter 
            cmd.Parameters.AddWithValue("@input", input);
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
        /// This function to set and show the confirm controls of the regiseration
        /// </summary>
        private void ShowConfirmControls()
        {
            // set the Positions of the Header Labels 
            NameHeaderLabel.Location = new Point(290, 55);
            PhoneHeaderLabel.Location = new Point(290, 105);
            UserNameHeaderLabel.Location = new Point(290, 155);
            PasswordHeaderLabel.Location = new Point(290, 205);

            // set the text of the data labels 
            NameLabel.Text = name;
            PhoneLabel.Text = phone;
            UserNameLabel.Text = username;

            // for the password make it encrypted as * after the second character 
            PasswordLabel.Text = pass[0].ToString() + pass[1].ToString();
            // loop on the rest of the password 
            for (int i = 2; i < pass.Length; ++i) PasswordLabel.Text += "*"; // add the * for each other character

            // set the Positions of the Data Labels
            NameLabel.Location = new Point(495, 55);
            PhoneLabel.Location = new Point(495, 105);
            UserNameLabel.Location = new Point(495, 155);
            PasswordLabel.Location = new Point(495, 205);

            // set the location of the confirm button 
            ConfirmButton.Location = new Point(325, 270);

            // set the location of the back button
            BackButton.Location = new Point(284, 6);

            // Show Confirm Controls
            NameHeaderLabel.Visible = PhoneHeaderLabel.Visible = UserNameHeaderLabel.Visible =
                PasswordHeaderLabel.Visible = NameLabel.Visible = PhoneLabel.Visible =
                UserNameLabel.Visible = PasswordLabel.Visible = ConfirmButton.Visible =
                BackButton.Visible = true;

            // make the focus and select on the confirmation button 
            ConfirmButton.Focus();
            ConfirmButton.Select();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            // call this function in the load of the sign up to know if there is sign up or not

            ///////////// LIMIT ACCOUNTS = 5 ///////////////////////////////////////////////////
            mc.GetHrSignUpValue(5);
            // in case the HR Flag is Turned On 
            if (MainFunctions_Class.GetHRFlag())
            {
                // cal this function to hide the Main controls of the form 
                HideMainControls();
                // set the error label as a message to the user HR in the middle of the form 
                mc.ShowErrorLabel(ref ErrorLabel, 268, 120, " &nbsp;Can Not Create More " +
                    "Accounts<br>Contact Us For More Information", 100, 420);
                // exit the function 
                return;
            }
            // on the loading make the select on the Name text box 
            NameTextBox.Focus();
            NameTextBox.Select();
        }

        private void PopoutTimer_Tick(object sender, EventArgs e)
        {
            // each time increament a value of the progress 
            progressvalue += 20;
            // in case we reach the end of the progress value which is 370 
            if (progressvalue >= 370)
            {
                // stop the timer 
                PopoutTimer.Stop();
                // make the pop out alert  object
                POPOutForm pof = new POPOutForm(name, authonticationcode, "Name : ", "Code : ");
                // make the pop out alert on the top most 
                pof.TopMost = true;
                // show the pop out alert with the needed data 
                pof.Show();
            }
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            // take the data from the text boxes 
             name = NameTextBox.Text.Trim(' '); 
             username = UserNameTextBox.Text.Trim(' ');
             pass = PasswordTextBox.Text.Trim(' ');
             string confirmation = ConfrimPasswordTextBox.Text.Trim(' ');
             phone = PhoneTextBox.Text.Trim(' ');

            /// check validation section 

            // in case the data is empty (or not all are entered) 
            if (name == "" || username == "" || pass == "" || confirmation == "" || phone == "")
            {
                // call this function to handle the error label
                mc.ShowErrorLabel(ref ErrorLabel, 540, 210, "Please Fill All Previous Data", 43, 439);
                // exit the function 
                return;
            }

            // check the format of the Entered name 
            else if (!mc.NameFormat.IsMatch(name))
            {
                // call this function to handle the error label
                mc.ShowErrorLabel(ref ErrorLabel, 503, 210, "Name Must Contain Only Alphabet<br>&nbsp;Letters," +
                    " And At Least 3 Characters<br>" + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" +
                    "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Length", 100, 420);
                // exit the funciton
                return;
            }

            // check the format of the Entered Phone Number 
            else if (!mc.PhonNumberFormat.IsMatch(phone))
            {
                // call this function to handle the error label
                mc.ShowErrorLabel(ref ErrorLabel, 508, 210, "The Phone Number Must Contain<br>" +
                    "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" +
                    "&nbsp;&nbsp;Only 11 Digits<br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" +
                    "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;WithOut Spaces", 100, 420);
                // exit the function 
                return;
            }

            // check the existence of the Phon Number in the data base 
            else if (CheckExistence(phone))
            {
                // call this function to handle the error label
                mc.ShowErrorLabel(ref ErrorLabel, 505, 210, "The Phone Number is Used Before<br>" +
                    "&nbsp;&nbsp;&nbsp; Please Choose Another One",
                    150, 490);
                // exit the function 
                return;
            }

            // check  the format of the Entered User Name
            else if (!mc.UserNameFormat.IsMatch(username))
            {
                // call this function to handle the error label
                mc.ShowErrorLabel(ref ErrorLabel, 510, 210, "&nbsp;&nbsp;User Name Must Contain Only " +
                    "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Alphanumeric Letters<br>" +
                    " Or UnderScores WithOut Spaces<br>&nbsp;&nbsp;&nbsp;&nbsp; And Must Start With Letter",
                    150, 490);
                // exit the funciton
                return;
            }

            // check the length of the user name 
            else if (!mc.UserNamelength.IsMatch(username))
            {
                // call this function to handle the error label
                mc.ShowErrorLabel(ref ErrorLabel, 573, 210, "Too Short User Name", 150, 490);
                // exit the funtion 
                return;
            }

            // check if the user name is in the data base before 
            else if (CheckExistence(username))
            {
                // call this function to handle the error label
                mc.ShowErrorLabel(ref ErrorLabel, 525, 210, "The User Name is Used Before<br>" +
                    "&nbsp;&nbsp;Please Choose Another One",
                    150, 490);
                // exit the funciton
                return;
            }

            // check if the password in the right format or not 
            else if (!mc.UpperCaseLetters.IsMatch(pass) || !mc.LowerCaseLetters.IsMatch(pass)
                || !mc.Digits.IsMatch(pass) || !mc.SpecialCharacters.IsMatch(pass))
            {
                // call this function to handle the error label
                mc.ShowErrorLabel(ref ErrorLabel, 505, 210, "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" +
                    "&nbsp;&nbsp;&nbsp;&nbsp;Password Must Be<br>Has at Least One UpperCase Letter<br>" +
                    "&nbsp;,One LowerCase Letter,One Digit<br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" +
                    "&nbsp;And One Special Character", 150, 490);
                // exit the function 
                return;
            }

            // check if the password contains spaces 
            else if (pass.Contains(' '))
            {
                // call this function to handle the error label
                mc.ShowErrorLabel(ref ErrorLabel, 502, 210, "Password Must Be Without Spaces", 150, 490);
                // exit the function 
                return;
            }

            // check The length of the password 
            else if (!mc.PasswordLength.IsMatch(pass))
            {
                // call this function to handle the error label
                mc.ShowErrorLabel(ref ErrorLabel, 580, 210, "Too Short Password", 150, 490);
                // exit the function 
                return;
            }

            // check if the enterd password is the same in the password text box 
            else if (confirmation != pass)
            {
                // call this function to handle the error label 
                mc.ShowErrorLabel(ref ErrorLabel, 515, 210, "Please Enter the Same Password", 150, 490);
                // exit the function 
                return;
            }

            // those variables will hold the x and y positions of the main personal opened form
            int x = 0, y = 0;
            // call this function to set the x and y locations of the branch loading form 
            mc.SetBranchLoadingFormPosition("MainPersonalForm", ref x, ref y);
            // call this function to load the branch loading form
            mc.OpenBranchLoadingForm1(x, y);

            // Set The Header Label by using this function
            mc.SetLabels(ref HeaderLabel, "Confirm Account", 347);
            // Hide the Main Controls by calling this fucntion 
            HideMainControls();
            // all is right so make the label invisible 
            ErrorLabel.Visible = false;

            // HERE WE WILL SHOW THE CONFIRM CONTROLS AND PLACE IT IN THE PROPER POSTIONS 
            // call this fucntion 
            ShowConfirmControls();
        }

        private void BackButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // those variables will hold the x and y positions of the main personal opened form
            int x = 0, y = 0;
            // call this function to set the x and y locations of the branch loading form 
            mc.SetBranchLoadingFormPosition("MainPersonalForm", ref x, ref y);
            // call this function to load the branch loading form
            mc.OpenBranchLoadingForm1(x, y);

            // call this function to set the text of the label inside the picture box 
            mc.SetLabels(ref HeaderLabel, "Account Sign Up", 353);

            // Hide the Confirm Controls of the form 
            NameHeaderLabel.Visible = PhoneHeaderLabel.Visible = UserNameHeaderLabel.Visible =
                PasswordHeaderLabel.Visible = NameLabel.Visible = PhoneLabel.Visible =
                UserNameLabel.Visible = PasswordLabel.Visible = ConfirmButton.Visible =
                BackButton.Visible = ErrorLabel.Visible = false;

            // show the Sign up controls  
            NameTextBox.Visible = UserNameTextBox.Visible = PasswordTextBox.Visible
               = ConfrimPasswordTextBox.Visible = PhoneTextBox.Visible = SignUpButton.Visible = true;

            // make the focus and select on the Name textbox 
            NameTextBox.Focus();
            NameTextBox.Select();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            // call this function to get the authontication code 
            authonticationcode = GetAuthonticationCode();
            // open connection 
            SqlConnection con = mc.GetConnection();
            // make sql command 
            SqlCommand cmd = new SqlCommand(@"insert into HRTable values(@name, @username, @pass, @code,
                                              @phone)", con);
            // add the sql command parameters 
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@pass", pass);
            cmd.Parameters.AddWithValue("@code", authonticationcode);
            cmd.Parameters.AddWithValue("@phone", phone);
            // execute the command 
            cmd.ExecuteNonQuery(); 
            // close the connection 
            con.Close();

            // move to the main personal form log in page
            loginbutton.Checked = true;

            // start the pop out timer now 
            PopoutTimer.Start();
        }
    }
}
