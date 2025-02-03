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
    public partial class User_Form : Form
    {
        public User_Form()
        {
            InitializeComponent();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            RegisterForm viewForm = new RegisterForm();
            viewForm.Show();
            this.Hide();
        }

        private void attendence_btn_Click(object sender, EventArgs e)
        {
            UserAttendanceForm viewForm = new UserAttendanceForm();
            viewForm.Show();
            this.Hide();
        }

        private void Equ_btn_Click(object sender, EventArgs e)
        {
            EquipmentReservationForm viewForm = new EquipmentReservationForm();
            viewForm.Show();
            this.Hide();
        }

        private void TrianerR_btn_Click(object sender, EventArgs e)
        {
            TrainerReservationForm viewForm = new TrainerReservationForm();
            viewForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
