using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gym_Management_System
{
    public partial class AdminTrainerManagement : Form
    {
        public AdminTrainerManagement()
        {
            InitializeComponent();
            LoadTrainers();
        }

        // Load all trainers into DataGridView
        private void LoadTrainers()
        {
            try
            {
                Data_Base.OpenConnection();
                string query = "SELECT id, full_name, email, phone, specialization, experience, join_date FROM trainers";
                MySqlCommand cmd = new MySqlCommand(query, Data_Base.GetConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dgvTrainers.DataSource = table;
                dgvTrainers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        // Delete Trainer
        private void btnDeleteTrainer_Click(object sender, EventArgs e)
        {
            if (dgvTrainers.SelectedRows.Count > 0)
            {
                int trainerId = Convert.ToInt32(dgvTrainers.SelectedRows[0].Cells["id"].Value);

                DialogResult confirm = MessageBox.Show("Are you sure you want to delete this trainer?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        Data_Base.OpenConnection();
                        string query = "DELETE FROM trainers WHERE id=@TrainerId";
                        MySqlCommand cmd = new MySqlCommand(query, Data_Base.GetConnection());
                        cmd.Parameters.AddWithValue("@TrainerId", trainerId);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Trainer deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadTrainers(); // Refresh DataGridView
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
                MessageBox.Show("Please select a trainer to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_Form viewForm = new Admin_Form();
            viewForm.Show();
            this.Hide();
        }
    }
}
