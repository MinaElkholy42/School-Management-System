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
using System.Data.SqlTypes;
using System.Data.SqlClient;
namespace School_System_Application
{
    public partial class LogInForm : Form
    {
        // make object from the main function class 
        MainFunctions_Class mc;
        // this will hold the header label of the main personal form
        Label HeaderLabel;
        // this object will hold the main personal form that hold the loging form 
        Form MainForm;
        // this flag to indicate the state of the show password button 
        bool showflag;
        public LogInForm(ref Label label, ref Form form)
        {
            InitializeComponent();
            // make new reference for the main functions class object 
            mc = new MainFunctions_Class();
            // intialize the show flag of the show password button 
            showflag = false;
            // assign the header label of the main personal form 
            HeaderLabel = label;
            // assign the main personal form object 
            MainForm = form;
        }

        /// <summary>
        /// This Function To Run The Video of the Loading To the Controls Form
        /// </summary>
        private void RunLoadingVideo()
        {
            // make object from the loading video form 
            VideoLoadingForm vl = new VideoLoadingForm();
            // hide the main personal form 
            MainForm.Hide(); 
            // Close the current form 
            this.Close();
            // make the Video Loading Form on the top of all other forms 
            vl.TopLevel = true;
            // show the Loading Video Form Now 
            vl.Show();
        }

        /// <summary>
        /// This fucntion to indicate the pressed key on the keyboard
        /// </summary>
        private void EnterKeyDown(object sender, KeyEventArgs e)
        {
            // if the key down pressed is the enter 
            if (e.KeyValue == (char)Keys.Enter) // call the log in click function 
                LogInButton_Click(sender, e);
        }

        private void WordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            // if the key down pressed is the enter 
            if (e.KeyValue == (char)Keys.Enter) // call the log in click function 
                SetWordButton_Click(sender, e);
        }

        /// <summary>
        /// This function to check if the Entered User Name With the password is correct or not
        /// </summary>
        /// <param name="pass"> The password the HR has Entered </param>
        /// <param name="user"> The User Name the HR has Entered </param>
        /// <returns> The Flag Indicate Weather the Entered User name and Password are correct for HR </returns>
        private bool CheckUserName_Password(string pass, string user)
        {
            // this flag is the reutrn of this function to indicate the validation of the user name and password
            bool isvalidate = false;
            // first make the connection 
            SqlConnection con = mc.GetConnection();
            // make the sql command 
            SqlCommand cmd = new SqlCommand(@"select Password, UserName from HRTable
                                              where UserName = @user and Password = @pass", con);
            // add the sql parameters 
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@pass", pass);
            // make sql data reader 
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows) // if the dr has rows (the only unique row) 
                isvalidate = true; // make the flag true (as the Data Entered is valid) 
            // close the data reader 
            dr.Close();
            // close the connection 
            con.Close();
            return isvalidate; // return with the flag
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
            // on the loading make the select on the user name text box 
            UserNameTextBox.Focus();
            UserNameTextBox.Select();

            // check if there is any thing in the resources save with the remeber me switch 
            if(Properties.Settings.Default.UserName  != string.Empty)
            {
                // assign the user name to the text box of the UserName
                UserNameTextBox.Text = Properties.Settings.Default.UserName;
                // assign the password to the text box of the Password 
                PasswordTextBox.Text = Properties.Settings.Default.Password;
                // turn the switch on 
                RemeberMeToggleSwitch.Checked = true;
            }
        }

        private void ShowPasswordButton_Click(object sender, EventArgs e)
        {
            
            // in case the button was unchecked by the show flag
            if (!showflag)
            {
                // make the button checked with the show flag 
                showflag = true;
                // make the current image is the limegreen image 
                ShowPasswordButton.Image = Properties.Resources.Eye_2;
                // make the text box of the password unprotected by the null character 
                PasswordTextBox.PasswordChar = '\0';
                // make the text color of the password text box limegreen 
                PasswordTextBox.ForeColor = Color.LimeGreen;
            }

            // in case the button was checked by the show flag 
            else if(showflag)
            {
                // make the button uncehcked with the show flag
                showflag = false;
                // make the current image is the original gray image 
                ShowPasswordButton.Image = Properties.Resources.Eye_1;
                // make the text box of the password protected by the * character 
                PasswordTextBox.PasswordChar = '*';
                // make the text color of the password text box White 
                PasswordTextBox.ForeColor = Color.White;    
            }
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            // first get the data from the user name and password text boxes with trim 
            // to eleminate the spaces on the right and the left of the strings 
            string username = UserNameTextBox.Text.Trim(' ');
            string password = PasswordTextBox.Text.Trim(' ');

            /*
            Properties.Settings.Default.HRWord = "";
            Properties.Settings.Default.Save(); */

            /// Check Validation Seciton

            // check for the empty data 
            if (username == "" || password == "")
            {
                // call this function to handle the label error
                mc.ShowErrorLabel(ref ErrorLabel, 230, 209, "Please Fill the User Name and Password", 43, 606);
                // exit the funtion 
                return;
            }
            
            // check if the Entered Data is correct or not
            else if (!CheckUserName_Password(password, username))
            {
                // call this function to handle the label error
                mc.ShowErrorLabel(ref ErrorLabel, 180, 209, "Wrong User Name or Password, Please Try Again", 43, 606);
                // exit the function 
                return;
            }

            // this means every thin is right to move on
            ErrorLabel.Visible = false; // make the error label invisible
            
            // check if the remeber me toggle switch is on 
            if(RemeberMeToggleSwitch.Checked)
            {
                // save the data to the default resources in the system as user name and password type of strings
                Properties.Settings.Default.UserName = username; // assign user name
                Properties.Settings.Default.Password = password; // assign the password
                Properties.Settings.Default.Save(); // save the new default data
            }
            
            // in case the remeber me button is not switch on 
            else
            {
                // Clear the data to the default resources in the system as user name and password type of strings
                Properties.Settings.Default.UserName = string.Empty; // assign Empty user name
                Properties.Settings.Default.Password = string.Empty; // assign Empty the password
                Properties.Settings.Default.Save(); // save the new default data
            }

            // if it is the first log in (no word set in the resources of the project) 
            if (Properties.Settings.Default.HRWord == string.Empty)
            {
                // those variables will hold the x and y positions of the main personal opened form
                int x = 0, y = 0;
                // call this function to set the x and y locations of the branch loading form 
                mc.SetBranchLoadingFormPosition("MainPersonalForm", ref x, ref y);
                // call this function to load the branch loading form   
                mc.OpenBranchLoadingForm1(x, y);

                // Set The Header Label by using this function
                mc.SetLabels(ref HeaderLabel, "Set HR Word", 385);

                // hide the main log ing controls 
                UserNameTextBox.Visible = PasswordTextBox.Visible = ErrorLabel.Visible
                     = LogInButton.Visible = RemeberMeLabel.Visible = RemeberMeToggleSwitch.Visible
                      = ShowPasswordButton.Visible = false;

                // show the set word controls 
                WordTextBox.Visible = SetWordButton.Visible = true;

                // make focus and select on the HR Word TextBox
                WordTextBox.Focus();
                WordTextBox.Select();
            }

            else // call this function to run the loading video 
                RunLoadingVideo();

        }

        private void SetWordButton_Click(object sender, EventArgs e)
        {
            // take the entered word from the text box
            string word = WordTextBox.Text.Trim(' '); 

            // check the empty input 
            if(word == "")
            {
                // call this function to handle the label error
                mc.ShowErrorLabel(ref ErrorLabel, 340, 190, "Please Fill HR Word", 60, 606);
                // exit the function 
                return; 
            }

            // check the format of the word 
            else if (!mc.UpperCaseLetters.IsMatch(word) || !mc.LowerCaseLetters.IsMatch(word)
                || !mc.SpecialCharacters.IsMatch(word) || !mc.Digits.IsMatch(word))
            {
                // call this function to handle the label error
                mc.ShowErrorLabel(ref ErrorLabel, 140, 170, "HR Word Must Has at Least One UpperCase Letter," +
                    " One LowerCase Letter, One Digit And One Special Character", 80, 700);
                // exit the funciton 
                return;
            }

            // check if the Word contains spaces 
            else if (word.Contains(' '))
            {
                // call this function to handle the error label
                mc.ShowErrorLabel(ref ErrorLabel, 260, 190, "HR Word Must Be Without Spaces", 60, 606);
                // exit the function 
                return;
            }

            // check The length of the Word 
            else if (!mc.PasswordLength.IsMatch(word))
            {
                // call this function to handle the error label
                mc.ShowErrorLabel(ref ErrorLabel, 340, 190, "Too Short HR Word", 60, 606);
                // exit the function 
                return;
            }

            // hide the error label 
            ErrorLabel.Visible = false;

            // set the HR Word to the 
            Properties.Settings.Default.HRWord = word;
            Properties.Settings.Default.Save(); // save the assigned word

            // call this function to run the loading video 
            RunLoadingVideo();
        }
    }
}
