using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gym_Management_System
{
    public partial class EquipmentReservationForm : Form
    {
        public EquipmentReservationForm()
        {
            InitializeComponent();
            LoadAvailableEquipment();
        }

        // Load available gym equipment into DataGridView
        private void LoadAvailableEquipment()
        {
            try
            {
                Data_Base.OpenConnection();
                string query = "SELECT id, equipment_name, category, quantity, condition_status FROM gym_equipment";
                MySqlCommand cmd = new MySqlCommand(query, Data_Base.GetConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dgvAvailableEquipment.DataSource = table;
                dgvAvailableEquipment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        // Reserve Equipment
        private void btnReserveEquipment_Click(object sender, EventArgs e)
        {
            if (dgvAvailableEquipment.SelectedRows.Count > 0)
            {
                int equipmentId = Convert.ToInt32(dgvAvailableEquipment.SelectedRows[0].Cells["id"].Value);
                string memberName = txtMemberName.Text;
                DateTime reservationDate = dtpReservationDate.Value;
                DateTime returnDate = dtpReturnDate.Value;

                if (string.IsNullOrWhiteSpace(memberName))
                {
                    MessageBox.Show("Please enter a member name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    Data_Base.OpenConnection();
                    string query = "INSERT INTO equipment_reservations (equipment_id, member_name, reservation_date, return_date) " +
                                   "VALUES (@EquipmentId, @MemberName, @ReservationDate, @ReturnDate)";
                    MySqlCommand cmd = new MySqlCommand(query, Data_Base.GetConnection());
                    cmd.Parameters.AddWithValue("@EquipmentId", equipmentId);
                    cmd.Parameters.AddWithValue("@MemberName", memberName);
                    cmd.Parameters.AddWithValue("@ReservationDate", reservationDate);
                    cmd.Parameters.AddWithValue("@ReturnDate", returnDate);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Equipment reserved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Please select equipment to reserve.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
