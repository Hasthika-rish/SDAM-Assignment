using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gym_Management_System
{
    public partial class EquipmentManagement : Form
    {
        public EquipmentManagement()
        {
            InitializeComponent();
            LoadEquipment(); // Load equipment data when the form opens
        }

        // Load all gym equipment into DataGridView
        private void LoadEquipment()
        {
            try
            {
                Data_Base.OpenConnection();
                string query = "SELECT id, equipment_name, category, quantity, purchase_date, condition_status FROM gym_equipment";
                MySqlCommand cmd = new MySqlCommand(query, Data_Base.GetConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                if (table.Rows.Count == 0)
                {
                    MessageBox.Show("No gym equipment found in the database.", "Data Check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                dgvEquipment.DataSource = table;
                dgvEquipment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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



        // When a row is clicked, fill input fields
        private void dgvEquipment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEquipment.Rows[e.RowIndex];

                txtEquipmentName.Text = row.Cells["equipment_name"].Value.ToString();
                txtQuantity.Text = row.Cells["quantity"].Value.ToString();
                cmbCategory.SelectedItem = row.Cells["category"].Value.ToString();
                cmbCondition.SelectedItem = row.Cells["condition_status"].Value.ToString();
                dtpPurchaseDate.Value = Convert.ToDateTime(row.Cells["purchase_date"].Value);
            }
        }

        // Update Equipment
 

        private void button1_Click(object sender, EventArgs e)
        {
            string equipmentName = txtEquipmentName.Text;
            string category = cmbCategory.SelectedItem?.ToString();
            string conditionStatus = cmbCondition.SelectedItem?.ToString();
            int quantity;

            if (string.IsNullOrWhiteSpace(equipmentName) || category == null || conditionStatus == null)
            {
                MessageBox.Show("Please fill in all required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out quantity))
            {
                MessageBox.Show("Please enter a valid number for quantity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime purchaseDate = dtpPurchaseDate.Value;

            try
            {
                Data_Base.OpenConnection();
                string query = "INSERT INTO gym_equipment (equipment_name, category, quantity, purchase_date, condition_status) " +
                               "VALUES (@EquipmentName, @Category, @Quantity, @PurchaseDate, @ConditionStatus)";

                MySqlCommand cmd = new MySqlCommand(query, Data_Base.GetConnection());
                cmd.Parameters.AddWithValue("@EquipmentName", equipmentName);
                cmd.Parameters.AddWithValue("@Category", category);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                cmd.Parameters.AddWithValue("@PurchaseDate", purchaseDate);
                cmd.Parameters.AddWithValue("@ConditionStatus", conditionStatus);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Equipment added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadEquipment(); // Refresh DataGridView
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvEquipment.SelectedRows.Count > 0)
            {
                int equipmentId = Convert.ToInt32(dgvEquipment.SelectedRows[0].Cells["id"].Value);

                DialogResult confirm = MessageBox.Show("Are you sure you want to delete this equipment?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        Data_Base.OpenConnection();
                        string query = "DELETE FROM gym_equipment WHERE id=@EquipmentId";
                        MySqlCommand cmd = new MySqlCommand(query, Data_Base.GetConnection());
                        cmd.Parameters.AddWithValue("@EquipmentId", equipmentId);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Equipment deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadEquipment(); // Refresh DataGridView
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
                MessageBox.Show("Please select equipment to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvEquipment.SelectedRows.Count > 0)
            {
                int equipmentId = Convert.ToInt32(dgvEquipment.SelectedRows[0].Cells["id"].Value);
                string equipmentName = txtEquipmentName.Text;
                string category = cmbCategory.SelectedItem?.ToString();
                string conditionStatus = cmbCondition.SelectedItem?.ToString();
                int quantity;

                if (string.IsNullOrWhiteSpace(equipmentName) || category == null || conditionStatus == null)
                {
                    MessageBox.Show("Please fill in all required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtQuantity.Text, out quantity))
                {
                    MessageBox.Show("Please enter a valid number for quantity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime purchaseDate = dtpPurchaseDate.Value;

                try
                {
                    Data_Base.OpenConnection();
                    string query = "UPDATE gym_equipment SET equipment_name=@EquipmentName, category=@Category, quantity=@Quantity, purchase_date=@PurchaseDate, condition_status=@ConditionStatus WHERE id=@EquipmentId";
                    MySqlCommand cmd = new MySqlCommand(query, Data_Base.GetConnection());

                    cmd.Parameters.AddWithValue("@EquipmentName", equipmentName);
                    cmd.Parameters.AddWithValue("@Category", category);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("@PurchaseDate", purchaseDate);
                    cmd.Parameters.AddWithValue("@ConditionStatus", conditionStatus);
                    cmd.Parameters.AddWithValue("@EquipmentId", equipmentId);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Equipment updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadEquipment(); // Refresh DataGridView
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

        private void button4_Click(object sender, EventArgs e)
        {
            Admin_Form viewForm = new Admin_Form();
            viewForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
