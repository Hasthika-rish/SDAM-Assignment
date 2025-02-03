using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gym_Management_System
{
    public partial class AdminUserManagement : Form
    {
        public AdminUserManagement()
        {
            InitializeComponent();
            LoadUsers(); // Ensure data loads when the form opens
        }

        // Method to Load Users into DataGridView
        private void LoadUsers()
        {
            try
            {
                Data_Base.OpenConnection();
                string query = "SELECT id, full_name, email, phone, age, gender, join_date FROM participants";
                MySqlCommand cmd = new MySqlCommand(query, Data_Base.GetConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                if (table.Rows.Count == 0)
                {
                    MessageBox.Show("No users found in the database.", "Data Check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                dgvUsers.DataSource = table;
                dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Ensure columns fill the grid
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

        // Load users when the form is opened
        private void AdminUserManagement_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        // When a user clicks a row, fill the textboxes
        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsers.Rows[e.RowIndex];

                txtFullName.Text = row.Cells["full_name"].Value.ToString();
                txtEmail.Text = row.Cells["email"].Value.ToString();
                txtPhone.Text = row.Cells["phone"].Value.ToString();
                txtAge.Text = row.Cells["age"].Value.ToString();
                cmbGender.SelectedItem = row.Cells["gender"].Value.ToString();
                dtpJoinDate.Value = Convert.ToDateTime(row.Cells["join_date"].Value);
            }
        }

        // Update selected user
        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                int userId = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["id"].Value);
                string fullName = txtFullName.Text;
                string email = txtEmail.Text;
                string phone = txtPhone.Text;

                // Ensure the age field is not empty and is a valid integer
                if (string.IsNullOrWhiteSpace(txtAge.Text) || !int.TryParse(txtAge.Text, out int age))
                {
                    MessageBox.Show("Please enter a valid age (number only).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Ensure gender is selected
                if (cmbGender.SelectedItem == null)
                {
                    MessageBox.Show("Please select a gender.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string gender = cmbGender.SelectedItem.ToString();
                DateTime joinDate = dtpJoinDate.Value;

                try
                {
                    Data_Base.OpenConnection();
                    string query = "UPDATE participants SET full_name=@FullName, email=@Email, phone=@Phone, age=@Age, gender=@Gender, join_date=@JoinDate WHERE id=@UserId";
                    MySqlCommand cmd = new MySqlCommand(query, Data_Base.GetConnection());

                    cmd.Parameters.AddWithValue("@FullName", fullName);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Age", age);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@JoinDate", joinDate);
                    cmd.Parameters.AddWithValue("@UserId", userId);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadUsers(); // Refresh DataGridView
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
                MessageBox.Show("Please select a user to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Delete selected user
        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                int userId = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["id"].Value);

                DialogResult confirm = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        Data_Base.OpenConnection();
                        string query = "DELETE FROM participants WHERE id=@UserId";
                        MySqlCommand cmd = new MySqlCommand(query, Data_Base.GetConnection());
                        cmd.Parameters.AddWithValue("@UserId", userId);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadUsers(); // Refresh DataGridView
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
                MessageBox.Show("Please select a user to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_Form viewForm = new Admin_Form();
            viewForm.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dtpJoinDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
