using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gym_Management_System
{
    public partial class UserAttendanceForm : Form
    {
        public UserAttendanceForm()
        {
            InitializeComponent();
        }

        // Mark Attendance
        private void btnMarkAttendance_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text;
            DateTime attendanceDate = dtpAttendanceDate.Value;
            string attendanceTime = DateTime.Now.ToString("HH:mm:ss"); // Current Time

            if (string.IsNullOrWhiteSpace(userName))
            {
                MessageBox.Show("Please enter your name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Data_Base.OpenConnection();
                string query = "INSERT INTO user_attendance (user_name, attendance_date, attendance_time) " +
                               "VALUES (@UserName, @AttendanceDate, @AttendanceTime)";
                MySqlCommand cmd = new MySqlCommand(query, Data_Base.GetConnection());
                cmd.Parameters.AddWithValue("@UserName", userName);
                cmd.Parameters.AddWithValue("@AttendanceDate", attendanceDate);
                cmd.Parameters.AddWithValue("@AttendanceTime", attendanceTime);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Attendance marked successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            User_Form viewForm = new User_Form();
            viewForm.Show();
            this.Hide();
        }
    }
}
