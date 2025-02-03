namespace Gym_Management_System
{
    partial class TrainerReservationManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainerReservationManagement));
            this.dgvTrainerReservations = new System.Windows.Forms.DataGridView();
            this.btnDeleteReservation = new System.Windows.Forms.Button();
            this.Back_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainerReservations)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTrainerReservations
            // 
            this.dgvTrainerReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrainerReservations.Location = new System.Drawing.Point(58, 141);
            this.dgvTrainerReservations.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvTrainerReservations.Name = "dgvTrainerReservations";
            this.dgvTrainerReservations.RowHeadersWidth = 51;
            this.dgvTrainerReservations.RowTemplate.Height = 24;
            this.dgvTrainerReservations.Size = new System.Drawing.Size(738, 235);
            this.dgvTrainerReservations.TabIndex = 0;
            // 
            // btnDeleteReservation
            // 
            this.btnDeleteReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteReservation.Location = new System.Drawing.Point(657, 453);
            this.btnDeleteReservation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteReservation.Name = "btnDeleteReservation";
            this.btnDeleteReservation.Size = new System.Drawing.Size(204, 78);
            this.btnDeleteReservation.TabIndex = 1;
            this.btnDeleteReservation.Text = "Delete a Reservation";
            this.btnDeleteReservation.UseVisualStyleBackColor = true;
            this.btnDeleteReservation.Click += new System.EventHandler(this.btnDeleteReservation_Click);
            // 
            // Back_btn
            // 
            this.Back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_btn.Location = new System.Drawing.Point(11, 453);
            this.Back_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(197, 78);
            this.Back_btn.TabIndex = 7;
            this.Back_btn.Text = "Back";
            this.Back_btn.UseVisualStyleBackColor = true;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(270, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Delete a Reservation";
            // 
            // TrainerReservationManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(872, 542);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.btnDeleteReservation);
            this.Controls.Add(this.dgvTrainerReservations);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TrainerReservationManagement";
            this.Text = "Trainer Reservation Management";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainerReservations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTrainerReservations;
        private System.Windows.Forms.Button btnDeleteReservation;
        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.Label label1;
    }
}