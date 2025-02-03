using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gym_Management_System
{
    public partial class LoginForm : Form
    {
        public string UserRole { get; private set; }
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            Data_Base db = new Data_Base(); 
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();


            MySqlCommand command = new MySqlCommand("SELECT `role` FROM `users` WHERE `username` = @username AND `password` = @password", Data_Base.GetConnection());


            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = username_txt.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password_txt.Text;

            try
            {
                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                  
                    UserRole = table.Rows[0]["role"].ToString().ToLower();

                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK; 
                    this.Close(); 
                }
                else
                {
                    MessageBox.Show("Invalid username or password!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void password_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
