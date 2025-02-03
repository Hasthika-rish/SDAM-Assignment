using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Management_System
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           
          
            LoginForm fLogin = new LoginForm();
            if (fLogin.ShowDialog() == DialogResult.OK)
            {
                Form nextForm = null;

               
                if (fLogin.UserRole == "admin")
                {
                    nextForm = new Admin_Form(); 
                }
                else if (fLogin.UserRole == "trainer")
                {
                    nextForm = new Trainer_Form(); 
                }
                else if (fLogin.UserRole == "user")
                {
                    nextForm = new User_Form(); 
                }
                else
                {
                    MessageBox.Show("Unknown user role!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Start the application with the selected form
                Application.Run(nextForm);
            }
        }
    }
}
