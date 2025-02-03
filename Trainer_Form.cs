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
    public partial class Trainer_Form : Form
    {
        public Trainer_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
            TrainerRegistrationForm viewForm = new TrainerRegistrationForm();
            viewForm.Show();
            this.Hide();
        }










        private void check_btn_Click(object sender, EventArgs e)
        {
            TrainerReservationForm viewForm = new TrainerReservationForm(); 
            viewForm.Show();
            this.Hide();
        }
    }
}
