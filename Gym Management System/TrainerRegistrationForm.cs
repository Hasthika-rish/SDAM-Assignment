using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gym_Management_System
{
    public partial class TrainerRegistrationForm : Form
    {
        public TrainerRegistrationForm()
        {
            InitializeComponent();
        }

        // Register Trainer
        private void btnRegisterTrainer_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string specialization = txtSpecialization.Text;
            int experience;

            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(specialization) ||
                !int.TryParse(txtExperience.Text, out experience))
            {
                MessageBox.Show("Please fill in all required fields with valid information.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime joinDate = dtpJoinDate.Value;

            try
            {
                Data_Base.OpenConnection();
                string query = "INSERT INTO trainers (full_name, email, phone, specialization, experience, join_date) " +
                               "VALUES (@FullName, @Email, @Phone, @Specialization, @Experience, @JoinDate)";
                MySqlCommand cmd = new MySqlCommand(query, Data_Base.GetConnection());
                cmd.Parameters.AddWithValue("@FullName", fullName);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Specialization", specialization);
                cmd.Parameters.AddWithValue("@Experience", experience);
                cmd.Parameters.AddWithValue("@JoinDate", joinDate);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Trainer registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button1_Click(object sender, EventArgs e)
        {
            Trainer_Form viewForm = new Trainer_Form();
            viewForm.Show();
            this.Hide();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
