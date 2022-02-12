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
using System.Data.SqlClient;
using System.Text.RegularExpressions;
namespace School_System_Application
{
    public class MainFunctions_Class // this class To Hold All the Main Functions of the Appliction 
    {
        /// <summary>
        /// Those Regualr Expresions for the format of the Entered Data 
        /// </summary>

        // This is the regular expression for the format of the Names
        public Regex NameFormat = new Regex(@"^[A-Za-z ]{3,}$");

        // This is the regular expression for the format of the User Name
        public Regex UserNameFormat = new Regex(@"^[A-Za-z][A-Za-z_0-9]*$");

        // This is the regular expression for the length of the user name 
        public Regex UserNamelength = new Regex(@"^.{10,}$");

        // This is the regular expression for the format of the Phone Number
        public Regex PhonNumberFormat = new Regex(@"^[0-9]{11}$");

        // This is the regular expression for the format of the UpperCase Letters 
        public Regex UpperCaseLetters = new Regex(@"[A-Z]+");

        // This is the regular expression for the format of the LowerCase Letters
        public Regex LowerCaseLetters = new Regex(@"[a-z]+");

        // This is the regular expression for the format of the Digits
        public Regex Digits = new Regex(@"[0-9]+");

        // This is the regular expression for the format of the Spcial Characters 
        public Regex SpecialCharacters = new Regex(@"[\+\*\\\-/=&\^%\$#@!\._]+");

        // This is the regular expression for the format of the Length of Password 
        public Regex PasswordLength = new Regex(@"^.{8,}$");

        // This is the regualr expression for the format of the Address 
        public Regex AddressFormat = new Regex(@"^[0-9]+ [A-Za-z ]+,[A-Za-z ]+,[A-Za-z ]+$");

        // This variable will hold the on and off for the sign up button of the HR 
        public static bool HRSignUp { get; set; }
        // This variable will hold the on and off for the Addition Of the Teachers 
        public static bool TeacherAdd { get; set; }

        // This enumerator to handle the errors pop out alerts and success messages 
        public enum alert
        {
            success, error
        };

        /// <summary>
        /// This function to indicate weather the system able to create more accounts or not 
        /// </summary>
        /// <param name="limitaccounts"> The limit number of accounts available for the HR Stuff </param>
        public void GetHrSignUpValue(int limitaccounts)
        {
            // make the connection 
            SqlConnection con = GetConnection();
            // make the sql command of the sql server 
            SqlCommand cmd = new SqlCommand("select count(ID) from HRTable", con);
            // make the sql data reader 
            SqlDataReader dr = cmd.ExecuteReader();
            // read the first row 
            dr.Read();
            // in case the count of rows in the data reader is the limit number of account
            if (Convert.ToInt32(dr[0].ToString()) == limitaccounts)
                SetHRFlag(true); // call this function to make the flag on

            // in case not set it to false (can create more accounts)
            else
                SetHRFlag(false); 
            // close the data reader 
            dr.Close();
            // close the connection 
            con.Close();
        }

        /// <summary>
        /// This function to set the value of the HR Flag of the Sign Up
        /// </summary>
        /// <param name="value"> The Value of the HR Sign Up Flag </param>
        public static  void SetHRFlag(bool value)
        {
            HRSignUp = value; // set the value of the HR flag
        }

        /// <summary>
        /// This function to return the vlaue of the HR Sign Up Flag
        /// </summary>
        /// <returns> The Value of the HR Flag Either True or Fals (ON or OFF)</returns>
        public static bool GetHRFlag()
        {
            return HRSignUp; // return with the HR Flag Value
        }

        /// <summary>
        /// This function to get the value indicates weather the number of teachers in the add is limitd or not
        /// </summary>
        /// <param name="limitnumber"> The limit of the number of the add teachers value </param>
        public void GetTeacherAddValue(int limitnumber)
        {
            // make the connection 
            SqlConnection con = GetConnection();
            // make the sql command of the sql server 
            SqlCommand cmd = new SqlCommand("select count(ID) from TeacherTable", con);
            // make the sql data reader 
            SqlDataReader dr = cmd.ExecuteReader();
            // read the first row 
            dr.Read();
            // in case the count of rows in the data reader is the limit number of Teachers
            if (Convert.ToInt32(dr[0].ToString()) == limitnumber)
                SetTeacherFlag(true); // call this function to make the flag on

            // in case not set it to false (can Add more Teachers)
            else
                SetTeacherFlag(false);
            // close the data reader 
            dr.Close();
            // close the connection 
            con.Close();
        }

        /// <summary>
        /// This function to set the value of the Teacher Add Flag 
        /// </summary>
        /// <param name="value"> The Value of the Teacher Add Flag </param>
        public static void SetTeacherFlag(bool value)
        {
            TeacherAdd = value; // set the value of the Teacher Add flag
        }

        /// <summary>
        /// This function to return the vlaue of the Teacher Add Flag
        /// </summary>
        /// <returns> The Value of the Teacher Add Flag Either True or Fals (ON or OFF) </returns>
        public static bool GetTeacherFlag()
        {
            return TeacherAdd; // return with the Teacher Add Flag Value
        }

        /// <summary>
        /// This function For makeing the connection of the data base
        /// </summary>
        /// <returns> The connection of the data base object from sql server </returns>
        public SqlConnection GetConnection()
        {
            // make new sql connection with the connection string
            SqlConnection con = new SqlConnection("Data Source = .\\SQLEXPRESS;Integrated Security = true; database = SchoolDataBase");
            // open the connection
            con.Open();
            // reutrn with the connection
            return con;
        }

        /// <summary>
        /// This function to set the down panle (border) of all header form buttons
        /// </summary>
        /// <param name="x"> the x position of the panel </param>
        /// <param name="y"> the y position of the panel </param>
        /// <param name="downpanel"> the panel we will set for the button </param>
        /// <param name="width"> the width of the panel </param>
        public void SetButtonPanel(int x, int y, ref Panel downpanel, int width)
        {
            // set the heigth and width of the panel 
            downpanel.Width = width;
            downpanel.Height = 3;
            // set the color of the panel 
            downpanel.BackColor = Color.FromArgb(238, 164, 18);
            // set the position of the panels according to the button 
            downpanel.Location = new Point(x, y);
            // bring the panel on the front of the header panel 
            downpanel.BringToFront();
        }

        /// <summary>
        /// This function to check if the form is opened or not 
        /// </summary>
        /// <param name="name"> The name of the form we want to check </param>
        /// <param name="flag"> The flag that will indicate in the sent function if the form is opened or not </param>
        public void CheckOpenedForm(string name, ref bool flag)
        {
            // loop on each opened form in the application
            foreach(Form form in Application.OpenForms)
            {
                // check the name of the current selected form 
                if(form.Name == name)
                {
                    // bring the form to the front 
                    form.BringToFront();
                    // make the form in the normal window mode 
                    form.WindowState = FormWindowState.Normal;
                    // make the top level of the form to the 
                    form.TopLevel = true;
                    // set the flag to true 
                    flag = true;
                    // exit the loop 
                    break;
                }
            }
        }

        /// <summary>
        /// This function to set the x and y coordinate according to the name of the main parent form
        /// </summary>
        /// <param name="name"> The name of the Parent Form </param>
        /// <param name="x"> The x location of the branch loading form </param>
        /// <param name="y"> The y location of the branch loading form</param>
        public void SetBranchLoadingFormPosition(string name, ref int x, ref int y)
        {
            // search the opened froms to get the main personal form 
            foreach (Form form in Application.OpenForms)
            {
                // in case the form is the one we are looking for 
                if (form.Name == name)
                {
                    // assgin the x and y locations to our variables 
                    x = form.Location.X;
                    y = form.Location.Y;
                    // break and exit the loop 
                    break;
                }
            }
        }

        /// <summary>
        /// This function to load the branch loading form
        /// </summary>
        /// <param name="x"> The location of the form in the x axis </param>
        /// <param name="y"> The location of the form in the y axis </param>
        public void OpenBranchLoadingForm1(int x, int y)
        {
            // make object from the branch loading form with the locations of the current form
            BranchLoadingForm1 bf = new BranchLoadingForm1(x, y);
            // make the branch loading form on the top most 
            bf.TopMost = true;
            // show the loading form 
            bf.Show();
        }


        /// <summary>
        /// This Function To make the background of the labels Transparent
        /// </summary>
        /// <param name="label"> The Label we want to make the background transperent </param>
        public void MakeLabelTranspaernt(ref Label label, ref PictureBox box)
        {
            // make the picture box is the parent of the label
            label.Parent = box;
            // make the background now transparent for the label 
            label.BackColor = Color.Transparent;
        }

        /// <summary>
        /// This function to show the label of the error occured in the form
        /// </summary>
        /// <param name="label"> The label of the Error </param>
        /// <param name="x"> The X location of the label in the form </param>
        /// <param name="y"> The Y location of the label in the form </param>
        /// <param name="Error"> The Error Text will be written on the label </param>
        /// <param name="heigth"> The Heigth of the label </param>
        /// <param name="width"> The Width of the label </param>
        public void ShowErrorLabel(ref Guna2HtmlLabel label, int x, int y, string error, int height, int width)
        {
            // set the error message to the label 
            label.Text = error;
            // make new point of the label for the location
            label.Location = new Point(x, y);
            // set the height of the label 
            label.Height = height;
            // set the width of the label 
            label.Width = width;
            // make the label visible 
            label.Visible = true;
        }


        /// <summary>
        /// This function to show the alert in the school main controls form for teachers and other options
        /// </summary>
        /// <param name="height"> the height of the alert </param>
        /// <param name="message"> the message of the alert </param>
        /// <param name="alerttype"> the type of the alert </param>
        public void ShowAlertForm(int height, string message, MainFunctions_Class.alert alerttype)
        {
            // make object from the alert form with the sent parameters
            POPOutAlert poa = new POPOutAlert(height, message, alerttype);
            // make the alert on the top of all other forms 
            poa.TopMost = true;
            // show the alert 
            poa.Show();
        }

        /// <summary>
        /// This function to show the alert in the school main controls form for teachers and other options
        /// </summary>
        /// <param name="height"> the height of the alert </param>
        /// <param name="message"> the message of the alert </param>
        /// <param name="alerttype"> the type of the alert </param>
        /// <param name="textbox"> the text box we want to focus on it </param>
        /// <param name="focusflag"> the flag to indicate to make focus or not </param>
        public void ShowAlertForm(int height, string message, MainFunctions_Class.alert alerttype
            , ref Guna2TextBox textbox, bool focusflag)
        {
            // make object from the alert form with the sent parameters
            POPOutAlert poa = new POPOutAlert(height, message, alerttype, ref textbox, focusflag);
            // make the alert on the top of all other forms 
            poa.TopMost = true;
            // show the alert 
            poa.Show();
        }

        /// <summary>
        /// This Function to Set the Labels text Inside the picture Box for the Main Personal Form
        /// </summary>
        /// <param name="header"> The Text in the Header Label </param>
        /// <param name="x_position"> The position of the x axis of the Label </param>
        public void SetLabels(ref Label HeaderLabel, string header, int x_position)
        {
            // set the header of the label 
            HeaderLabel.Text = header;
            // set the position of the x axis of the label and the same of y axis
            HeaderLabel.Location = new Point(x_position, HeaderLabel.Location.Y);
        }
    }
}
