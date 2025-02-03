using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gym_Management_System
{
    public partial class TrainerReservationManagement : Form
    {
        public TrainerReservationManagement()
        {
            InitializeComponent();
            LoadTrainerReservations();
        }

        // Load all trainer reservations into DataGridView
        private void LoadTrainerReservations()
        {
            try
            {
                Data_Base.OpenConnection();
                string query = "SELECT tr.id, t.full_name AS TrainerName, tr.member_name, tr.reservation_date " +
                               "FROM trainer_reservations tr " +
                               "INNER JOIN trainers t ON tr.trainer_id = t.id";
                MySqlCommand cmd = new MySqlCommand(query, Data_Base.GetConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dgvTrainerReservations.DataSource = table;
                dgvTrainerReservations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        // Delete Reservation
        private void btnDeleteReservation_Click(object sender, EventArgs e)
        {
            if (dgvTrainerReservations.SelectedRows.Count > 0)
            {
                int reservationId = Convert.ToInt32(dgvTrainerReservations.SelectedRows[0].Cells["id"].Value);

                DialogResult confirm = MessageBox.Show("Are you sure you want to delete this reservation?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        Data_Base.OpenConnection();
                        string query = "DELETE FROM trainer_reservations WHERE id=@ReservationId";
                        MySqlCommand cmd = new MySqlCommand(query, Data_Base.GetConnection());
                        cmd.Parameters.AddWithValue("@ReservationId", reservationId);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Trainer reservation deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadTrainerReservations(); // Refresh DataGridView
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
                MessageBox.Show("Please select a reservation to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            Trainer_Form viewForm = new Trainer_Form();
            viewForm.Show();
            this.Hide();
        }
    }
}
