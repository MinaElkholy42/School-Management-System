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
    public partial class RecoverAccountForm : Form
    {
        // make object from the main function class 
        MainFunctions_Class mc;
        // those variables to hold the user name and password 
        string username, pass;
        public RecoverAccountForm()
        {
            InitializeComponent();
            // make new reference for the main functions class object 
            mc = new MainFunctions_Class();
            // initialize the variables that hold the username and password 
            username = pass = "";
        }

        /// <summary>
        /// This fucntion to indicate the pressed key on the keyboard
        /// </summary>
        private void EnterKeyDown(object sender, KeyEventArgs e)
        {
            // if the key down pressed is the enter 
            if (e.KeyValue == (char)Keys.Enter) // call the log in click function 
                RecoverButton_Click(sender, e);
        }

        /// <summary>
        /// This function to check if the Entered User Name With the password is correct or not
        /// </summary>
        /// <param name="name"> The Name the HR has Entered </param>
        /// <param name="code"> The Authontication Code the HR has Entered </param>
        /// <returns> The Flag Indicate Weather the Entered Name and Authontication Code are correct for HR </returns>
        private bool CheckName_Code(string name, string code)
        {
            // this flag is the reutrn of this function to indicate the validation
            bool isvalidate = false;
            // first make the connection 
            SqlConnection con = mc.GetConnection();
            // make the sql command 
            SqlCommand cmd = new SqlCommand(@"select UserName, Password Name, AuthonticationCode from HRTable
                                              where AuthonticationCode = @code and Name = @name", con);
            // add the sql parameters 
            cmd.Parameters.AddWithValue("@code", code);
            cmd.Parameters.AddWithValue("@name", name);
            // make sql data reader 
            SqlDataReader dr = cmd.ExecuteReader();
            // if the dr has rows (the only unique row)
            if (dr.HasRows)
            { 
                isvalidate = true; // make the flag true (as the Data Entered is valid)
                // read the first row 
                dr.Read();
                // assign the found user name and password to the variables 
                username = dr[0].ToString();
                pass = dr[1].ToString();
            }
            // close the data reader 
            dr.Close();
            // close the connection 
            con.Close();
            return isvalidate; // return with the flag
        }

        private void RecoverAccountForm_Load(object sender, EventArgs e)
        {
            // on the loading of the form make the select and focus on the name text box 
            NameTextBox.Focus();
            NameTextBox.Select();
        }

        private void RecoverButton_Click(object sender, EventArgs e)
        {
            // Take the data 
            string name = NameTextBox.Text.Trim(' ');
            string code = CodeTextBox.Text.Trim(' '); 

            // Check if Empty Data Entered in the Text Boxes 
            if(name == "" || code == "")
            {
                // call this function to handle the label error
                mc.ShowErrorLabel(ref ErrorLabel, 197, 159, "Please Fill HR Name and Authontication Code", 43, 606);
                // Exit the Function 
                return;
            }

            // now check the entered data existence in the database using this function 
            else if (!CheckName_Code(name, code))
            {
                // call this function to handle the label error
                mc.ShowErrorLabel(ref ErrorLabel, 140, 159, "Wrong Name or Authontication Code, Please Try Again", 
                    43, 650);
                // Exit the Function 
                return;
            }

            // All Things is Right 
            // hide the error label 
            ErrorLabel.Visible = false;

            // back to original as empty text boxes 
            NameTextBox.Text = CodeTextBox.Text = string.Empty;

            // open the pop out alert  through makin object with the values desired (username and password)
            POPOutForm pof = new POPOutForm(username, pass, "UserName : ", "Password : "
                , ref NameTextBox);
            // make the form on the top most 
            pof.TopMost = true;
            // show the alert pop out form 
            pof.Show();
        }
    }
}
