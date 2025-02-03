using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gym_Management_System
{
    public partial class AdminReservationManagement : Form
    {
        public AdminReservationManagement()
        {
            InitializeComponent();
            LoadReservedEquipment();
        }

        // Load all reserved gym equipment into DataGridView
        private void LoadReservedEquipment()
        {
            try
            {
                Data_Base.OpenConnection();
                string query = "SELECT er.id, ge.equipment_name, er.member_name, er.reservation_date, er.return_date, er.status " +
                               "FROM equipment_reservations er " +
                               "INNER JOIN gym_equipment ge ON er.equipment_id = ge.id";
                MySqlCommand cmd = new MySqlCommand(query, Data_Base.GetConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dgvReservedEquipment.DataSource = table;
                dgvReservedEquipment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
    

        private void btnDeleteReservation_Click_1(object sender, EventArgs e)
        {
            if (dgvReservedEquipment.SelectedRows.Count > 0)
            {
                int reservationId = Convert.ToInt32(dgvReservedEquipment.SelectedRows[0].Cells["id"].Value);

                try
                {
                    Data_Base.OpenConnection();
                    string query = "DELETE FROM equipment_reservations WHERE id=@ReservationId";
                    MySqlCommand cmd = new MySqlCommand(query, Data_Base.GetConnection());
                    cmd.Parameters.AddWithValue("@ReservationId", reservationId);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Reservation deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadReservedEquipment();
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

        private void btnUpdateReservation_Click_1(object sender, EventArgs e)
        {
            if (dgvReservedEquipment.SelectedRows.Count > 0)
            {
                int reservationId = Convert.ToInt32(dgvReservedEquipment.SelectedRows[0].Cells["id"].Value);
                string memberName = txtMemberName.Text;
                DateTime reservationDate = dtpReservationDate.Value;
                DateTime returnDate = dtpReturnDate.Value;
                string status = cmbStatus.SelectedItem.ToString();

                try
                {
                    Data_Base.OpenConnection();
                    string query = "UPDATE equipment_reservations SET member_name=@MemberName, reservation_date=@ReservationDate, return_date=@ReturnDate, status=@Status " +
                                   "WHERE id=@ReservationId";
                    MySqlCommand cmd = new MySqlCommand(query, Data_Base.GetConnection());
                    cmd.Parameters.AddWithValue("@MemberName", memberName);
                    cmd.Parameters.AddWithValue("@ReservationDate", reservationDate);
                    cmd.Parameters.AddWithValue("@ReturnDate", returnDate);
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@ReservationId", reservationId);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Reservation updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadReservedEquipment();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_Form viewForm = new Admin_Form();
            viewForm.Show();
            this.Hide();
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpReturnDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dtpReservationDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
