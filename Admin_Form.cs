using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Management_System
{
    public partial class Admin_Form : Form
    {
        public Admin_Form()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void attendence_btn_Click(object sender, EventArgs e)
        {
            AdminAttendanceManagement viewForm = new AdminAttendanceManagement();
            viewForm.Show();
            this.Hide();
        }

        private void Reistererd_btn_Click(object sender, EventArgs e)
        {
            AdminUserManagement viewForm = new AdminUserManagement();
            viewForm.Show();
            this.Hide();
        }

        private void Equ_btn_Click(object sender, EventArgs e)
        {
            AdminReservationManagement viewForm = new AdminReservationManagement();
            viewForm.Show();
            this.Hide();
        }

        private void Trainers_btn_Click(object sender, EventArgs e)
        {
            AdminTrainerManagement viewForm = new AdminTrainerManagement();
            viewForm.Show();
            this.Hide();
        }

        private void addequ_btn_Click(object sender, EventArgs e)
        {
            EquipmentManagement viewForm = new EquipmentManagement();
            viewForm.Show();
            this.Hide();
        }
    }
}
