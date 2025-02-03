using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gym_Management_System
{
    public partial class TrainerReservationForm : Form
    {
        public TrainerReservationForm()
        {
            InitializeComponent();
            LoadAvailableTrainers();
        }

        // Load available trainers into DataGridView
        private void LoadAvailableTrainers()
        {
            try
            {
                Data_Base.OpenConnection();
                string query = "SELECT id, full_name, specialization, experience FROM trainers";
                MySqlCommand cmd = new MySqlCommand(query, Data_Base.GetConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dgvAvailableTrainers.DataSource = table;
                dgvAvailableTrainers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        // Reserve Trainer
        private void btnReserveTrainer_Click(object sender, EventArgs e)
        {
            if (dgvAvailableTrainers.SelectedRows.Count > 0)
            {
                int trainerId = Convert.ToInt32(dgvAvailableTrainers.SelectedRows[0].Cells["id"].Value);
                string memberName = txtMemberName.Text;
                DateTime reservationDate = dtpReservationDate.Value;

                if (string.IsNullOrWhiteSpace(memberName))
                {
                    MessageBox.Show("Please enter your name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    Data_Base.OpenConnection();
                    string query = "INSERT INTO trainer_reservations (trainer_id, member_name, reservation_date) " +
                                   "VALUES (@TrainerId, @MemberName, @ReservationDate)";
                    MySqlCommand cmd = new MySqlCommand(query, Data_Base.GetConnection());
                    cmd.Parameters.AddWithValue("@TrainerId", trainerId);
                    cmd.Parameters.AddWithValue("@MemberName", memberName);
                    cmd.Parameters.AddWithValue("@ReservationDate", reservationDate);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Trainer reserved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            else
            {
                MessageBox.Show("Please select a trainer to reserve.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            User_Form viewForm = new User_Form();
            viewForm.Show();
            this.Hide();
        }
    }
}
