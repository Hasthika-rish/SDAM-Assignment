using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gym_Management_System
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            int age;
            if (!int.TryParse(txtAge.Text, out age))
            {
                MessageBox.Show("Please enter a valid age!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string gender = cmbGender.SelectedItem?.ToString();
            DateTime joinDate = dtpJoinDate.Value;

            // Basic Validation
            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(gender))
            {
                MessageBox.Show("Please fill in all required fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Data_Base.OpenConnection();

                // Check if email already exists
                string checkQuery = "SELECT COUNT(*) FROM participants WHERE email=@Email";
                using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, Data_Base.GetConnection()))
                {
                    checkCmd.Parameters.AddWithValue("@Email", email);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Email already registered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Insert Data
                string query = "INSERT INTO participants (full_name, email, phone, age, gender, join_date) " +
                               "VALUES (@FullName, @Email, @Phone, @Age, @Gender, @JoinDate)";

                using (MySqlCommand cmd = new MySqlCommand(query, Data_Base.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@FullName", fullName);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Age", age);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@JoinDate", joinDate);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Data_Base.CloseConnection();
            }
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            User_Form viewForm = new User_Form();
            viewForm.Show();
            this.Hide();
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
