using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gym_Management_System
{
    public partial class AdminAttendanceManagement : Form
    {
        public AdminAttendanceManagement()
        {
            InitializeComponent();
            LoadAttendanceRecords();
        }

        // Load all user attendance records into DataGridView
        private void LoadAttendanceRecords()
        {
            try
            {
                Data_Base.OpenConnection();
                string query = "SELECT id, user_name, attendance_date, attendance_time FROM user_attendance";
                MySqlCommand cmd = new MySqlCommand(query, Data_Base.GetConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dgvAttendanceRecords.DataSource = table;
                dgvAttendanceRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        // Delete Attendance Record
        private void btnDeleteAttendance_Click(object sender, EventArgs e)
        {
            if (dgvAttendanceRecords.SelectedRows.Count > 0)
            {
                int attendanceId = Convert.ToInt32(dgvAttendanceRecords.SelectedRows[0].Cells["id"].Value);

                DialogResult confirm = MessageBox.Show("Are you sure you want to delete this attendance record?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        Data_Base.OpenConnection();
                        string query = "DELETE FROM user_attendance WHERE id=@AttendanceId";
                        MySqlCommand cmd = new MySqlCommand(query, Data_Base.GetConnection());
                        cmd.Parameters.AddWithValue("@AttendanceId", attendanceId);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Attendance record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadAttendanceRecords(); // Refresh DataGridView
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
            }
            else
            {
                MessageBox.Show("Please select an attendance record to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_Form viewForm = new Admin_Form();
            viewForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
