using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encapsulation_Example
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        // Click event for the login button (Executes after clicking login button)
        private void loginButton_Click(object sender, EventArgs e)
        {
            // Declare variables to store username, password, and login status message
            string usernameString;
            string passwordString;
            string loginStatusMessageString;

            // Get the username and password textbox controls on the form and store them in the username and password variables
            usernameString = usernameTextBox.Text;
            passwordString = passwordTextBox.Text;

            // Instantiate an object (newLogin) of the class type Login using the class's parameterized constructor
            // This is passing the values from the usernameString and passwordString to the Login.cs class to validate the credentials
            Login newLogin = new Login(usernameString, passwordString);

            // If statement to verify if login was succesful or not
            if (Login.LoginStatus == false)
            {
                // if the number of failed attempts is less than or equal to 3
                if (Login.LoginAttempts <= 3)
                {
                    // Add a 4-argument message box (with a Warning icon) to display the login status message
                    loginStatusMessageString = "Sorry, the username/password you entered was not correct! Please Try Again!!!";

                    MessageBox.Show(loginStatusMessageString, "Login Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // Use an if-statement block to check if the number of failed attempts
                // is more than 3
                if (Login.LoginAttempts > 3)
                {
                    // Add a 4-argument message box (with a Stop icon) to display the login status message
                    loginStatusMessageString = "Sorry, you exhausted all your attempts! Please contact customer support!!!";

                    MessageBox.Show(loginStatusMessageString, "Login Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Close the application
                    this.Close();
                }
            }
        }
    }
}
