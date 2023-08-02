using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Example
{
    public class Login
    {
        // Declare private member variables for username, password and
        // login status message
        private string mUsernameString;
        private string mPasswordString;

        // Declare a variable for counting login attempts 
        // Make this static so it can be called upon in another class
        static int countOfLoginAttemptsInteger;

        // Declare a variable for verifying if login was successful or not
        static bool loginStatusBoolean;

        // Add a parameterized constructor with 2 parameters (username, password)
        // Inside the constructor, set the 2 properties to their respective parameters.
        // Then, add a method call to the method ValidateCredentials().
        public Login(string username, string password)
        {
            Username = username;
            Password = password;
            ValidateCredentials();
        }

        // Declare 3 public properties (Username, Password, LoginStatusMessage) 
        public string Username
        {
            get
            {
                return mUsernameString;
            }
            set
            {
                mUsernameString = value;
            }
        }
        public string Password
        {
            get
            {
                return mPasswordString;
            }
            set
            {
                mPasswordString = value;
            }
        }

        // Declare another public property (LoginAttempts) to track login attempts
        public static int LoginAttempts
        {
            get
            {
                return countOfLoginAttemptsInteger;
            }
            set
            {
                countOfLoginAttemptsInteger = value;
            }
        }

        // Declare one more public property (LoginStatus) to verify whether the login attempt was successful or not
        public static bool LoginStatus
        {
            get
            {
                return loginStatusBoolean;
            }
            set
            {
                loginStatusBoolean = value;
            }
        }

        // Declare a method called IncrementLoginAttemptsCounter().  Inside the 
        // method, add code to increment the variable for counting login attempts by 1
        // using its property.
        public void IncrementLoginAttemptsCounter()
        {
            LoginAttempts++;
        }

        // Declare a method called ResetLoginAttemptsCounter(). This will reset the login attempts to 0
        // if the user logged in succesfully
        public void ResetLoginAttemptsCounter()
        {
            LoginAttempts = 0;
        }

        // Declare a method called ValidateCredentials() This will validate the credntials entered.
        public void ValidateCredentials()
        {
           // If else statements to check if the username entered is correct
            if (LoginAttempts >= 3)
            {
                IncrementLoginAttemptsCounter();
                LoginStatus = false;
            }
            else
            {
                if (Username != "Heisenberg")
                {
                    IncrementLoginAttemptsCounter();
                    LoginStatus = false;
                }
                else
                {
                    if (Password != "Jesse!!!")
                    {
                        IncrementLoginAttemptsCounter();
                        LoginStatus = false;
                    }
                    else
                    {
                        UserDetailsForm newUserDetailsForm = new UserDetailsForm();
                        newUserDetailsForm.ShowDialog();
                        ResetLoginAttemptsCounter();
                        LoginStatus = true;
                    }
                }
            }
        }
    }
}
